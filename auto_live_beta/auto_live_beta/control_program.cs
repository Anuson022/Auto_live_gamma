using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using auto_live_beta.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace auto_live_beta
{
    class control_program
    {
        public static string live_name = Form1.send_string();

        public static control_program get_sent = new control_program();
        List<string> count = Form1.send_count();
        IWebDriver driver_namiko = new ChromeDriver(service(),chrome_data_namiko());
        static ChromeOptions chrome_data_namiko()
        {
            var options = new ChromeOptions();
            options.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(Namiko)", "--profile-directory=Profile 9");
            return options;
        }
        IWebDriver driver_SCE = new ChromeDriver(service(), chrome_data_SCE());
        static ChromeOptions chrome_data_SCE()
        {
            var options = new ChromeOptions();
            options.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(SCE)", "--profile-directory=Profile 10");
            return options;
        }

        IWebDriver driver_Cocogu = new ChromeDriver(service(), chrome_data_Cocogu());
        static ChromeOptions chrome_data_Cocogu()
        {
            var options = new ChromeOptions();
            options.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(Cocogu)", "--profile-directory=Profile 11");
            return options;
        }
        IWebDriver driver_Fennix = new ChromeDriver(service(), chrome_data_Fennix());
        static ChromeOptions chrome_data_Fennix()
        {
            var options = new ChromeOptions();
            options.AddArguments(@"--user-data-dir=C:\Chrome_data\User_data(Fennix)", "--profile-directory=Profile 12");
            return options;
        }
        static ChromeDriverService service()
        {
            var services = ChromeDriverService.CreateDefaultService();
            services.HideCommandPromptWindow = true;
            return services;
        }
        public void quit_driver() 
        { 
            /*if (count.Contains("sce") == false) { driver_SCE.Quit(); }
            if (count.Contains("namiko") == false) { driver_namiko.Quit(); }
            if (count.Contains("cocogu") == false) { driver_Cocogu.Quit(); }
            if (count.Contains("fennix") == false) { driver_Fennix.Quit(); }*/
        }
        public void selenium_namiko()
        {
            IJavaScriptExecutor javascript_namiko = (IJavaScriptExecutor)driver_namiko;
            driver_namiko.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver_namiko.Navigate().GoToUrl("https://live.shopee.co.th/pc/setup");
            driver_namiko.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[4]/div/div/div[1]/input")).SendKeys("test1"); //ใส่ชื่อ
            driver_namiko.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div[2]/div[8]/div[1]/button")).Click(); //กดเพิ่มสินค้า
            var index_bug_fix = 0;
            try
            {
                driver_namiko.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                driver_namiko.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/aside/nav/ul/li[1]")).Click(); //like_product
                index_bug_fix = 2;
                driver_namiko.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Stopwatch stop_scroll1 = new Stopwatch();
                stop_scroll1.Start();
                while (stop_scroll1.ElapsedMilliseconds < 7000)
                {
                    IWebElement scroll_finder = driver_namiko.FindElement(By.XPath("//*[@id=\"product-select-scroll-container\"]"));
                    javascript_namiko.ExecuteScript("arguments[0].scrollTop += 5000;", scroll_finder);
                }
                stop_scroll1.Stop();
                IList<IWebElement> checkbox_checked_all1 = driver_namiko.FindElements(By.CssSelector("input[type='checkbox']"));
                foreach (IWebElement checkbox1 in checkbox_checked_all1)
                {
                    if (!checkbox1.Selected)
                    {
                        driver_namiko.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[1]/label/span[1]")).Click();
                    }
                    else { MessageBox.Show("error"); }
                }
            }
            catch { }
            Thread.Sleep(100);
            driver_namiko.FindElement(By.XPath($"/html/body/div[4]/div/div/div/div[1]/div/aside/nav/ul/li[{index_bug_fix}]")).Click();
            index_bug_fix = 3;
            Stopwatch stop_scroll2 = new Stopwatch();
            stop_scroll2.Start();
            while (stop_scroll2.ElapsedMilliseconds < 7000)
            {
                IWebElement scroll_finder = driver_namiko.FindElement(By.XPath("//*[@id=\"product-select-scroll-container\"]"));
                javascript_namiko.ExecuteScript("arguments[0].scrollTop += 5000;", scroll_finder);
            }
            stop_scroll2.Stop();
            IList<IWebElement> checkbox_checked_all2 = driver_namiko.FindElements(By.CssSelector("input[type='checkbox']"));
            foreach (IWebElement checkbox2 in checkbox_checked_all2)
            {
                if (!checkbox2.Selected)
                {
                    driver_namiko.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[1]/label/span[1]")).Click();
                }
                else { MessageBox.Show("error"); }
            }
            Thread.Sleep(100);
            try
            {
                driver_namiko.FindElement(By.XPath($"/html/body/div[4]/div/div/div/div[1]/div/aside/nav/ul/li[{index_bug_fix}]")).Click();
                Stopwatch stop_scroll3 = new Stopwatch();
                stop_scroll3.Start();
                while (stop_scroll3.ElapsedMilliseconds < 7000)
                {
                    IWebElement scroll_finder = driver_namiko.FindElement(By.XPath("//*[@id=\"product-select-scroll-container\"]"));
                    javascript_namiko.ExecuteScript("arguments[0].scrollTop += 5000;", scroll_finder);
                }
                stop_scroll2.Stop();
                IList<IWebElement> checkbox_checked_all3 = driver_namiko.FindElements(By.CssSelector("input[type='checkbox']"));
                foreach (IWebElement checkbox3 in checkbox_checked_all3)
                {
                    if (!checkbox3.Selected)
                    {
                        driver_namiko.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[1]/label/span[1]")).Click();
                    }
                    else
                    {  //test live
                    }
                }
            }
            catch { }
            driver_namiko.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[2]/button[2]")).Click();
            driver_namiko.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[10]/div[1]/label[2]/span[1]")).Click(); //test live
            var finder = driver_namiko.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[8]/div[2]/div/div/div[3]/div[1]/div/div/div[2]/table/tbody/tr/td[1]/div/span")); //find product
            driver_namiko.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[11]/div/button")).Click();

        }
        public static void namiko_run() { get_sent.selenium_namiko(); }
        public void namiko_continue()
        {
            driver_namiko.FindElement(By.XPath(""));  //copy server key
            int step = 0;
            //find namiko multi image
            //click modify
            //click stream server
            //paste
            //click stream key;
            //paste
            //OK
            //find image namiko where start is

            //
        }
        public void stop_namiko() 
        { 
            driver_namiko = null;//find image and stop     //namiko driver quit
        }
        
        public void selenium_Cocogu()
        {
            IJavaScriptExecutor javascript_Cocogu = (IJavaScriptExecutor)driver_Cocogu;
            driver_Cocogu.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver_Cocogu.Navigate().GoToUrl("https://live.shopee.co.th/pc/setup");
            driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[3]/div[4]/div/div/div[1]/input")).SendKeys(live_name); //ใส่ชื่อ
            driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[3]/div[8]/div[1]/button")).Click(); //กดเพิ่มสินค้า
            var index_bug_fix = 1;
            try
            {
                driver_Cocogu.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                driver_Cocogu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/aside/nav/ul/li[1]")).Click(); //like_product
                index_bug_fix = 2;
                driver_Cocogu.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Stopwatch stop_scroll1 = new Stopwatch();
                stop_scroll1.Start();
                while (stop_scroll1.ElapsedMilliseconds < 7000)
                {
                    IWebElement scroll_finder = driver_Cocogu.FindElement(By.XPath("//*[@id=\"product-select-scroll-container\"]"));
                    javascript_Cocogu.ExecuteScript("arguments[0].scrollTop += 5000;", scroll_finder);
                }
                stop_scroll1.Stop();
                IList<IWebElement> checkbox_checked_all1 = driver_Cocogu.FindElements(By.CssSelector("input[type='checkbox']"));
                foreach (IWebElement checkbox1 in checkbox_checked_all1)
                {
                    if (!checkbox1.Selected)
                    {
                        driver_Cocogu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[1]/label/span[1]")).Click();
                    }
                    else { MessageBox.Show("error"); }
                }
            }
            catch { }
            Thread.Sleep(100);
            try
            {
            driver_Cocogu.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver_Cocogu.FindElement(By.XPath($"/html/body/div[4]/div/div/div/div[1]/div/aside/nav/ul/li[{index_bug_fix}]")).Click();
            index_bug_fix = 3;
            Stopwatch stop_scroll2 = new Stopwatch();
            stop_scroll2.Start();
            while (stop_scroll2.ElapsedMilliseconds < 7000)
            {
                IWebElement scroll_finder = driver_Cocogu.FindElement(By.XPath("//*[@id=\"product-select-scroll-container\"]"));
                javascript_Cocogu.ExecuteScript("arguments[0].scrollTop += 5000;", scroll_finder);
            }
            stop_scroll2.Stop();
            IList<IWebElement> checkbox_checked_all2 = driver_Cocogu.FindElements(By.CssSelector("input[type='checkbox']"));
            foreach (IWebElement checkbox2 in checkbox_checked_all2)
            {
                if (!checkbox2.Selected)
                {
                    driver_Cocogu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[1]/label/span[1]")).Click();
                }
                else { MessageBox.Show("error"); }
            }
            Thread.Sleep(100);
            driver_Cocogu.FindElement(By.XPath($"/html/body/div[4]/div/div/div/div[1]/div/aside/nav/ul/li[{index_bug_fix}]")).Click();
            Stopwatch stop_scroll3 = new Stopwatch();
            stop_scroll3.Start();
            while (stop_scroll3.ElapsedMilliseconds < 7000)
            {
                IWebElement scroll_finder = driver_Cocogu.FindElement(By.XPath("//*[@id=\"product-select-scroll-container\"]"));
                javascript_Cocogu.ExecuteScript("arguments[0].scrollTop += 5000;", scroll_finder);
            }
            stop_scroll2.Stop();
            IList<IWebElement> checkbox_checked_all3 = driver_Cocogu.FindElements(By.CssSelector("input[type='checkbox']"));
            foreach (IWebElement checkbox3 in checkbox_checked_all3)
            {
                if (!checkbox3.Selected)
                {
                    driver_Cocogu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[1]/label/span[1]")).Click();
                }
                else
                {  //test live
                }
            }
            }
            catch { }
            driver_Cocogu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div/article/div[3]/div[2]/button[2]")).Click();
            //driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[3]/div[10]/div[1]/label[2]/span[1]")).Click() ; //test live
            var finder = driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[3]/div[8]/div[2]/div/div/div[3]/div[1]/div/div/div[2]/table/tbody/tr[5]/td[2]/div/div/div[2]/p")); //find product
            driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[3]/div[11]/div/button")).Click();
        }
        public void Cocogu_continue() 
        {
            int step = 0;
            driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/article/div/section[2]/div/div/article/section/div[2]/button")).Click();  //copy server key
            obs_control.Cocogu_set1();
            Cocogu_paste();
            driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/article/div/section[2]/div/div/article/section/div[4]/button")).Click();  //copy server key
            step++;
            Cocogu_paste();
            obs_control.final_move();
            void Cocogu_paste()
            {
                List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                Resources.URL,Resources.Stream_key
            };
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[step]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            Cursor.Position = new Point(result.X + cal1x + 200, result.Y + cal1y);
                            Thread.Sleep(100);
                            obs_control.leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
                            SendKeys.Send("^(a)");
                            Thread.Sleep(100);
                            SendKeys.Send("^(v)");
                            image_checker = true;
                            Thread.Sleep(100);
                        }
                        Point LocateImageOnScreen(Bitmap targetImage1)
                        {

                            Bitmap screenCapture1 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                            using (Graphics g = Graphics.FromImage(screenCapture1))
                            {
                                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, screenCapture1.Size);

                            }

                            for (int y = 0; y < screenCapture1.Height - targetImage1.Height; y++)
                            {
                                for (int x = 0; x < screenCapture1.Width - targetImage1.Width; x++)
                                {
                                    if (ImageMatches(targetImage1, screenCapture1, x, y))
                                    {
                                        return new Point(x, y);
                                    }
                                }
                            }

                            return new Point(-1, -1);
                        }
                        bool ImageMatches(Bitmap targetImage2, Bitmap screenCapture2, int x, int y)
                        {
                            for (int i = 0; i < targetImage2.Width; i++)
                            {
                                for (int j = 0; j < targetImage2.Height; j++)
                                {
                                    if (targetImage2.GetPixel(i, j) != screenCapture2.GetPixel(x + i, y + j))
                                    {
                                        return false;
                                    }
                                }
                            }
                            return true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Image not found on the screen.");
                    }
                }
            }
            //
        }
        public void Cocogu_start() {driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/header/div/div[2]/div[3]/button")).Click();}
        public void Cocogu_stop() 
        { 
            driver_Cocogu.FindElement(By.XPath("/html/body/div[1]/div/header/div/div[2]/div[2]/button")).Click();
            driver_Cocogu.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[1]/div[3]/div/button[2]")).Click();
        }
        public static void quit_driver1() { get_sent.quit_driver(); }

        public static void Cocogu_run() { get_sent.selenium_Cocogu(); }
        public static void Cocogu_run2() { get_sent.Cocogu_continue(); }
        public static void Cocogu_run3() { get_sent.Cocogu_start(); }
        public static void Cocogu_run4() {  get_sent.Cocogu_stop(); }


    }

    class Program1
    {
        public static control_program instance1 = new control_program();
    }

}


