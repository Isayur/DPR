namespace Abstract_Factory
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.getDocile = new System.Windows.Forms.Button();
            this.getFerocious = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnMakeSounds = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Land animals";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Aquatic animals";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // getDocile
            // 
            this.getDocile.Location = new System.Drawing.Point(6, 19);
            this.getDocile.Name = "getDocile";
            this.getDocile.Size = new System.Drawing.Size(98, 23);
            this.getDocile.TabIndex = 2;
            this.getDocile.Text = "Docile animal";
            this.getDocile.UseVisualStyleBackColor = true;
            this.getDocile.Click += new System.EventHandler(this.getDocile_Click);
            // 
            // getFerocious
            // 
            this.getFerocious.Location = new System.Drawing.Point(6, 48);
            this.getFerocious.Name = "getFerocious";
            this.getFerocious.Size = new System.Drawing.Size(98, 23);
            this.getFerocious.TabIndex = 3;
            this.getFerocious.Text = "Ferocious animal";
            this.getFerocious.UseVisualStyleBackColor = true;
            this.getFerocious.Click += new System.EventHandler(this.getFerocious_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(391, 95);
            this.listBox1.TabIndex = 4;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(0, 19);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(141, 23);
            this.btnIdentify.TabIndex = 8;
            this.btnIdentify.Text = "Identify animal";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnMakeSounds
            // 
            this.btnMakeSounds.Location = new System.Drawing.Point(0, 48);
            this.btnMakeSounds.Name = "btnMakeSounds";
            this.btnMakeSounds.Size = new System.Drawing.Size(141, 23);
            this.btnMakeSounds.TabIndex = 9;
            this.btnMakeSounds.Text = "Produce animal sounds";
            this.btnMakeSounds.UseVisualStyleBackColor = true;
            this.btnMakeSounds.Click += new System.EventHandler(this.btnMakeSounds_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Text log";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select factory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getDocile);
            this.groupBox2.Controls.Add(this.getFerocious);
            this.groupBox2.Location = new System.Drawing.Point(129, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load new animal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIdentify);
            this.groupBox3.Controls.Add(this.btnMakeSounds);
            this.groupBox3.Location = new System.Drawing.Point(253, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animal actions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button getDocile;
        private System.Windows.Forms.Button getFerocious;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnMakeSounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

