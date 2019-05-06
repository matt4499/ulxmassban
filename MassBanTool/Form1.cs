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
            if(checkBox1.Checked == true)
            {
                var lines2 = File.ReadAllLines(path);
                for (var i = 0; i < lines2.Length; i += 1)
                {
                   timerseconds.Text = "starting unbans...";
                   var line2 = lines2[i];
                   SendKeys.Send("ulx unban " + line2);
                   SendKeys.Send("{ENTER}");
                   Thread.Sleep(250);
                }
            }1:123974731 

            if (checkBox1.Checked == false)
            {
                timerseconds.Text = "starting bans...";
                SendKeys.Send("say \"/advert <hsv> Youre about to die at the hands of the mighty Thanos </hsv>\" ");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(250);
                var lines = File.ReadAllLines(path);
                for (var i = 0; i < lines.Length; i += 1)
                {
                    var line = lines[i];
                    if (permchecked.Checked == true)
                    {
                        SendKeys.Send("ulx banid " + line + " 0 \"discord.gg/KJ58UwK (ulxmassban[https://github.com/Matt4499/ulxmassban])\"");
                    }
                    else if (tempchecked.Checked == true)
                    {
                        var timetobanfor = timetext.Text;
                        SendKeys.Send("ulx banid " + line + " " + timetobanfor + " \"discord.gg/KJ58UwK (ulxmassban[https://github.com/Matt4499/ulxmassban])\"");
                    }

                    Thread.Sleep(250);
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(250);
                }
            }
        }
    }
}
