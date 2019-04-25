namespace ExThree
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.additionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FirstNumber = new System.Windows.Forms.TextBox();
            this.textBox_SecondNumber = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // additionToolStripMenuItem
            // 
            this.additionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionToolStripMenuItem1,
            this.subtractionToolStripMenuItem1,
            this.multiplicationToolStripMenuItem1,
            this.divisionToolStripMenuItem1});
            this.additionToolStripMenuItem.Name = "additionToolStripMenuItem";
            this.additionToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.additionToolStripMenuItem.Text = "Math Operations";
            // 
            // additionToolStripMenuItem1
            // 
            this.additionToolStripMenuItem1.Name = "additionToolStripMenuItem1";
            this.additionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.additionToolStripMenuItem1.Text = "Addition ( + )";
            this.additionToolStripMenuItem1.Click += new System.EventHandler(this.AdditionToolStripMenuItem1_Click);
            // 
            // subtractionToolStripMenuItem1
            // 
            this.subtractionToolStripMenuItem1.Name = "subtractionToolStripMenuItem1";
            this.subtractionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.subtractionToolStripMenuItem1.Text = "Subtraction ( - )";
            this.subtractionToolStripMenuItem1.Click += new System.EventHandler(this.SubtractionToolStripMenuItem1_Click);
            // 
            // multiplicationToolStripMenuItem1
            // 
            this.multiplicationToolStripMenuItem1.Name = "multiplicationToolStripMenuItem1";
            this.multiplicationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.multiplicationToolStripMenuItem1.Text = "Multiplication ( x )";
            this.multiplicationToolStripMenuItem1.Click += new System.EventHandler(this.MultiplicationToolStripMenuItem1_Click);
            // 
            // divisionToolStripMenuItem1
            // 
            this.divisionToolStripMenuItem1.Name = "divisionToolStripMenuItem1";
            this.divisionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.divisionToolStripMenuItem1.Text = "Division ( / )";
            this.divisionToolStripMenuItem1.Click += new System.EventHandler(this.DivisionToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // textBox_FirstNumber
            // 
            this.textBox_FirstNumber.Location = new System.Drawing.Point(112, 51);
            this.textBox_FirstNumber.Name = "textBox_FirstNumber";
            this.textBox_FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstNumber.TabIndex = 4;
            // 
            // textBox_SecondNumber
            // 
            this.textBox_SecondNumber.Location = new System.Drawing.Point(112, 77);
            this.textBox_SecondNumber.Name = "textBox_SecondNumber";
            this.textBox_SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_SecondNumber.TabIndex = 5;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Enabled = false;
            this.textBox_Result.Location = new System.Drawing.Point(112, 103);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(100, 20);
            this.textBox_Result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 144);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_SecondNumber);
            this.Controls.Add(this.textBox_FirstNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem additionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FirstNumber;
        private System.Windows.Forms.TextBox textBox_SecondNumber;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

