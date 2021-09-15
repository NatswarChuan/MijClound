using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Live_v1._0
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        string username;
        string password;
        string proxy;
        string userProxy;
        string passProxy;
        string fileUserProxy;
        int _nSoLuong;
        string linkreg = "https://signup.live.com/signup";
        string fileAnticaptcha = "anticaptcha-plugin_v0.58.crx";
        string ProfileFolderPath = "Profile";
        string ExtentionFolderPath = "Extentions";
        bool thread_check = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rBtnNone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNoneCaptcha_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Lấy key phần mềm của riêng máy + CH (Create Hotmail)
        private void label5_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_DiskDrive");
            foreach (ManagementObject getserial in MOS.Get())
            {
                labelKEY.Text = "KEY Phần Mềm của bạn là : " + getserial["SerialNumber"].ToString() + "CH";
            }
        }
        //Coppy key vào Clip
        private void btnCoppyKey_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_DiskDrive");
            foreach (ManagementObject getserial in MOS.Get())
            {
                labelKEY.Text = getserial["SerialNumber"].ToString() + "CH";
            }
            StringBuilder clipboard = new StringBuilder();
            clipboard.Append(labelKEY.Text);
            Clipboard.SetText(clipboard.ToString());
            //Hiện thống báo coppy thành công
            labelKEY.Text = "Coppy KEY Thành Công !";

        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (Data.mang != null)
            {
                Thread thread = new Thread(_thread);
                thread.IsBackground = true;
                thread.Start();
            }
        }

        // nút dừng
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Mở file Username 
        private void btnOpenUser_Click(object sender, EventArgs e)
        {
            try
            {
                string[] mang = File.ReadAllLines(Application.StartupPath + "//Username.txt");

                Data.mang = mang;

                //Mỗi lần mở file xong clear toàn bộ
                resultView.Items.Clear();
                for (int i = 0; i < mang.Length; i++)
                {
                    string row = mang[i];
                    ListViewItem list = new ListViewItem((resultView.Items.Count + 1).ToString());

                    list.SubItems.Add(row);

                    resultView.Items.Add(list);

                };

            }
            catch
            {
                MessageBox.Show("Lỗi File Username");
            }
        }
        //Mở file Proxy 
        private void btnOpenProxy_Click(object sender, EventArgs e)
        {
            try
            {
                string[] proxyArr = File.ReadAllLines(Application.StartupPath + "//proxy.txt");
                string[] mang = File.ReadAllLines(Application.StartupPath + "//Username.txt");

                Data.mang = mang;
                Data.fileProxy = proxyArr;

                //Mỗi lần mở file xong clear toàn bộ
                resultView.Items.Clear();

                int forLoop = (mang.Length > proxyArr.Length) ? mang.Length : proxyArr.Length;
                for (int i = 0; i < forLoop; i++)
                {
                    ListViewItem list = new ListViewItem((resultView.Items.Count + 1).ToString());
                    if (mang.Length - 1 >= i)
                    {
                        string row = mang[i];

                        list.SubItems.Add(row);


                    }

                    if (proxyArr.Length - 1 >= i)
                    {
                        string row1 = proxyArr[i];


                        list.SubItems.Add("");
                        list.SubItems.Add(row1);
                    }
                    resultView.Items.Add(list);

                };
            }
            catch(IOException ioe)
            {
                MessageBox.Show("Lỗi File Username"+ioe);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void resultView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Tiện ích (Thu nhỏ màn hình.....)
        //Ulimited
        void Ulimited(ChromeOptions options)
        {
            options.AddArguments("--window-size=320,480");
            //options.AddArguments("--incognito");
            options.AddArguments("--disable-background-timer-throttling");
            options.AddArguments("--disable-backgrounding-occluded-windows");
            options.AddArguments("--disable-breakpad");
            options.AddArguments("--disable-component-extensions-with-background-pages");
            options.AddArguments("--disable-dev-shm-usage");

            options.AddArguments("--disable-features=TranslateUI,BlinkGenPropertyTrees");
            options.AddArguments("--disable-ipc-flooding-protection");
            options.AddArguments("--disable-renderer-backgrounding");
            options.AddArguments("--enable-features=NetworkService,NetworkServiceInProcess");
            options.AddArguments("--force-color-profile=srgb");
            options.AddArguments("--hide-scrollbars");
            options.AddArguments("--metrics-recording-only");
            options.AddArguments("--mute-audio");
            //chay an 
            //options.AddArguments("--headless");
            options.AddArguments("--no-sandbox");
        }
        // Dưới đây là dành cho đa luồng....


        //Da luong
        void RunMulti()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < nSoLuong.Value; i++)
            {
                Thread dons = new Thread(_thread);
                tasks.Add(Task.Run(() =>
                {
                    dons.Start();
                }));
            }
            watch.Stop();
        }
        void RegisterMulti(List<string> arr)
        {
            try
            {
                int i = arr.Count;
                ListViewItem list = new ListViewItem((resultView.Items.Count + 1).ToString());
                foreach (var row in arr)
                {
                    Thread thread = new Thread(
                        delegate ()
                        {
                            bool check = false;
                            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                            service.HideCommandPromptWindow = true;
                            ChromeOptions options = new ChromeOptions();




                            if (!Directory.Exists(ProfileFolderPath))
                            {
                                Directory.CreateDirectory(ProfileFolderPath);
                            }

                            if (Directory.Exists(ProfileFolderPath))
                            {
                                string nameCount = row;
                                options.AddArguments("user-data-dir=C:\\SON\\" + ProfileFolderPath + "\\" + nameCount);
                            }
                            //
                            //có sử dụng anti thì sẽ cài tiện ích
                            if (rBtnAntiCaptcha.Checked)
                            {
                                try
                                {
                                    options.AddExtension(ExtentionFolderPath + "\\anticaptcha-plugin_v0.58.crx");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi thiết lập captcha, vui lòng kiểm tra file hoặc tắt App đi thử lại ! ");
                                }
                            }
                            // có sử dụng ip thì sẽ chạy cái củ này
                            if (rBtnIPPort.Checked)
                            {
                                if (!string.IsNullOrEmpty(userProxy) && !string.IsNullOrEmpty(passProxy))
                                {
                                    options.AddExtension(ExtentionFolderPath + "\\Proxy Auto Auth.crx");
                                }
                                options.AddArgument(string.Format("--proxy-server={0}", proxy));
                            }

                            //tiện ích
                            Ulimited(options);

                            ChromeDriver chrome = new ChromeDriver(service, options);

                            //nếu có ip:port thì sẽ gọi hàm để chạy
                            if (rBtnIPPort.Checked)
                            {
                                try
                                {
                                    configIP(chrome);
                                }
                                catch (Exception ex)
                                {
                                    chrome.Close();
                                    chrome.Quit();
                                    MessageBox.Show("Cấu hình Port thất bại vui lòng kiểm tra lại!");
                                }

                            }

                            //kiểm tra có sử dụng anti captcha hay không
                            if (rBtnAntiCaptcha.Checked)
                            {
                                try
                                {
                                    configAntiCaptcha(chrome);
                                    Thread.Sleep(2000);
                                }
                                catch (Exception ex)
                                {
                                    chrome.Close();
                                    chrome.Quit();
                                    MessageBox.Show("Lỗi thiết lập captcha, vui lòng kiểm tra file hoặc tắt App đi thử lại ! ");
                                }
                            }

                            //truy  cập link
                            var task = Task.Factory.StartNew(() =>
                            {
                                chrome.Navigate().GoToUrl("https://whoer.net/");
                            });
                            Thread.Sleep(5000);

                            //Cấu hình add
                            #region ADD
                            /*// điền user name từ mảng
                            var task1 = Task.Factory.StartNew(() =>
                            {
                            gtUsername:
                                try
                                {
                                    writeUsername(chrome, row);
                                }
                                catch
                                {
                                    Thread.Sleep(500);
                                    goto gtUsername;
                                }
                            });
                            task1.Wait();
                            //click sau khi điền user 
                            clickAfter(chrome);
                            //đợi để load
                            Thread.Sleep(5000);
                            //điền pass
                            var task2 = Task.Factory.StartNew(() =>
                            {
                            gtPass:
                                try
                                {
                                    writePass(chrome);
                                }
                                catch
                                {
                                    Thread.Sleep(500);
                                    goto gtPass;
                                }
                            });
                            task2.Wait();
                            //click sau khi điền pass 
                            clickAfter(chrome);
                            //chờ
                            Thread.Sleep(2000);

                            //điền ho ten
                            var task3 = Task.Factory.StartNew(() =>
                            {
                            gtHoten:
                                try
                                {
                                    writeHoTen(chrome);
                                }
                                catch
                                {
                                    Thread.Sleep(500);
                                    goto gtHoten;
                                }
                            });
                            task3.Wait();

                            //click sau khi điền họ tên 
                            clickAfter(chrome);

                            //chờ
                            Thread.Sleep(2000);
                            //điền ngày tháng năm sinh
                            var task4 = Task.Factory.StartNew(() =>
                            {
                            gtBirtdays:
                                try
                                {
                                    writeBirtday(chrome);
                                }
                                catch
                                {
                                    Thread.Sleep(500);
                                    goto gtBirtdays;
                                }
                            });
                            task4.Wait();*/

                            //click sau khi điền ngày tháng năm sinh
                            //clickAfter(chrome);
                            //Sau 5s tắt
                            Thread.Sleep(20000);
                            /*chrome.Close();
                            chrome.Quit();*/
                            #endregion

                            thread_check = row.Equals(arr[arr.Count - 1]);
                        });
                    thread.Start();
                }
                // Hiện tại là tầm 20-25s mạng ổn định, chưa tính proxy + captcha
                Thread.Sleep(25000);
            }
            catch
            {
                MessageBox.Show("Thiếu File file.txt hoặc nhập thiếu Trường");
            }
        }
        void configIP(ChromeDriver a)
        {
            //ip có user:pass thì sẽ chạy cái này
            if (!string.IsNullOrEmpty(userProxy) && !string.IsNullOrEmpty(passProxy))
            {
                a.Url = "chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html";
                a.Navigate();

                a.FindElementById("login").SendKeys(username);
                a.FindElementById("password").SendKeys(password);
                a.FindElementById("retry").Clear();
                a.FindElementById("retry").SendKeys("2");

                a.FindElementById("save").Click();
            }
        }

        void configAntiCaptcha(ChromeDriver a)
        {
            a.Navigate().GoToUrl("chrome-extension://lncaoejhfdpcafpkkcddpjnhnodcajfg/options.html");

            //a.FindElement(By.Id("labelWrapper")).Click();

            Thread.Sleep(1000);
            var api = a.FindElement(By.Name("account_key"));
            api.Clear();
            Thread.Sleep(2000);
            api.SendKeys(txtApiAntiCaptcha.Text);

            var autoform = a.FindElement(By.Id("auto_submit_form"));
            autoform.Click();

            var submit = a.FindElement(By.XPath("/html/body/div/input"));
            submit.Click();
        }

        //ghi username
        static void writeUsername(ChromeDriver a, string b)
        {
            var username = a.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div[1]/div[3]/div/div[1]/div[5]/div/div/form/div/div[1]/fieldset/div[1]/div[3]/div[2]/div/input"));
            username.SendKeys(b);
        }
        //click sau khi điền xong user/pass
        void clickAfter(ChromeDriver a)
        {
            a.FindElement(By.Id("iSignupAction")).Click();
        }
        //điền passs
        void writePass(ChromeDriver a)
        {
            var pass = a.FindElement(By.Name("Password"));
            pass.SendKeys(txtPass.Text);
        }
        //điền họ tên
        void writeHoTen(ChromeDriver a)
        {
            string[] InputLines = randomFirstName();
            string[] InputLiness = randomLastName();

            int firstName = 0;
            int lastName = 0;
            var tenTrc = a.FindElement(By.Name("FirstName"));
            tenTrc.Clear();
            int.TryParse(InputLines[InputLines.Length - 1], out lastName);
            tenTrc.SendKeys(InputLines[lastName]);

            var tenSau = a.FindElement(By.Name("LastName"));
            tenSau.Clear();
            int.TryParse(InputLiness[InputLiness.Length - 1], out firstName);
            tenSau.SendKeys(InputLiness[firstName]);
        }
        void writeBirtday(ChromeDriver a)
        {
            Random rd = new Random();

            int rdDays = rd.Next(10, 28);
            int rdMonth = rd.Next(1, 12);

            int rdYears = rd.Next(1990, 2002);

            var days = a.FindElement(By.Name("BirthDay"));
            days.SendKeys(rdDays.ToString());

            SelectElement select = new SelectElement(a.FindElement(By.Id("BirthMonth")));
            select.SelectByValue(rdMonth.ToString());

            var year = a.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div[1]/div[3]/div/div[1]/div[5]/div/div/form/div/div[4]/div[3]/div[3]/input"));
            year.SendKeys(rdYears.ToString());
        }

        public void _thread()
        {
            Data.mang = File.ReadAllLines(Application.StartupPath + "//Username.txt");
            int.TryParse(nSoLuong.Value + "", out _nSoLuong);
            List<string> arr = null;
            if (Data.mang != null)
            {
                for (int i = 0; i < Data.mang.Length; i += _nSoLuong)
                {
                    arr = new List<string>();
                    for (int j = 0; j < _nSoLuong; j++)
                    {
                        if (Data.mang.Length <= i + j)
                        {
                            break;
                        }
                        arr.Add(Data.mang[i + j]);
                    }
                    //while (true) {
                    //    if (thread_check)
                    //    {
                    RegisterMulti(arr);
                    //        break;
                    //    }
                    //}
                }
            }
        }
        //Random Họ
        string[] randomLastName()
        {
            //Random 
            Random rd = new Random();
            #region Test1
            float Percent = 50;
            // Chuỗi ví dụ bao gồm 3 kiểu xuống dòng: \r\n, \n và \r.
            string Input = "Geogre\rHenry\rHelen\rJames\rJane\rAlice\rAnne\rElmer\rBush\rFrank\rMary\rSarah\rSmith\rSusan\rStephen\rWilliam\rRobert\rRichard\rPaul\rMichael\rLily\rJulia\rJoan";
            // Lưu từng dòng
            string[] InputLines;
            // Lưu các chỉ số của các dòng được chọn.
            int[] ChooseLine;

            // CÁCH DÙNG REGEX
            // Regex để tách chuỗi.
            Regex bl = new Regex("\r");
            // Lấy số dòng.
            InputLines = bl.Split(Input);
            // Tính số dòng cần lấy
            ChooseLine = new int[(int)((float)InputLines.Length * (Percent / 100F))];
            // Đối tượng tạo số ngẫu nhiên
            Random r = new Random();
            // Lưu số dòng ngẫu nhiên
            int RandomLine = -1;
            // Lưu kiểm tra trùng
            bool IsDuplicate = false;
            // Lưu chỉ số chạy
            int i = 1;
            // Lấy dòng ngẫu nhiên theo chỉ số dòng bắt đầu từ 0 và nhỉ hơn số dòng.
            while (i < ChooseLine.Length)
            {
                // Lấy ngẫu nhiên.
                RandomLine = r.Next(InputLines.Length);
                // Gán về la không trùng
                IsDuplicate = false;
                // Kiểm tra liệu có trùng
                for (int j = 0; j < i; j++)
                {
                    // Nếu giá trị ngẫu nhiên hiện tại có trùng
                    if (ChooseLine[j] == RandomLine)
                    {
                        // Gán là trùng
                        IsDuplicate = true;
                        // và ngắt vòng lặp j
                        break;
                    }
                }
                // Nếu không trùng
                if (!IsDuplicate)
                {
                    // Gán giá trị vào chỉ số hiện tại
                    ChooseLine[i] = RandomLine;
                    // Tăng i lên 1
                    i++;
                }
            }
            Array.Resize(ref InputLines, InputLines.Length + 1);
            InputLines[InputLines.Length - 1] = "" + ChooseLine[1];
            return InputLines;
            //Console.WriteLine(InputLines[ChooseLine[1]]);
            #endregion
        }
        //Random Tên
        string[] randomFirstName()
        {
            //Random 
            Random rd = new Random();
            #region Test1
            float Percent = 50;
            // Chuỗi ví dụ bao gồm 3 kiểu xuống dòng: \r\n, \n và \r.
            string Input = "Gwyn\rBernie\rClinton\rElias\rFinn\rOtis\rSaint\rSilas\rZane\rAnselm\rAzaria\rBasil\rBenedict\rCarwyn\rClitus\rCuthbert\rEthelbert";
            // Lưu từng dòng
            string[] InputLiness;
            // Lưu các chỉ số của các dòng được chọn.
            int[] ChooseLines;

            // CÁCH DÙNG REGEX
            // Regex để tách chuỗi.
            Regex bl = new Regex("\r");
            // Lấy số dòng.
            InputLiness = bl.Split(Input);
            // Tính số dòng cần lấy
            ChooseLines = new int[(int)((float)InputLiness.Length * (Percent / 100F))];
            // Đối tượng tạo số ngẫu nhiên
            Random r = new Random();
            // Lưu số dòng ngẫu nhiên
            int RandomLine = -1;
            // Lưu kiểm tra trùng
            bool IsDuplicate = false;
            // Lưu chỉ số chạy
            int i = 1;
            // Lấy dòng ngẫu nhiên theo chỉ số dòng bắt đầu từ 0 và nhỉ hơn số dòng.
            while (i < ChooseLines.Length)
            {
                // Lấy ngẫu nhiên.
                RandomLine = r.Next(InputLiness.Length);
                // Gán về la không trùng
                IsDuplicate = false;
                // Kiểm tra liệu có trùng
                for (int j = 0; j < i; j++)
                {
                    // Nếu giá trị ngẫu nhiên hiện tại có trùng
                    if (ChooseLines[j] == RandomLine)
                    {
                        // Gán là trùng
                        IsDuplicate = true;
                        // và ngắt vòng lặp j
                        break;
                    }
                }
                // Nếu không trùng
                if (!IsDuplicate)
                {
                    // Gán giá trị vào chỉ số hiện tại
                    ChooseLines[i] = RandomLine;
                    // Tăng i lên 1
                    i++;
                }
            }
            Array.Resize(ref InputLiness, InputLiness.Length + 1);
            InputLiness[InputLiness.Length - 1] = "" + ChooseLines[1];
            return InputLiness;
            //Console.WriteLine(InputLines[ChooseLine[1]]);
            #endregion
        }


    }
}
