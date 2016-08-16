namespace AsyncDemo
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.primesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(25, 34);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(95, 20);
            this.num1.TabIndex = 0;
            this.num1.Text = "Lower limit";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(157, 34);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 1;
            this.num2.Text = "Upper limit";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(302, 34);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(123, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "calculate primes";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // primesList
            // 
            this.primesList.FormattingEnabled = true;
            this.primesList.Location = new System.Drawing.Point(108, 84);
            this.primesList.Name = "primesList";
            this.primesList.Size = new System.Drawing.Size(177, 134);
            this.primesList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.primesList);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox primesList;
    }
}

