using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MassBanTool
{
    public partial class Form1 : Form
    {
        public static string path;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
             path = file.FileName;
             label1.Text = path;      
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timerseconds.Text = "Timer Expired.";
            SendKeys.Send("say \"/advert <hsv> Youre about to die at the hands of the mighty Thanos </hsv>\" ");
            SendKeys.Send("{ENTER}");
            Thread.Sleep(500);
            var lines = File.ReadAllLines(path);
            for (var i = 0; i < lines.Length; i += 1)
            {
                var line = lines[i];
                SendKeys.Send("ulx banid " + line + " 4499 \"Thanos snapped his fingers.\"");
                Thread.Sleep(500);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }
        }
    }
}
