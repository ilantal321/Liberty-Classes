namespace ilantalpro
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.BtnStudentFrom = new System.Windows.Forms.Button();
            this.LWelcome = new System.Windows.Forms.Label();
            this.BtnBookForm = new System.Windows.Forms.Button();
            this.BtnOrderForm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStudentFrom
            // 
            this.BtnStudentFrom.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnStudentFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentFrom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnStudentFrom.Location = new System.Drawing.Point(338, 444);
            this.BtnStudentFrom.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStudentFrom.Name = "BtnStudentFrom";
            this.BtnStudentFrom.Size = new System.Drawing.Size(200, 100);
            this.BtnStudentFrom.TabIndex = 0;
            this.BtnStudentFrom.Text = "Students";
            this.BtnStudentFrom.UseVisualStyleBackColor = false;
            this.BtnStudentFrom.Click += new System.EventHandler(this.button1_Click);
            // 
            // LWelcome
            // 
            this.LWelcome.AutoSize = true;
            this.LWelcome.BackColor = System.Drawing.SystemColors.Menu;
            this.LWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LWelcome.Location = new System.Drawing.Point(12, 9);
            this.LWelcome.Name = "LWelcome";
            this.LWelcome.Size = new System.Drawing.Size(589, 55);
            this.LWelcome.TabIndex = 1;
            this.LWelcome.Text = "Welcome to Ilan Tal library";
            // 
            // BtnBookForm
            // 
            this.BtnBookForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBookForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBookForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnBookForm.Location = new System.Drawing.Point(604, 444);
            this.BtnBookForm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBookForm.Name = "BtnBookForm";
            this.BtnBookForm.Size = new System.Drawing.Size(200, 100);
            this.BtnBookForm.TabIndex = 2;
            this.BtnBookForm.Text = "Books";
            this.BtnBookForm.UseVisualStyleBackColor = false;
            this.BtnBookForm.Click += new System.EventHandler(this.BtnBookForm_Click);
            // 
            // BtnOrderForm
            // 
            this.BtnOrderForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnOrderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrderForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnOrderForm.Location = new System.Drawing.Point(873, 444);
            this.BtnOrderForm.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOrderForm.Name = "BtnOrderForm";
            this.BtnOrderForm.Size = new System.Drawing.Size(200, 100);
            this.BtnOrderForm.TabIndex = 3;
            this.BtnOrderForm.Text = "Orders";
            this.BtnOrderForm.UseVisualStyleBackColor = false;
            this.BtnOrderForm.Click += new System.EventHandler(this.BtnOrderForm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Location = new System.Drawing.Point(12, 469);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(65, 65);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnOrderForm);
            this.Controls.Add(this.BtnBookForm);
            this.Controls.Add(this.LWelcome);
            this.Controls.Add(this.BtnStudentFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "ilan tal library";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStudentFrom;
        private System.Windows.Forms.Label LWelcome;
        private System.Windows.Forms.Button BtnBookForm;
        private System.Windows.Forms.Button BtnOrderForm;
        private System.Windows.Forms.Button BtnExit;
    }
}

