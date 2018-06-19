namespace ReadWriteFiles
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
            this.tb_file = new System.Windows.Forms.TextBox();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_dir = new System.Windows.Forms.Button();
            this.lbl_file = new System.Windows.Forms.Label();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.tb_counting = new System.Windows.Forms.TextBox();
            this.btn_count = new System.Windows.Forms.Button();
            this.lbl_counting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(45, 53);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(100, 20);
            this.tb_file.TabIndex = 0;
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(45, 79);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(100, 20);
            this.tb_dir.TabIndex = 1;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(180, 49);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(100, 23);
            this.btn_file.TabIndex = 2;
            this.btn_file.Text = "Create File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_dir
            // 
            this.btn_dir.Location = new System.Drawing.Point(180, 79);
            this.btn_dir.Name = "btn_dir";
            this.btn_dir.Size = new System.Drawing.Size(100, 23);
            this.btn_dir.TabIndex = 3;
            this.btn_dir.Text = "Create directory";
            this.btn_dir.UseVisualStyleBackColor = true;
            this.btn_dir.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(328, 58);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(35, 13);
            this.lbl_file.TabIndex = 4;
            this.lbl_file.Text = "label1";
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.Location = new System.Drawing.Point(331, 88);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(35, 13);
            this.lbl_dir.TabIndex = 5;
            this.lbl_dir.Text = "label1";
            // 
            // tb_counting
            // 
            this.tb_counting.Location = new System.Drawing.Point(45, 106);
            this.tb_counting.Name = "tb_counting";
            this.tb_counting.Size = new System.Drawing.Size(100, 20);
            this.tb_counting.TabIndex = 6;
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(180, 109);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(100, 23);
            this.btn_count.TabIndex = 7;
            this.btn_count.Text = "Count in file";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // lbl_counting
            // 
            this.lbl_counting.AutoSize = true;
            this.lbl_counting.Location = new System.Drawing.Point(331, 118);
            this.lbl_counting.Name = "lbl_counting";
            this.lbl_counting.Size = new System.Drawing.Size(33, 13);
            this.lbl_counting.TabIndex = 8;
            this.lbl_counting.Text = "Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 358);
            this.Controls.Add(this.lbl_counting);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.tb_counting);
            this.Controls.Add(this.lbl_dir);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.btn_dir);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.tb_dir);
            this.Controls.Add(this.tb_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_dir;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.TextBox tb_counting;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Label lbl_counting;
    }
}

