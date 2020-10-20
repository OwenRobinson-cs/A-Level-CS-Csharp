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
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.Location = new System.Drawing.Point(197, 226);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Submit.TabIndex = 0;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // LBL_Output
            // 
            this.LBL_Output.AutoSize = true;
            this.LBL_Output.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Output.Location = new System.Drawing.Point(13, 232);
            this.LBL_Output.Name = "LBL_Output";
            this.LBL_Output.Size = new System.Drawing.Size(68, 17);
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
            // CheckDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

