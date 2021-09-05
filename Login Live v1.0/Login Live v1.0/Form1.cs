using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Text;
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
        string fileUserProxy;
        int _nSoLuong;


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
        //Mở file Username || Proxy
        private void btnOpenUser_Click(object sender, EventArgs e)
        {
            try
            {
                string[] mang = File.ReadAllLines(Application.StartupPath + "//File.txt");

                Data.mang = mang;

                int i = 0;
                //Mỗi lần mở file xong clear toàn bộ
                resultView.Items.Clear();
            Load:
                string row = mang[i];
                ListViewItem list = new ListViewItem((resultView.Items.Count + 1).ToString());

                list.SubItems.Add(row);

                resultView.Items.Add(list);
                i++;
                if (i < mang.Length)
                    goto Load;
            }
            catch
            {
                MessageBox.Show("Thiếu File file.txt hoặc nhập thiếu Trường");
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
            options.AddArguments("--incognito");

            options.AddArguments("--disable-background-timer-throttling");
            options.AddArguments("--disable-backgrounding-occluded-windows");
            options.AddArguments("--disable-breakpad");
            options.AddArguments("--disable-component-extensions-with-background-pages");
            options.AddArguments("--disable-dev-shm-usage");
            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-features=TranslateUI,BlinkGenPropertyTrees");
            options.AddArguments("--disable-ipc-flooding-protection");
            options.AddArguments("--disable-renderer-backgrounding");
            options.AddArguments("--enable-features=NetworkService,NetworkServiceInProcess");
            options.AddArguments("--force-color-profile=srgb");
            options.AddArguments("--hide-scrollbars");
            options.AddArguments("--metrics-recording-only");
            options.AddArguments("--mute-audio");
            //chay an 
            //options.addArguments("--headless");
            options.AddArguments("--no-sandbox");
        }
        // Dưới đây là dành cho đa luồng....

        //Hàm đa luồng
        void RegisterMulti()
        {

        }
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
        // hàm thâu
        void Mot()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            string str = DateTime.Now.ToString().Trim();
            MessageBox.Show(str);
        }
        void Testt(List<string> arr)
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
                            /*                options.AddArguments("--proxy-server=http://user:password@yourProxyServer.com:8080");
                            */
                            Ulimited(options);
                            ChromeDriver chrome = new ChromeDriver(service, options);
                            chrome.Navigate().GoToUrl("https://signup.live.com/signup");
                            var username = chrome.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div[1]/div[3]/div/div[1]/div[5]/div/div/form/div/div[1]/fieldset/div[1]/div[3]/div[2]/div/input"));
                            username.SendKeys(row);

                            do
                            {
                                try
                                {
                                    chrome.FindElement(By.Id("iSignupAction")).Click();
                                    check = false;
                                }
                                catch
                                {
                                    check = true;
                                    Thread.Sleep(500);
                                }
                            } while (check);

                            do
                            {
                                try
                                {
                                    var pass = chrome.FindElement(By.Name("Password"));
                                    pass.SendKeys("SONkhung1*");
                                    check = false;
                                }
                                catch
                                {
                                    check = true;
                                    Thread.Sleep(500);
                                }
                            } while (check);

                            do
                            {
                                try
                                {
                                    chrome.FindElement(By.Id("iSignupAction")).Click();
                                    check = false;
                                }
                                catch
                                {
                                    check = true;
                                    Thread.Sleep(500);
                                }
                            } while (check);

                            chrome.Close();
                            chrome.Quit();
                        });
                    thread.Start();
                }
                Thread.Sleep(1000);
            }
            catch
            {
                MessageBox.Show("Thiếu File file.txt hoặc nhập thiếu Trường");
            }
        }

        public void _thread()
        {
            Data.mang = File.ReadAllLines(Application.StartupPath + "//File.txt");
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
                    Testt(arr);
                }
            }
        }
    }
}
