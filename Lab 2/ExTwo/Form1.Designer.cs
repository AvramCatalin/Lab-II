namespace ExTwo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_sterge = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(240, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 1;
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(139, 13);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(95, 31);
            this.button_copy.TabIndex = 2;
            this.button_copy.Text = "Copiaza";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.Button_copy_Click);
            // 
            // button_sterge
            // 
            this.button_sterge.Location = new System.Drawing.Point(139, 77);
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.Size = new System.Drawing.Size(95, 31);
            this.button_sterge.TabIndex = 3;
            this.button_sterge.Text = "Sterge";
            this.button_sterge.UseVisualStyleBackColor = true;
            this.button_sterge.Click += new System.EventHandler(this.Button_sterge_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(139, 138);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(95, 31);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 183);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_sterge);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_sterge;
        private System.Windows.Forms.Button button_exit;
    }
}

