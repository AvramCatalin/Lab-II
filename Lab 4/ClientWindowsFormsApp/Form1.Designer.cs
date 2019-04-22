namespace ClientWindowsFormsApp
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
            this.button_AddList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TempC = new System.Windows.Forms.TextBox();
            this.textBox_TempF = new System.Windows.Forms.TextBox();
            this.textBox_TempRezultat = new System.Windows.Forms.TextBox();
            this.button_FtoC = new System.Windows.Forms.Button();
            this.button_CtoF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ExchangeInput = new System.Windows.Forms.TextBox();
            this.textBox_ExchangeOutput = new System.Windows.Forms.TextBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Exchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 0;
            // 
            // button_AddList
            // 
            this.button_AddList.Location = new System.Drawing.Point(13, 144);
            this.button_AddList.Name = "button_AddList";
            this.button_AddList.Size = new System.Drawing.Size(159, 32);
            this.button_AddList.TabIndex = 1;
            this.button_AddList.Text = "Add List";
            this.button_AddList.UseVisualStyleBackColor = true;
            this.button_AddList.Click += new System.EventHandler(this.Button_AddList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temp C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temp F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rezultat";
            // 
            // textBox_TempC
            // 
            this.textBox_TempC.Location = new System.Drawing.Point(273, 10);
            this.textBox_TempC.Name = "textBox_TempC";
            this.textBox_TempC.Size = new System.Drawing.Size(100, 22);
            this.textBox_TempC.TabIndex = 5;
            // 
            // textBox_TempF
            // 
            this.textBox_TempF.Location = new System.Drawing.Point(273, 59);
            this.textBox_TempF.Name = "textBox_TempF";
            this.textBox_TempF.Size = new System.Drawing.Size(100, 22);
            this.textBox_TempF.TabIndex = 6;
            // 
            // textBox_TempRezultat
            // 
            this.textBox_TempRezultat.Enabled = false;
            this.textBox_TempRezultat.Location = new System.Drawing.Point(273, 107);
            this.textBox_TempRezultat.Name = "textBox_TempRezultat";
            this.textBox_TempRezultat.Size = new System.Drawing.Size(100, 22);
            this.textBox_TempRezultat.TabIndex = 7;
            // 
            // button_FtoC
            // 
            this.button_FtoC.Location = new System.Drawing.Point(293, 144);
            this.button_FtoC.Name = "button_FtoC";
            this.button_FtoC.Size = new System.Drawing.Size(79, 32);
            this.button_FtoC.TabIndex = 8;
            this.button_FtoC.Text = "FtoC";
            this.button_FtoC.UseVisualStyleBackColor = true;
            this.button_FtoC.Click += new System.EventHandler(this.Button_FtoC_Click);
            // 
            // button_CtoF
            // 
            this.button_CtoF.Location = new System.Drawing.Point(191, 144);
            this.button_CtoF.Name = "button_CtoF";
            this.button_CtoF.Size = new System.Drawing.Size(79, 32);
            this.button_CtoF.TabIndex = 9;
            this.button_CtoF.Text = "CtoF";
            this.button_CtoF.UseVisualStyleBackColor = true;
            this.button_CtoF.Click += new System.EventHandler(this.Button_CtoF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(12, 239);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(106, 17);
            this.label_Data.TabIndex = 11;
            this.label_Data.Text = "[Press Refresh]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Euro to Ron";
            // 
            // textBox_ExchangeInput
            // 
            this.textBox_ExchangeInput.Location = new System.Drawing.Point(272, 213);
            this.textBox_ExchangeInput.Name = "textBox_ExchangeInput";
            this.textBox_ExchangeInput.Size = new System.Drawing.Size(100, 22);
            this.textBox_ExchangeInput.TabIndex = 13;
            // 
            // textBox_ExchangeOutput
            // 
            this.textBox_ExchangeOutput.Enabled = false;
            this.textBox_ExchangeOutput.Location = new System.Drawing.Point(272, 241);
            this.textBox_ExchangeOutput.Name = "textBox_ExchangeOutput";
            this.textBox_ExchangeOutput.Size = new System.Drawing.Size(100, 22);
            this.textBox_ExchangeOutput.TabIndex = 14;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(13, 275);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(159, 35);
            this.button_Refresh.TabIndex = 15;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // button_Exchange
            // 
            this.button_Exchange.Location = new System.Drawing.Point(214, 275);
            this.button_Exchange.Name = "button_Exchange";
            this.button_Exchange.Size = new System.Drawing.Size(159, 35);
            this.button_Exchange.TabIndex = 16;
            this.button_Exchange.Text = "Exchange";
            this.button_Exchange.UseVisualStyleBackColor = true;
            this.button_Exchange.Click += new System.EventHandler(this.Button_Exchange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.button_Exchange);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.textBox_ExchangeOutput);
            this.Controls.Add(this.textBox_ExchangeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_CtoF);
            this.Controls.Add(this.button_FtoC);
            this.Controls.Add(this.textBox_TempRezultat);
            this.Controls.Add(this.textBox_TempF);
            this.Controls.Add(this.textBox_TempC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddList);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_AddList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TempC;
        private System.Windows.Forms.TextBox textBox_TempF;
        private System.Windows.Forms.TextBox textBox_TempRezultat;
        private System.Windows.Forms.Button button_FtoC;
        private System.Windows.Forms.Button button_CtoF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ExchangeInput;
        private System.Windows.Forms.TextBox textBox_ExchangeOutput;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Exchange;
    }
}

