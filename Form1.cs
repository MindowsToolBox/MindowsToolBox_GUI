using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindowsToolBox
{
    public partial class Form1 : Form
    {

        #region 窗体阴影
        private int RadiusOrShadow = 1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000; // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX; // 允许最小化操作

                m_aeroEnabled = CheckAeroEnabled();
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        if (RadiusOrShadow == 1)
                        {
                            var v = 2;
                            DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                            MARGINS margins = new MARGINS()
                            {
                                bottomHeight = 1,
                                leftWidth = 1,
                                rightWidth = 1,
                                topHeight = 1
                            };
                            DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                        }
                    }
                    break;

                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;
        }

        #endregion 窗体阴影
        #region 窗体移动，按钮相关
        [DllImport("user32.dll")]  //需添加using System.Runtime.InteropServices
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


        private void p_close_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackgroundImage = Properties.Resources.buttons_close;
        }

        private void p_close_MouseLeave(object sender, EventArgs e)
        {
            this.panel5.BackgroundImage = Properties.Resources.buttons_normal;
        }

        private void p_mini_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackgroundImage = Properties.Resources.buttons_mini;
        }

        private void p_mini_MouseLeave(object sender, EventArgs e)
        {
            this.panel5.BackgroundImage = Properties.Resources.buttons_normal;
        }

        private void p_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        public static string windir = System.Environment.GetEnvironmentVariable("windir");
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.panel5.BackgroundImage = Properties.Resources.buttons_normal;
            TransparencyKey = Color.FromArgb(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //启动后台检查更新
            //Process cmdProcess = new Process();
            //cmdProcess.StartInfo.FileName = @"bin\update.bat";
            //cmdProcess.StartInfo.Arguments = @"bg";
            //cmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //cmdProcess.Start();

            Form2 form2 = new Form2();
            form2.TopLevel = false;
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
            form2.Parent = this.panel3;

            //string Source = windir + @"\System32\bcdboot.exe";
            //string Target = @"bin\bcdboot.exe";
            //bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
            //System.IO.File.Copy(Source, Target, isrewrite);

            foreach (Control item in panel2.Controls)
            {
                item.Tag = "";
            }
            pictureBox17.Tag = "select";

            pictureBox17.BackColor = Color.FromArgb(120, Color.Gray);

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            FormCollection childCollection = Application.OpenForms;
            for (int i = childCollection.Count; i-- > 0;)
            {
                Console.WriteLine(childCollection[i].Name);
                if (childCollection[i].Name != "Form1") childCollection[i].Close();
            }
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
            form2.Parent = this.panel3;
            foreach (Control item in panel2.Controls)
            {
                item.Tag = "";
            }
            pictureBox17.Tag = "select";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            FormCollection childCollection = Application.OpenForms;
            for (int i = childCollection.Count; i-- > 0;)
            {
                if (childCollection[i].Name != "Form1") childCollection[i].Close();
            }
            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.WindowState = FormWindowState.Maximized;
            form3.Show();
            form3.Parent = this.panel3;

            foreach (Control item in panel2.Controls)
            {
                item.Tag = "";
            }
            pictureBox19.Tag = "select";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FormCollection childCollection = Application.OpenForms;
            for (int i = childCollection.Count; i-- > 0;)
            {
                if (childCollection[i].Name != "Form1") childCollection[i].Close();
            }
            Form4 form4 = new Form4();
            form4.TopLevel = false;
            form4.WindowState = FormWindowState.Maximized;
            form4.Show();
            form4.Parent = this.panel3;

            foreach (Control item in panel2.Controls)
            {
                item.Tag = "";
            }
            pictureBox18.Tag = "select";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FormCollection childCollection = Application.OpenForms;
            for (int i = childCollection.Count; i-- > 0;)
            {
                if (childCollection[i].Name != "Form1") childCollection[i].Close();
            }
            Form5 form5 = new Form5();
            form5.TopLevel = false;
            form5.WindowState = FormWindowState.Maximized;
            form5.Show();
            form5.Parent = this.panel3;

            foreach (Control item in panel2.Controls)
            {
                item.Tag = "";
            }
            pictureBox20.Tag = "select";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCollection childCollection = Application.OpenForms;
            for (int i = childCollection.Count; i-- > 0;)
            {
                if (childCollection[i].Name != "Form1") childCollection[i].Close();
            }
            Form6 form6 = new Form6();
            form6.TopLevel = false;
            form6.WindowState = FormWindowState.Maximized;
            form6.Show();
            form6.Parent = this.panel3;
            foreach (Control item in panel2.Controls)
            {
                item.Tag = "";
            }
            pictureBox1.Tag = "select";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                            this.panel2.ClientRectangle,
                            Color.Transparent, //左
                             1,
                            ButtonBorderStyle.Solid,
                            Color.Transparent,//上
                             1,
                            ButtonBorderStyle.Solid,
                            Color.Gray,//右
                             4,
                            ButtonBorderStyle.Solid,
                            Color.Transparent,//下
                             1,
                            ButtonBorderStyle.Solid);
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                            this.panel_top.ClientRectangle,
                            Color.Transparent, //左
                             1,
                            ButtonBorderStyle.Solid,
                            Color.Transparent,//上
                             1,
                            ButtonBorderStyle.Solid,
                            Color.Transparent,//右
                             1,
                            ButtonBorderStyle.Solid,
                            Color.Gray,//下
                             4,
                            ButtonBorderStyle.Solid);

            Graphics g = e.Graphics;
            PointF pointF = new PointF(36, 11);
            g.DrawString(this.Text, this.Font, new SolidBrush(Color.White), pointF);
            g.DrawIcon(this.Icon, new Rectangle(new Point(7, 7), new Size(24, 24)));
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(150, Color.LightGray);
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            foreach (Control item in panel2.Controls)
            {
                //item.Tag = "";
                if (item.Tag.ToString() != "select")
                {
                    item.BackColor = Color.Transparent;
                }
            }
            if ((sender as PictureBox).Tag.ToString() == "select")
            {
                (sender as PictureBox).BackColor = Color.FromArgb(150, Color.Gray);
            }
            else
            {
                (sender as PictureBox).BackColor = Color.Transparent;
            }
        }
        private int selectindex = 0;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


    }
}





//https://blog.csdn.net/charles_ke/article/details/107149759 调用.bat 提示该命令不是内部命令或外部命令

//http://t.zoukankan.com/heiao10duan-p-7574330.html 调用.bat 提示该命令不是内部命令或外部命令

//https://blog.csdn.net/weixin_34258838/article/details/86112795 如何执行bat文件 传参数

//https://blog.csdn.net/weixin_42941237/article/details/82178467 文件复制

//https://blog.csdn.net/weixin_43509549/article/details/111031542 关于c#在64位系统上对System32内文件进行操作及关于复制某文件夹下的所有文件到另一个文件夹下

//https://www.jianshu.com/p/ccb74cefe7d1 更改按钮边框颜色

//https://www.it1352.com/2652478.html 用记事本打开文件

//https://oomake.com/question/4447483 ProcessStartInfo的UseShellExecute和CreateNoWindow有什么区别？

//http://t.zoukankan.com/tangyongle-p-7742668.html C#应用程序隐藏调用bat脚本

//