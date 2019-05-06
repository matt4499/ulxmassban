namespace MassBanTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timerseconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.permchecked = new System.Windows.Forms.RadioButton();
            this.tempchecked = new System.Windows.Forms.RadioButton();
            this.timetext = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pick File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No File Selected";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Timer: ";
            // 
            // timerseconds
            // 
            this.timerseconds.AutoSize = true;
            this.timerseconds.Location = new System.Drawing.Point(375, 23);
            this.timerseconds.Name = "timerseconds";
            this.timerseconds.Size = new System.Drawing.Size(0, 13);
            this.timerseconds.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // permchecked
            // 
            this.permchecked.AutoSize = true;
            this.permchecked.Checked = true;
            this.permchecked.Location = new System.Drawing.Point(100, 147);
            this.permchecked.Name = "permchecked";
            this.permchecked.Size = new System.Drawing.Size(86, 17);
            this.permchecked.TabIndex = 10;
            this.permchecked.TabStop = true;
            this.permchecked.Text = "Perm (time 0)";
            this.permchecked.UseVisualStyleBackColor = true;
            // 
            // tempchecked
            // 
            this.tempchecked.AutoSize = true;
            this.tempchecked.Location = new System.Drawing.Point(233, 147);
            this.tempchecked.Name = "tempchecked";
            this.tempchecked.Size = new System.Drawing.Size(78, 17);
            this.tempchecked.TabIndex = 11;
            this.tempchecked.Text = "Temp Time";
            this.tempchecked.UseVisualStyleBackColor = true;
            // 
            // timetext
            // 
            this.timetext.Location = new System.Drawing.Point(333, 146);
            this.timetext.Name = "timetext";
            this.timetext.Size = new System.Drawing.Size(100, 20);
            this.timetext.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Unban Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 210);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.timetext);
            this.Controls.Add(this.tempchecked);
            this.Controls.Add(this.permchecked);
            this.Controls.Add(this.timerseconds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ULX MASS BAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timerseconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton permchecked;
        private System.Windows.Forms.RadioButton tempchecked;
        private System.Windows.Forms.TextBox timetext;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

