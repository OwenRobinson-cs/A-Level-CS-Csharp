namespace CheckDigitForms
{
    partial class CheckDigit
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
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.LBL_Output = new System.Windows.Forms.Label();
            this.TXT_Input = new System.Windows.Forms.TextBox();
            this.LBL_History = new System.Windows.Forms.Label();
            this.BTN_GenerateCheckDigit = new System.Windows.Forms.Button();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.Location = new System.Drawing.Point(197, 213);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(75, 36);
            this.BTN_Submit.TabIndex = 0;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // LBL_Output
            // 
            this.LBL_Output.AutoSize = true;
            this.LBL_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Output.Location = new System.Drawing.Point(13, 232);
            this.LBL_Output.Name = "LBL_Output";
            this.LBL_Output.Size = new System.Drawing.Size(58, 20);
            this.LBL_Output.TabIndex = 1;
            this.LBL_Output.Text = "Output";
            // 
            // TXT_Input
            // 
            this.TXT_Input.Location = new System.Drawing.Point(115, 145);
            this.TXT_Input.Name = "TXT_Input";
            this.TXT_Input.Size = new System.Drawing.Size(100, 20);
            this.TXT_Input.TabIndex = 2;
            // 
            // LBL_History
            // 
            this.LBL_History.AutoSize = true;
            this.LBL_History.Location = new System.Drawing.Point(13, 13);
            this.LBL_History.Name = "LBL_History";
            this.LBL_History.Size = new System.Drawing.Size(0, 13);
            this.LBL_History.TabIndex = 3;
            // 
            // BTN_GenerateCheckDigit
            // 
            this.BTN_GenerateCheckDigit.Location = new System.Drawing.Point(197, 171);
            this.BTN_GenerateCheckDigit.Name = "BTN_GenerateCheckDigit";
            this.BTN_GenerateCheckDigit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_GenerateCheckDigit.Size = new System.Drawing.Size(75, 36);
            this.BTN_GenerateCheckDigit.TabIndex = 4;
            this.BTN_GenerateCheckDigit.Text = "Generate Check Digit";
            this.BTN_GenerateCheckDigit.UseVisualStyleBackColor = true;
            this.BTN_GenerateCheckDigit.Click += new System.EventHandler(this.BTN_GenerateCheckDigit_Click);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(197, 3);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clear.TabIndex = 5;
            this.BTN_Clear.Text = "Clear History";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // CheckDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.BTN_GenerateCheckDigit);
            this.Controls.Add(this.LBL_History);
            this.Controls.Add(this.TXT_Input);
            this.Controls.Add(this.LBL_Output);
            this.Controls.Add(this.BTN_Submit);
            this.Name = "CheckDigit";
            this.Text = "EAN Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Label LBL_Output;
        private System.Windows.Forms.TextBox TXT_Input;
        private System.Windows.Forms.Label LBL_History;
        private System.Windows.Forms.Button BTN_GenerateCheckDigit;
        private System.Windows.Forms.Button BTN_Clear;
    }
}

