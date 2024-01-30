using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using auto_live_beta.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Timer = System.Windows.Forms.Timer;


namespace auto_live_beta
{
    public partial class Form1 : Form
    { public static Form1 function_send = new Form1();
        System.Timers.Timer timer_1;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
            function_send = this;
        }
        public List<string> openning_count()
        {
            List<string> counting = new List<string>();
            if (checkBox1.Checked == true) { counting.Add("sce"); }
            else if (checkBox1.Checked == false) { counting.Remove("sce"); }
            if (checkBox2.Checked == true) { counting.Add("namiko"); }
            else if (checkBox2.Checked == false) { counting.Remove("namiko"); }
            if (checkBox3.Checked == true) { counting.Add("cocogu"); }
            else if (checkBox3.Checked == false) { counting.Remove("cocogu"); }
            if (checkBox4.Checked == true) { counting.Add("fennix"); }
            else if (checkBox4.Checked == false) { counting.Remove("fennix"); }
            return counting;
        }
        public string get_string() { string data1 = textBox1.Text; return data1; }
        public static string send_string() { string sending_to_control_program = function_send.get_string(); return sending_to_control_program; }
        public static List<string> send_count() { List<string> driver_count = function_send.openning_count(); return driver_count; }

        int count = 1;

        public void button1_Click(object sender, EventArgs e)
        {    
            button1.Enabled = false;
            /*var processToKill = Process.GetProcessesByName("Chrome");
            foreach (var process in processToKill)
            { process.Kill(); }*/
            
            int start_count = Convert.ToInt32(Count_box.Text);
            if (textBox1.Text == string.Empty && Count_box.Text == string.Empty && Time_set.Text == string.Empty)
            { MessageBox.Show("Please enter the live_name"); }
            else if (textBox1.Text != string.Empty && Count_box.Text != string.Empty && Time_set.Text != string.Empty)
            {
                //for(int i = 0; i <= Count_box.Text.Length; i++) 
                //{
                control_program.quit_driver1();
                //Thread store1 = new Thread(new ThreadStart(control_program.SCE_run));
                //Thread store2 = new Thread(new ThreadStart(control_program.namiko_run));
                Thread store3 = new Thread(new ThreadStart(control_program.Cocogu_run));
                //Thread store4 = new Thread(new ThreadStart(control_program.Fennix_run));
                obs_control.minimized();
                if (checkBox1.Checked == true)
                {

                }
                if (checkBox2.Checked == true)
                {
                    //store2.Start();
                }
                if (checkBox3.Checked == true)
                {
                   store3.Start();
                }
                if (checkBox4.Checked == true)
                {

                }
                //try { store1.Join(); store1.Abort(); } catch { }
                //try { store2.Join(); store2.Abort(); } catch { }
                try { store3.Join(); store3.Abort(); } catch { }
                //try { store4.Join(); store4.Abort(); } catch { }*/
                obs_control.maximized();
                if (checkBox1.Checked == true)
                {

                }
                if (checkBox2.Checked == true)
                {

                }
                if (checkBox3.Checked == true)
                {
                    control_program.Cocogu_run2();
                }
                if (checkBox4.Checked == true)
                {

                }
                obs_control.start_all1();
                if (checkBox1.Checked == true)
                {

                }
                if (checkBox2.Checked == true)
                {

                }
                if (checkBox3.Checked == true)
                {
                    control_program.Cocogu_run3();
                }
                if (checkBox4.Checked == true)
                {

                }
                if (count == Convert.ToInt32(Count_box.Text))
                {
                    main1();
                    MessageBox.Show("end"); 
                }
                else if(Count_box.Text == "1") 
                {
                    timer_box.Text = "00:00:00";
                    timer_1.Start();
                    Timer check_timer = new Timer();
                    check_timer.Interval = 1000;
                    check_timer.Start();
                    count++;
                    check_timer.Tick += (y, a) =>
                    {
                        if (timer_box.Text == Time_set.Text)
                        {
                            timer_1.Stop();
                            check_timer.Stop();
                            s = 0;
                            m = 0;
                            h = 0;
                            timer_box.Text = "00:00:00";
                            if (checkBox1.Checked == true)
                            {

                            }
                            if (checkBox2.Checked == true)
                            {

                            }
                            if (checkBox3.Checked == true)
                            {
                                control_program.Cocogu_run4();
                            }
                            if (checkBox4.Checked == true)
                            {

                            }
                            obs_control.minimized();
                            obs_control.maximized();
                            obs_control.stop_all();
                            /*var processToKill = Process.GetProcessesByName("Chrome");
                            foreach (var process in processToKill)
                            { process.Kill(); }*/
                            //MessageBox.Show("real_end");
                        }
                    };
                }
                else
                {
                    timer_box.Text = "00:00:00";
                    timer_1.Start();
                    Timer check_timer = new Timer();
                    check_timer.Interval = 1000;
                    check_timer.Start();
                    count++;
                    check_timer.Tick += (y, a) =>
                    {
                        if (timer_box.Text == Time_set.Text)
                        {
                            timer_1.Stop();
                            check_timer.Stop();
                            s = 0;
                            m = 0;
                            h = 0;
                            timer_box.Text = "00:00:00";
                            if (checkBox1.Checked == true)
                            {

                            }
                            if (checkBox2.Checked == true)
                            {

                            }
                            if (checkBox3.Checked == true)
                            {
                                control_program.Cocogu_run4();
                            }
                            if (checkBox4.Checked == true)
                            {

                            }
                            obs_control.minimized();
                            obs_control.maximized();
                            obs_control.stop_all();
                            button1_Click(sender, new EventArgs());
                        }
                    };
                }

            }
            else
            { MessageBox.Show("insert value"); }

        }
        public void main1() 
        {
            timer_box.Text = "00:00:00";
            timer_1.Start();
            Timer check_timer = new Timer();
            check_timer.Interval = 1000;
            check_timer.Start();
            count++;
            check_timer.Tick += (y, a) =>
            {
                if (timer_box.Text == Time_set.Text)
                {
                    timer_1.Stop();
                    check_timer.Stop();
                    s = 0;
                    m = 0;
                    h = 0;
                    timer_box.Text = "00:00:00";
                    if (checkBox1.Checked == true)
                    {

                    }
                    if (checkBox2.Checked == true)
                    {

                    }
                    if (checkBox3.Checked == true)
                    {
                        control_program.Cocogu_run4();
                    }
                    if (checkBox4.Checked == true)
                    {

                    }
                    obs_control.minimized();
                    obs_control.maximized();
                    obs_control.stop_all();
                }
            };
        }        
        public static void run_same_time()
        {
            string userProfilePath1 = @"C:\Users\Anuson\AppData\Local\Google\Chrome\User Data\";
            string userProfilePath2 = @"C:\Users\Anuson\AppData\Local\Google\Chrome\User Data_selenium\";

            // Create Chrome options with the specified user profile paths
            var options1 = new ChromeOptions();
            options1.AddArguments($"--user-data-dir={userProfilePath1}");
            options1.AddArguments(@"--profile-directory=Profile 9");


            var options2 = new ChromeOptions();
            options2.AddArguments($"--user-data-dir={userProfilePath2}");
            options2.AddArguments(@"--profile-directory=Profile 7");

            // Create ChromeDriver instances with the specified options

            IWebDriver driver1 = new ChromeDriver(options1);
            IWebDriver driver2 = new ChromeDriver(options2);
        }
        Boolean time_end = false;
        private void button2_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < 10; p++) { 
            Timer timer_condition = new Timer();
            timer_condition.Interval = 1000;
            timer_condition.Tick += (y, a) =>
            {
                timer_1.Start();
                if (timer_box.Text == "00:00:10")
                {
                    timer_1.Stop();
                    timer_condition.Stop();
                    h = 0;
                    m = 0;
                    s = 0;
                    timer_box.Text = "00:00:00";
                    if (checkBox1.Checked == true)
                    {

                    }
                    if (checkBox2.Checked == true)
                    {

                    }
                    if (checkBox3.Checked == true)
                    {
                        control_program.Cocogu_run4();
                    }
                    if (checkBox4.Checked == true)
                    {

                    }
                    obs_control.minimized();
                    obs_control.maximized();
                    obs_control.stop_all();
                    var processToKill = Process.GetProcessesByName("Chrome");
                    foreach (var process in processToKill)
                    { process.Kill(); }
                    MessageBox.Show("real_end");
                }
            };
            timer_condition.Start();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list = openning_count();
            foreach (string a in list){ MessageBox.Show(a.ToString()); }
        }
        private void open_sce_chrome_Click(object sender, EventArgs e)
        {
            var options_SCE = new ChromeOptions();
            options_SCE.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(SCE)", "--profile-directory=Profile 10");
            IWebDriver driver_SCE = new ChromeDriver(options_SCE);
            driver_SCE.Navigate().GoToUrl("https://subaccount.shopee.com/");
        }
        private void open_namiko_chrome_Click(object sender, EventArgs e)
        {
            var options_namiko = new ChromeOptions();
            options_namiko.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(Namiko)", "--profile-directory=Profile 9");
            IWebDriver driver_namiko = new ChromeDriver(options_namiko);
            driver_namiko.Navigate().GoToUrl("https://subaccount.shopee.com/");
        }
        private void open_cocogu_chrome_Click(object sender, EventArgs e)
        {
            var options_Cocogu = new ChromeOptions();
            options_Cocogu.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(Cocogu)", "--profile-directory=Profile 11");
            IWebDriver driver_Cocogu = new ChromeDriver(options_Cocogu);
            driver_Cocogu.Navigate().GoToUrl("https://subaccount.shopee.com/");
        }
        private void open_fennix_chrome_Click(object sender, EventArgs e)
        {
            var options_Fennix = new ChromeOptions();
            options_Fennix.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(Fennix)", "--profile-directory=Profile 12");
            IWebDriver driver_Fennix = new ChromeDriver(options_Fennix);
            driver_Fennix.Navigate().GoToUrl("https://subaccount.shopee.com/");
        }

        private void timer_box_TextChanged(object sender, EventArgs e)
        {
            /*if (timer_box.Text == "00:00:05") 
            {
                time_end = true;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_1 = new System.Timers.Timer();
            timer_1.Interval = 1000;
            timer_1.Elapsed += counting_up;
        }
        public void counting_up(object sender,System.Timers.ElapsedEventArgs e) 
        { 
            Invoke(new Action(() => 
            {
                s += 1;
                if(s == 60) 
                { 
                    s = 0;
                    m += 1;
                }
                if(m == 60) 
                {
                    m = 0; 
                    h += 1;
                }
                timer_box.Text = string.Format("{0}:{1}:{2}",h.ToString().PadLeft(2,'0'),m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }

            ));
        }
    }
}
