namespace Coffee
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
            this.selectSimple = new System.Windows.Forms.Button();
            this.coffeeTypeLabel = new System.Windows.Forms.Label();
            this.sweetLabel = new System.Windows.Forms.Label();
            this.otherLabel = new System.Windows.Forms.Label();
            this.selectEspresso = new System.Windows.Forms.Button();
            this.selectMocha = new System.Windows.Forms.Button();
            this.addSugar = new System.Windows.Forms.Button();
            this.addWhip = new System.Windows.Forms.Button();
            this.addChocolate = new System.Windows.Forms.Button();
            this.addIce = new System.Windows.Forms.Button();
            this.addSoy = new System.Windows.Forms.Button();
            this.addMilk = new System.Windows.Forms.Button();
            this.finishCreation = new System.Windows.Forms.Button();
            this.beveragesSoldLb = new System.Windows.Forms.ListBox();
            this.currentCoffeeTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectSimple
            // 
            this.selectSimple.Location = new System.Drawing.Point(86, 32);
            this.selectSimple.Name = "selectSimple";
            this.selectSimple.Size = new System.Drawing.Size(75, 23);
            this.selectSimple.TabIndex = 0;
            this.selectSimple.Text = "Simple";
            this.selectSimple.UseVisualStyleBackColor = true;
            this.selectSimple.Click += new System.EventHandler(this.selectSimple_Click);
            // 
            // coffeeTypeLabel
            // 
            this.coffeeTypeLabel.AutoSize = true;
            this.coffeeTypeLabel.Location = new System.Drawing.Point(103, 5);
            this.coffeeTypeLabel.Name = "coffeeTypeLabel";
            this.coffeeTypeLabel.Size = new System.Drawing.Size(38, 13);
            this.coffeeTypeLabel.TabIndex = 1;
            this.coffeeTypeLabel.Text = "Coffee";
            // 
            // sweetLabel
            // 
            this.sweetLabel.AutoSize = true;
            this.sweetLabel.Location = new System.Drawing.Point(190, 5);
            this.sweetLabel.Name = "sweetLabel";
            this.sweetLabel.Size = new System.Drawing.Size(63, 13);
            this.sweetLabel.TabIndex = 2;
            this.sweetLabel.Text = "Sweeteners";
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Location = new System.Drawing.Point(332, 5);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(33, 13);
            this.otherLabel.TabIndex = 3;
            this.otherLabel.Text = "Other";
            // 
            // selectEspresso
            // 
            this.selectEspresso.Location = new System.Drawing.Point(86, 61);
            this.selectEspresso.Name = "selectEspresso";
            this.selectEspresso.Size = new System.Drawing.Size(75, 23);
            this.selectEspresso.TabIndex = 4;
            this.selectEspresso.Text = "Espresso";
            this.selectEspresso.UseVisualStyleBackColor = true;
            this.selectEspresso.Click += new System.EventHandler(this.selectEspresso_Click);
            // 
            // selectMocha
            // 
            this.selectMocha.Location = new System.Drawing.Point(86, 90);
            this.selectMocha.Name = "selectMocha";
            this.selectMocha.Size = new System.Drawing.Size(75, 23);
            this.selectMocha.TabIndex = 5;
            this.selectMocha.Text = "Mocha";
            this.selectMocha.UseVisualStyleBackColor = true;
            this.selectMocha.Click += new System.EventHandler(this.selectMocha_Click);
            // 
            // addSugar
            // 
            this.addSugar.Location = new System.Drawing.Point(193, 32);
            this.addSugar.Name = "addSugar";
            this.addSugar.Size = new System.Drawing.Size(75, 23);
            this.addSugar.TabIndex = 6;
            this.addSugar.Text = "Sugar";
            this.addSugar.UseVisualStyleBackColor = true;
            this.addSugar.Click += new System.EventHandler(this.addSugar_Click);
            // 
            // addWhip
            // 
            this.addWhip.Location = new System.Drawing.Point(193, 61);
            this.addWhip.Name = "addWhip";
            this.addWhip.Size = new System.Drawing.Size(75, 23);
            this.addWhip.TabIndex = 7;
            this.addWhip.Text = "Whip";
            this.addWhip.UseVisualStyleBackColor = true;
            this.addWhip.Click += new System.EventHandler(this.addWhip_Click);
            // 
            // addChocolate
            // 
            this.addChocolate.Location = new System.Drawing.Point(193, 90);
            this.addChocolate.Name = "addChocolate";
            this.addChocolate.Size = new System.Drawing.Size(75, 23);
            this.addChocolate.TabIndex = 8;
            this.addChocolate.Text = "Chocolate";
            this.addChocolate.UseVisualStyleBackColor = true;
            this.addChocolate.Click += new System.EventHandler(this.addChocolate_Click);
            // 
            // addIce
            // 
            this.addIce.Location = new System.Drawing.Point(314, 32);
            this.addIce.Name = "addIce";
            this.addIce.Size = new System.Drawing.Size(75, 23);
            this.addIce.TabIndex = 9;
            this.addIce.Text = "Ice";
            this.addIce.UseVisualStyleBackColor = true;
            this.addIce.Click += new System.EventHandler(this.addIce_Click);
            // 
            // addSoy
            // 
            this.addSoy.Location = new System.Drawing.Point(314, 61);
            this.addSoy.Name = "addSoy";
            this.addSoy.Size = new System.Drawing.Size(75, 23);
            this.addSoy.TabIndex = 10;
            this.addSoy.Text = "Soy";
            this.addSoy.UseVisualStyleBackColor = true;
            this.addSoy.Click += new System.EventHandler(this.addSoy_Click);
            // 
            // addMilk
            // 
            this.addMilk.Location = new System.Drawing.Point(314, 90);
            this.addMilk.Name = "addMilk";
            this.addMilk.Size = new System.Drawing.Size(75, 23);
            this.addMilk.TabIndex = 11;
            this.addMilk.Text = "Milk";
            this.addMilk.UseVisualStyleBackColor = true;
            this.addMilk.Click += new System.EventHandler(this.addMilk_Click);
            // 
            // finishCreation
            // 
            this.finishCreation.Location = new System.Drawing.Point(163, 146);
            this.finishCreation.Name = "finishCreation";
            this.finishCreation.Size = new System.Drawing.Size(138, 23);
            this.finishCreation.TabIndex = 12;
            this.finishCreation.Text = "Finalize beverage";
            this.finishCreation.UseVisualStyleBackColor = true;
            this.finishCreation.Click += new System.EventHandler(this.finishCreation_Click);
            // 
            // beveragesSoldLb
            // 
            this.beveragesSoldLb.FormattingEnabled = true;
            this.beveragesSoldLb.Location = new System.Drawing.Point(12, 190);
            this.beveragesSoldLb.Name = "beveragesSoldLb";
            this.beveragesSoldLb.Size = new System.Drawing.Size(420, 108);
            this.beveragesSoldLb.TabIndex = 13;
            // 
            // currentCoffeeTb
            // 
            this.currentCoffeeTb.Location = new System.Drawing.Point(86, 120);
            this.currentCoffeeTb.Name = "currentCoffeeTb";
            this.currentCoffeeTb.ReadOnly = true;
            this.currentCoffeeTb.Size = new System.Drawing.Size(303, 20);
            this.currentCoffeeTb.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 310);
            this.Controls.Add(this.currentCoffeeTb);
            this.Controls.Add(this.beveragesSoldLb);
            this.Controls.Add(this.finishCreation);
            this.Controls.Add(this.addMilk);
            this.Controls.Add(this.addSoy);
            this.Controls.Add(this.addIce);
            this.Controls.Add(this.addChocolate);
            this.Controls.Add(this.addWhip);
            this.Controls.Add(this.addSugar);
            this.Controls.Add(this.selectMocha);
            this.Controls.Add(this.selectEspresso);
            this.Controls.Add(this.otherLabel);
            this.Controls.Add(this.sweetLabel);
            this.Controls.Add(this.coffeeTypeLabel);
            this.Controls.Add(this.selectSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectSimple;
        private System.Windows.Forms.Label coffeeTypeLabel;
        private System.Windows.Forms.Label sweetLabel;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.Button selectEspresso;
        private System.Windows.Forms.Button selectMocha;
        private System.Windows.Forms.Button addSugar;
        private System.Windows.Forms.Button addWhip;
        private System.Windows.Forms.Button addChocolate;
        private System.Windows.Forms.Button addIce;
        private System.Windows.Forms.Button addSoy;
        private System.Windows.Forms.Button addMilk;
        private System.Windows.Forms.Button finishCreation;
        private System.Windows.Forms.ListBox beveragesSoldLb;
        private System.Windows.Forms.TextBox currentCoffeeTb;
    }
}

