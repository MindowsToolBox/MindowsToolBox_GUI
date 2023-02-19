using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindowsToolBox
{
    public partial class Form2 : Form
    {
        //public static string Form2Load;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form2Load = "y";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mindows.cn/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"Mindows一键安装.bat";
            cmdProcess.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string FolderPath = @"bin\backup";
            System.Diagnostics.Process.Start("explorer.exe", FolderPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"命令行.bat";
            cmdProcess.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\update.bat";
            cmdProcess.Start();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", @"devmgr.dll DeviceManager_Execute");
            //https://blog.csdn.net/anlog/article/details/125818924
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kamiui.imflash.com.cn/d/35-mindowsgong-ju-xiang-chang-jian-wen-ti-shuo-ming");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"ADDRESOURCES";
            cmdProcess.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\chk.bat";
            cmdProcess.StartInfo.Arguments = @"PRE";
            cmdProcess.Start();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FIXUSB";
            cmdProcess.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"ENTERMSM";
            cmdProcess.Start();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"EFIFIX";
            cmdProcess.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"PTR";
            cmdProcess.Start();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FBFMIUI";
            cmdProcess.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"Mindows一键安装.bat";
            cmdProcess.StartInfo.Arguments = @"WIN";
            cmdProcess.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"BAKWIN";
            cmdProcess.Start();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"DRV";
            cmdProcess.Start();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"CLOSEDSV";
            cmdProcess.Start();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"ISO2WIM";
            cmdProcess.Start();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"UNLOCKBL";
            cmdProcess.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"EDLFLASH";
            cmdProcess.Start();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"BB";
            cmdProcess.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\open.bat";
            cmdProcess.StartInfo.Arguments = @"pic,pictures\sharedspace_mount.jpg";
            cmdProcess.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kdocs.cn/l/cjI6xbkJFxs2?f=201");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FLASHIMG";
            cmdProcess.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kdocs.cn/l/cjA1IGSg2zAl?f=201");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FLASHMAGISK";
            cmdProcess.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"SIGNEFI";
            cmdProcess.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"TRANSFERFILE";
            cmdProcess.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FORMATWINPAR";
            cmdProcess.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FORMATDATA";
            cmdProcess.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"OPENDIAG";
            cmdProcess.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"OPENEDL";
            cmdProcess.Start();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"SKIPOOBE";
            cmdProcess.Start();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"WOATOOLS";
            cmdProcess.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.123pan.com/s/8eP9-FCTGA");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"EASYEXITMSM";
            cmdProcess.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\open.bat";
            cmdProcess.StartInfo.Arguments = @"pic,pictures\MindowsAPP.jpg";
            cmdProcess.Start();
        }
    }
}
