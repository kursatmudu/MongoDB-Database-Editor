namespace MongoDBDatabaseEdit
{
    partial class DelDataFrm
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
            this.DelBtn = new System.Windows.Forms.Button();
            this.emailTxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(195, 173);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(195, 30);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Sil";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_ClickAsync);
            // 
            // emailTxBox
            // 
            this.emailTxBox.ForeColor = System.Drawing.Color.Gray;
            this.emailTxBox.Location = new System.Drawing.Point(195, 135);
            this.emailTxBox.Name = "emailTxBox";
            this.emailTxBox.Size = new System.Drawing.Size(195, 20);
            this.emailTxBox.TabIndex = 3;
            this.emailTxBox.Text = "example@example.com";
            this.emailTxBox.Enter += new System.EventHandler(this.emailTxBox_Enter);
            this.emailTxBox.Leave += new System.EventHandler(this.emailTxBox_Leave);
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(192, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bekleniyor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.emailTxBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DelDataFrm";
            this.Text = "DelDataFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.TextBox emailTxBox;
        private System.Windows.Forms.Label label3;
    }
}