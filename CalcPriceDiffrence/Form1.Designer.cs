namespace CalcPriceDiffrence
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
            this.CalcPrice_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcPrice_btn
            // 
            this.CalcPrice_btn.Location = new System.Drawing.Point(94, 172);
            this.CalcPrice_btn.Name = "CalcPrice_btn";
            this.CalcPrice_btn.Size = new System.Drawing.Size(75, 23);
            this.CalcPrice_btn.TabIndex = 0;
            this.CalcPrice_btn.Text = "btn";
            this.CalcPrice_btn.UseVisualStyleBackColor = true;
            this.CalcPrice_btn.Click += new System.EventHandler(this.CalcPrice_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CalcPrice_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalcPrice_btn;
    }
}

