namespace Observer
{
    partial class Main
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
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnNewTextObs = new System.Windows.Forms.Button();
            this.btnNewRectangleObs = new System.Windows.Forms.Button();
            this.btnNewCircleObs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(40, 94);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(75, 23);
            this.btnIncrease.TabIndex = 0;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(180, 94);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(75, 23);
            this.btnDecrease.TabIndex = 1;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnNewTextObs
            // 
            this.btnNewTextObs.Location = new System.Drawing.Point(13, 155);
            this.btnNewTextObs.Name = "btnNewTextObs";
            this.btnNewTextObs.Size = new System.Drawing.Size(75, 23);
            this.btnNewTextObs.TabIndex = 2;
            this.btnNewTextObs.Text = "Add text obs";
            this.btnNewTextObs.UseVisualStyleBackColor = true;
            this.btnNewTextObs.Click += new System.EventHandler(this.btnNewTextObs_Click);
            // 
            // btnNewRectangleObs
            // 
            this.btnNewRectangleObs.Location = new System.Drawing.Point(120, 155);
            this.btnNewRectangleObs.Name = "btnNewRectangleObs";
            this.btnNewRectangleObs.Size = new System.Drawing.Size(107, 23);
            this.btnNewRectangleObs.TabIndex = 3;
            this.btnNewRectangleObs.Text = "Add rectangle obs";
            this.btnNewRectangleObs.UseVisualStyleBackColor = true;
            this.btnNewRectangleObs.Click += new System.EventHandler(this.btnNewRectangleObs_Click);
            // 
            // btnNewCircleObs
            // 
            this.btnNewCircleObs.Location = new System.Drawing.Point(250, 155);
            this.btnNewCircleObs.Name = "btnNewCircleObs";
            this.btnNewCircleObs.Size = new System.Drawing.Size(103, 23);
            this.btnNewCircleObs.TabIndex = 4;
            this.btnNewCircleObs.Text = "Add circle obs";
            this.btnNewCircleObs.UseVisualStyleBackColor = true;
            this.btnNewCircleObs.Click += new System.EventHandler(this.btnNewCircleObs_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.btnNewCircleObs);
            this.Controls.Add(this.btnNewRectangleObs);
            this.Controls.Add(this.btnNewTextObs);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Name = "Main";
            this.Text = "Couting Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnNewTextObs;
        private System.Windows.Forms.Button btnNewRectangleObs;
        private System.Windows.Forms.Button btnNewCircleObs;
    }
}

