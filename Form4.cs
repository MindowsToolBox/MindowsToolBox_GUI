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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\open.bat";
            cmdProcess.StartInfo.Arguments = @"txt,config\dev.txt";
            cmdProcess.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad.exe", @"bin\config\fixed.bat");
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\open.bat";
            cmdProcess.StartInfo.Arguments = @"txt,config\fixed.bat";
            cmdProcess.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\open.bat";
            cmdProcess.StartInfo.Arguments = @"txt,config\user.bat";
            cmdProcess.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"bin\backup");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"bin\tools\patchboot");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"CLEAN";
            cmdProcess.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"CHANGESLOT";
            cmdProcess.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"PATCHBOOT";
            cmdProcess.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"RECSDE";
            cmdProcess.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FIXSPLASH";
            cmdProcess.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"SETEFIID";
            cmdProcess.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"SRT";
            cmdProcess.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"FIXFB";
            cmdProcess.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"SINGLEWIN";
            cmdProcess.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"CLOSEAVB";
            cmdProcess.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"MSMDD";
            cmdProcess.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"LGEDLEXTRACTBOOT";
            cmdProcess.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"ENABLELGFB";
            cmdProcess.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"ERASEDTBO";
            cmdProcess.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = @"bin\toolbox.bat";
            cmdProcess.StartInfo.Arguments = @"REGEDIT";
            cmdProcess.Start();
        }
    }
}
