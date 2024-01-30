using auto_live_beta.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_live_beta
{
    internal class obs_control
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        public static obs_control send_obs = new obs_control();
        
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
        }
        public static void leftClick(Point p)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0); //drag hold
            Thread.Sleep(100);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);   //something like hands out
        }
        int i = 0;
        public void image_locate(Point MousePosition)
        {

            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                //Resources.sence_collection,Resources.new_cocogu,Resources.setting,Resources.stream_setting,Resources.apply,Resources.OK
            };

            Boolean image_checker = false;
            while (image_checker == false)
            {
                try
                {
                    Bitmap targetImage = new Bitmap(bitmaps_list[0 + i]);
                    Point result = LocateImageOnScreen(targetImage);
                    if (result.X != -1 && result.Y != -1)
                    {
                        var cal1x = targetImage.Width / 2;
                        var cal1y = targetImage.Height / 2;
                        Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                        Thread.Sleep(100);
                        leftClick(new Point(MousePosition.X, MousePosition.Y));
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
        public static void SCE_set1()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                //Resources.sence_collection,Resources.SCE,Resources.setting,Resources.stream_setting
            };
            int step = 0;
            for (step = 0; step < bitmaps_list.Count; step++)
            {
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[0 + step]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                            Thread.Sleep(100);
                            leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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

                    }
                }
            }
        }
        public static void namiko_set1()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                //Resources.sence_collection,Resources.Namiko,Resources.setting,Resources.stream_setting
            };
            int step = 0;
            for(step = 0; step < bitmaps_list.Count; step++) { 
            Boolean image_checker = false;
            while (image_checker == false)
            {
                try
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Bitmap targetImage = new Bitmap(bitmaps_list[0 + step]);
                    Point result = LocateImageOnScreen(targetImage);
                    if (result.X != -1 && result.Y != -1)
                    {
                        var cal1x = targetImage.Width / 2;
                        var cal1y = targetImage.Height / 2;
                        Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                        Thread.Sleep(100);
                        leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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
                    
                }
                }
            }
        }
        public static void Cocogu_set1()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                Resources.Cocogu
            };
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[0]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            var modifyx = (result.X + cal1x)+155;
                            var modifyy = (result.Y + cal1y)+30;
                            Cursor.Position = new Point(modifyx, modifyy);
                            Thread.Sleep(100);
                            leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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

                    }
                }
            
        }
        public static void Fennix_set1()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                //Resources.sence_collection,Resources.Fennix,Resources.setting,Resources.stream_setting
            };
            int step = 0;
            for (step = 0; step < bitmaps_list.Count; step++)
            {
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[0 + step]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                            Thread.Sleep(100);
                            leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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

                    }
                }
            }
        }

        public static void final_move()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                Resources.OK
            };
            int step = 0;
            for (step = 0; step < bitmaps_list.Count; step++)
            {
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[0 + step]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                            Thread.Sleep(100);
                            leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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

                    }
                }
            }
        }
        public static void start_all1 ()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                Resources.Start_all
            };
            int step = 0;
            for (step = 0; step < bitmaps_list.Count; step++)
            {
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[0 + step]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                            Thread.Sleep(100);
                            leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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

                    }
                }
            }
        }
        public static void maximized()
        {
            const int SW_MAXIMIZE = 3;
            var obs_only = "obs64";
            Process[] processes = Process.GetProcessesByName(obs_only);
            foreach (var process in processes)
            {
                IntPtr windowHandle = FindWindow(null, process.MainWindowTitle);
                ShowWindow(windowHandle, SW_MAXIMIZE);
            }

        }
        public static void minimized()
        {
            const int SW_MINIMIZE = 6;
            var obs_only = "obs64";
            Process[] processes = Process.GetProcessesByName(obs_only);
            foreach (var process in processes)
            {
                IntPtr windowHandle = FindWindow(null, process.MainWindowTitle);
                ShowWindow(windowHandle, SW_MINIMIZE);
            }
        }
        public static void stop_all()
        {
            List<Bitmap> bitmaps_list = new List<Bitmap>()
            {
                Resources.Stop_all
            };
            int step = 0;
            for (step = 0; step < bitmaps_list.Count; step++)
            {
                Boolean image_checker = false;
                while (image_checker == false)
                {
                    try
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Bitmap targetImage = new Bitmap(bitmaps_list[0 + step]);
                        Point result = LocateImageOnScreen(targetImage);
                        if (result.X != -1 && result.Y != -1)
                        {
                            var cal1x = targetImage.Width / 2;
                            var cal1y = targetImage.Height / 2;
                            Cursor.Position = new Point(result.X + cal1x, result.Y + cal1y);
                            Thread.Sleep(100);
                            leftClick(new Point(Cursor.Position.X, Cursor.Position.Y));
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

                    }
                }
            }
        }

        public static void obs_openning()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = @"C:\Program Files\obs-studio\bin\64bit"; // like cd path command
            startInfo.FileName = "obs64.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(startInfo);
        }

        public static void if_already_running() 
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < 3000) 
            {
                
            }
            sw.Stop();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        /*public void function_click()
{
   image_locate(); //sence_collection
   i++;
   image_locate(); //store_name
   i++;
   image_locate(); //setting
   i++;
   image_locate(); //stream
   i++;
   image_locate_server_key(); //stream server
   copy_paste++;
   image_locate_server_key(); //stream key
   image_locate(); //apply
   i++;
   image_locate(); //OK

   MessageBox.Show("end");
}*/
    }
}
