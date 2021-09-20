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

namespace _14KlasaProces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InternetExplorerStartButton_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void ExcelStartButton_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void WordStartButton_Click(object sender, EventArgs e)
        {
            Process.Start("wimword.exe");
        }

        private void startInfoStartButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";

            Process.Start(startInfo);
        }
    }
}
