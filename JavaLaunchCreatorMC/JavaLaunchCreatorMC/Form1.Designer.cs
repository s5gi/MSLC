namespace JavaLaunchCreatorMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Logo = new System.Windows.Forms.Label();
            this.windowname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.togglegui = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guilabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toggleuela = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(3, 8);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(328, 23);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Minecraft Server Launch Creator";
            // 
            // windowname
            // 
            this.windowname.Location = new System.Drawing.Point(8, 64);
            this.windowname.Name = "windowname";
            this.windowname.Size = new System.Drawing.Size(320, 20);
            this.windowname.TabIndex = 1;
            this.windowname.TextChanged += new System.EventHandler(this.windowname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Window Name (Note: The .sh file doesn\'t support this feature):";
            // 
            // serverFile
            // 
            this.serverFile.Location = new System.Drawing.Point(8, 120);
            this.serverFile.Name = "serverFile";
            this.serverFile.ReadOnly = true;
            this.serverFile.Size = new System.Drawing.Size(296, 20);
            this.serverFile.TabIndex = 3;
            this.serverFile.TextChanged += new System.EventHandler(this.serverFile_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server File:";
            // 
            // togglegui
            // 
            this.togglegui.Location = new System.Drawing.Point(56, 163);
            this.togglegui.Name = "togglegui";
            this.togglegui.Size = new System.Drawing.Size(75, 23);
            this.togglegui.TabIndex = 6;
            this.togglegui.Text = "Toggle GUI";
            this.togglegui.UseVisualStyleBackColor = true;
            this.togglegui.Click += new System.EventHandler(this.togglegui_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Options:";
            // 
            // guilabel
            // 
            this.guilabel.AutoSize = true;
            this.guilabel.Location = new System.Drawing.Point(67, 148);
            this.guilabel.Name = "guilabel";
            this.guilabel.Size = new System.Drawing.Size(54, 13);
            this.guilabel.TabIndex = 8;
            this.guilabel.Text = "GUI: false";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preview:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 176);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(32, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Minecraft Server";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "server.jar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Create Script";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ram Allocated (ex: 2G):";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(88, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Run Script (Batch)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toggleuela
            // 
            this.toggleuela.Location = new System.Drawing.Point(136, 163);
            this.toggleuela.Name = "toggleuela";
            this.toggleuela.Size = new System.Drawing.Size(56, 23);
            this.toggleuela.TabIndex = 18;
            this.toggleuela.Text = "EULA";
            this.toggleuela.UseVisualStyleBackColor = true;
            this.toggleuela.Click += new System.EventHandler(this.toggleuela_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "eula: false";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toggleuela);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guilabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.togglegui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowname);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MSLC by 5gi";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.TextBox windowname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button togglegui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label guilabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button toggleuela;
        private System.Windows.Forms.Label label7;
    }
}

