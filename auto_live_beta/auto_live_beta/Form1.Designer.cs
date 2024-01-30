namespace auto_live_beta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.Start_End = new System.Windows.Forms.Timer(this.components);
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.open_sce_chrome = new System.Windows.Forms.Button();
            this.open_namiko_chrome = new System.Windows.Forms.Button();
            this.open_cocogu_chrome = new System.Windows.Forms.Button();
            this.open_fennix_chrome = new System.Windows.Forms.Button();
            this.Count_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Time_set = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Live_name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(91, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 49);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(91, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 35);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "SCE";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(91, 185);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 35);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Namiko";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(91, 226);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(127, 35);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Cocogu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(91, 267);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(114, 35);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Fennix";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Start_End
            // 
            this.Start_End.Interval = 1000;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(111, 324);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(177, 35);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "TEST_LIVE";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(354, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(354, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // open_sce_chrome
            // 
            this.open_sce_chrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_sce_chrome.Location = new System.Drawing.Point(245, 144);
            this.open_sce_chrome.Name = "open_sce_chrome";
            this.open_sce_chrome.Size = new System.Drawing.Size(88, 35);
            this.open_sce_chrome.TabIndex = 10;
            this.open_sce_chrome.Text = "Open";
            this.open_sce_chrome.UseVisualStyleBackColor = true;
            this.open_sce_chrome.Click += new System.EventHandler(this.open_sce_chrome_Click);
            // 
            // open_namiko_chrome
            // 
            this.open_namiko_chrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_namiko_chrome.Location = new System.Drawing.Point(245, 185);
            this.open_namiko_chrome.Name = "open_namiko_chrome";
            this.open_namiko_chrome.Size = new System.Drawing.Size(88, 35);
            this.open_namiko_chrome.TabIndex = 11;
            this.open_namiko_chrome.Text = "Open";
            this.open_namiko_chrome.UseVisualStyleBackColor = true;
            this.open_namiko_chrome.Click += new System.EventHandler(this.open_namiko_chrome_Click);
            // 
            // open_cocogu_chrome
            // 
            this.open_cocogu_chrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_cocogu_chrome.Location = new System.Drawing.Point(245, 226);
            this.open_cocogu_chrome.Name = "open_cocogu_chrome";
            this.open_cocogu_chrome.Size = new System.Drawing.Size(88, 35);
            this.open_cocogu_chrome.TabIndex = 12;
            this.open_cocogu_chrome.Text = "Open";
            this.open_cocogu_chrome.UseVisualStyleBackColor = true;
            this.open_cocogu_chrome.Click += new System.EventHandler(this.open_cocogu_chrome_Click);
            // 
            // open_fennix_chrome
            // 
            this.open_fennix_chrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_fennix_chrome.Location = new System.Drawing.Point(245, 267);
            this.open_fennix_chrome.Name = "open_fennix_chrome";
            this.open_fennix_chrome.Size = new System.Drawing.Size(88, 35);
            this.open_fennix_chrome.TabIndex = 13;
            this.open_fennix_chrome.Text = "Open";
            this.open_fennix_chrome.UseVisualStyleBackColor = true;
            this.open_fennix_chrome.Click += new System.EventHandler(this.open_fennix_chrome_Click);
            // 
            // Count_box
            // 
            this.Count_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Count_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_box.Location = new System.Drawing.Point(69, 406);
            this.Count_box.Multiline = true;
            this.Count_box.Name = "Count_box";
            this.Count_box.Size = new System.Drawing.Size(49, 52);
            this.Count_box.TabIndex = 14;
            this.Count_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Round";
            // 
            // timer_box
            // 
            this.timer_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_box.Location = new System.Drawing.Point(296, 379);
            this.timer_box.Name = "timer_box";
            this.timer_box.Size = new System.Drawing.Size(155, 47);
            this.timer_box.TabIndex = 16;
            this.timer_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timer_box.TextChanged += new System.EventHandler(this.timer_box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Timer";
            // 
            // Time_set
            // 
            this.Time_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_set.Location = new System.Drawing.Point(296, 469);
            this.Time_set.Name = "Time_set";
            this.Time_set.Size = new System.Drawing.Size(155, 47);
            this.Time_set.TabIndex = 18;
            this.Time_set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "End SET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time_set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timer_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Count_box);
            this.Controls.Add(this.open_fennix_chrome);
            this.Controls.Add(this.open_cocogu_chrome);
            this.Controls.Add(this.open_namiko_chrome);
            this.Controls.Add(this.open_sce_chrome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Timer Start_End;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button open_sce_chrome;
        private System.Windows.Forms.Button open_namiko_chrome;
        private System.Windows.Forms.Button open_cocogu_chrome;
        private System.Windows.Forms.Button open_fennix_chrome;
        private System.Windows.Forms.TextBox Count_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timer_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Time_set;
        private System.Windows.Forms.Label label4;
    }
}

