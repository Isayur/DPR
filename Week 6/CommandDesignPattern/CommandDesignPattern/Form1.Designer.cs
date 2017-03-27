namespace CommandDesignPattern
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
            this.addTVBtn = new System.Windows.Forms.Button();
            this.addRadioBtn = new System.Windows.Forms.Button();
            this.VolumeUpBtn = new System.Windows.Forms.Button();
            this.VolumeDownBtn = new System.Windows.Forms.Button();
            this.TurnOnBtn = new System.Windows.Forms.Button();
            this.TurnOffBtn = new System.Windows.Forms.Button();
            this.TurnAllOffBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTVBtn
            // 
            this.addTVBtn.Location = new System.Drawing.Point(15, 19);
            this.addTVBtn.Name = "addTVBtn";
            this.addTVBtn.Size = new System.Drawing.Size(86, 23);
            this.addTVBtn.TabIndex = 1;
            this.addTVBtn.Text = "Add TV";
            this.addTVBtn.UseVisualStyleBackColor = true;
            this.addTVBtn.Click += new System.EventHandler(this.addTVBtn_Click);
            // 
            // addRadioBtn
            // 
            this.addRadioBtn.Location = new System.Drawing.Point(15, 48);
            this.addRadioBtn.Name = "addRadioBtn";
            this.addRadioBtn.Size = new System.Drawing.Size(86, 23);
            this.addRadioBtn.TabIndex = 3;
            this.addRadioBtn.Text = "Add radio";
            this.addRadioBtn.UseVisualStyleBackColor = true;
            this.addRadioBtn.Click += new System.EventHandler(this.addRadioBtn_Click);
            // 
            // VolumeUpBtn
            // 
            this.VolumeUpBtn.Location = new System.Drawing.Point(15, 77);
            this.VolumeUpBtn.Name = "VolumeUpBtn";
            this.VolumeUpBtn.Size = new System.Drawing.Size(86, 23);
            this.VolumeUpBtn.TabIndex = 4;
            this.VolumeUpBtn.Text = "Volume up";
            this.VolumeUpBtn.UseVisualStyleBackColor = true;
            this.VolumeUpBtn.Click += new System.EventHandler(this.VolumeUpBtn_Click);
            // 
            // VolumeDownBtn
            // 
            this.VolumeDownBtn.Location = new System.Drawing.Point(15, 101);
            this.VolumeDownBtn.Name = "VolumeDownBtn";
            this.VolumeDownBtn.Size = new System.Drawing.Size(86, 23);
            this.VolumeDownBtn.TabIndex = 5;
            this.VolumeDownBtn.Text = "Volume down";
            this.VolumeDownBtn.UseVisualStyleBackColor = true;
            this.VolumeDownBtn.Click += new System.EventHandler(this.VolumeDownBtn_Click);
            // 
            // TurnOnBtn
            // 
            this.TurnOnBtn.Location = new System.Drawing.Point(15, 19);
            this.TurnOnBtn.Name = "TurnOnBtn";
            this.TurnOnBtn.Size = new System.Drawing.Size(86, 23);
            this.TurnOnBtn.TabIndex = 6;
            this.TurnOnBtn.Text = "Turn on";
            this.TurnOnBtn.UseVisualStyleBackColor = true;
            this.TurnOnBtn.Click += new System.EventHandler(this.TurnOnBtn_Click);
            // 
            // TurnOffBtn
            // 
            this.TurnOffBtn.Location = new System.Drawing.Point(15, 48);
            this.TurnOffBtn.Name = "TurnOffBtn";
            this.TurnOffBtn.Size = new System.Drawing.Size(86, 23);
            this.TurnOffBtn.TabIndex = 7;
            this.TurnOffBtn.Text = "Turn off";
            this.TurnOffBtn.UseVisualStyleBackColor = true;
            this.TurnOffBtn.Click += new System.EventHandler(this.TurnOffBtn_Click);
            // 
            // TurnAllOffBtn
            // 
            this.TurnAllOffBtn.Location = new System.Drawing.Point(21, 208);
            this.TurnAllOffBtn.Name = "TurnAllOffBtn";
            this.TurnAllOffBtn.Size = new System.Drawing.Size(107, 23);
            this.TurnAllOffBtn.TabIndex = 8;
            this.TurnAllOffBtn.Text = "Turn all devices off";
            this.TurnAllOffBtn.UseVisualStyleBackColor = true;
            this.TurnAllOffBtn.Click += new System.EventHandler(this.TurnAllOffBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTVBtn);
            this.groupBox1.Controls.Add(this.addRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add devices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TurnOnBtn);
            this.groupBox2.Controls.Add(this.TurnOffBtn);
            this.groupBox2.Controls.Add(this.VolumeUpBtn);
            this.groupBox2.Controls.Add(this.VolumeDownBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.TurnAllOffBtn);
            this.groupBox3.Location = new System.Drawing.Point(153, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 237);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device list";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 173);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTVBtn;
        private System.Windows.Forms.Button addRadioBtn;
        private System.Windows.Forms.Button VolumeUpBtn;
        private System.Windows.Forms.Button VolumeDownBtn;
        private System.Windows.Forms.Button TurnOnBtn;
        private System.Windows.Forms.Button TurnOffBtn;
        private System.Windows.Forms.Button TurnAllOffBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

