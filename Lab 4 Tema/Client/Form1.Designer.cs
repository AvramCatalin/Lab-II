namespace Client
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
            this.listBox_nume = new System.Windows.Forms.ListBox();
            this.richTextBox_details = new System.Windows.Forms.RichTextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_nume
            // 
            this.listBox_nume.FormattingEnabled = true;
            this.listBox_nume.ItemHeight = 16;
            this.listBox_nume.Location = new System.Drawing.Point(13, 13);
            this.listBox_nume.Name = "listBox_nume";
            this.listBox_nume.Size = new System.Drawing.Size(175, 228);
            this.listBox_nume.TabIndex = 0;
            this.listBox_nume.SelectedIndexChanged += new System.EventHandler(this.ListBox_nume_SelectedIndexChanged);
            // 
            // richTextBox_details
            // 
            this.richTextBox_details.Enabled = false;
            this.richTextBox_details.Location = new System.Drawing.Point(194, 88);
            this.richTextBox_details.Name = "richTextBox_details";
            this.richTextBox_details.Size = new System.Drawing.Size(158, 96);
            this.richTextBox_details.TabIndex = 1;
            this.richTextBox_details.Text = "";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Enabled = false;
            this.textBox_weight.Location = new System.Drawing.Point(228, 13);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 22);
            this.textBox_weight.TabIndex = 2;
            // 
            // textBox_price
            // 
            this.textBox_price.Enabled = false;
            this.textBox_price.Location = new System.Drawing.Point(228, 50);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 22);
            this.textBox_price.TabIndex = 3;
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(228, 190);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(100, 51);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "Modifica";
            this.button_modify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.richTextBox_details);
            this.Controls.Add(this.listBox_nume);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 300);
            this.MinimumSize = new System.Drawing.Size(375, 300);
            this.Name = "Form1";
            this.Text = "Avram\'s Pizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_nume;
        private System.Windows.Forms.RichTextBox richTextBox_details;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_modify;
    }
}

