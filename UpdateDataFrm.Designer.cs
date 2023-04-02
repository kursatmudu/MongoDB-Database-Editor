namespace MongoDBDatabaseEdit
{
    partial class UpdateDataFrm
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.passwordTxBox = new System.Windows.Forms.TextBox();
            this.emailTxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CookieTxBox = new System.Windows.Forms.RichTextBox();
            this.completeTrueRBtn = new System.Windows.Forms.RadioButton();
            this.completeFalseRBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(310, 306);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(195, 30);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Düzenle";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_ClickAsync);
            // 
            // passwordTxBox
            // 
            this.passwordTxBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxBox.Location = new System.Drawing.Point(310, 141);
            this.passwordTxBox.Name = "passwordTxBox";
            this.passwordTxBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTxBox.TabIndex = 2;
            this.passwordTxBox.Text = "Password";
            this.passwordTxBox.Enter += new System.EventHandler(this.passwordTxBox_Enter);
            this.passwordTxBox.Leave += new System.EventHandler(this.passwordTxBox_Leave);
            // 
            // emailTxBox
            // 
            this.emailTxBox.ForeColor = System.Drawing.Color.Gray;
            this.emailTxBox.Location = new System.Drawing.Point(310, 105);
            this.emailTxBox.Name = "emailTxBox";
            this.emailTxBox.Size = new System.Drawing.Size(195, 20);
            this.emailTxBox.TabIndex = 3;
            this.emailTxBox.Text = "example@example.com";
            this.emailTxBox.TextChanged += new System.EventHandler(this.emailTxBox_TextChangedAsync);
            this.emailTxBox.Enter += new System.EventHandler(this.emailTxBox_Enter);
            this.emailTxBox.Leave += new System.EventHandler(this.emailTxBox_Leave);
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(307, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bekleniyor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CookieTxBox
            // 
            this.CookieTxBox.ForeColor = System.Drawing.Color.Gray;
            this.CookieTxBox.Location = new System.Drawing.Point(310, 212);
            this.CookieTxBox.Name = "CookieTxBox";
            this.CookieTxBox.Size = new System.Drawing.Size(195, 78);
            this.CookieTxBox.TabIndex = 14;
            this.CookieTxBox.Text = "Cookies (JSON)";
            this.CookieTxBox.Enter += new System.EventHandler(this.CookieTxBox_Enter);
            this.CookieTxBox.Leave += new System.EventHandler(this.CookieTxBox_Leave);
            // 
            // completeTrueRBtn
            // 
            this.completeTrueRBtn.AutoSize = true;
            this.completeTrueRBtn.Location = new System.Drawing.Point(334, 189);
            this.completeTrueRBtn.Name = "completeTrueRBtn";
            this.completeTrueRBtn.Size = new System.Drawing.Size(47, 17);
            this.completeTrueRBtn.TabIndex = 15;
            this.completeTrueRBtn.TabStop = true;
            this.completeTrueRBtn.Text = "True";
            this.completeTrueRBtn.UseVisualStyleBackColor = true;
            this.completeTrueRBtn.CheckedChanged += new System.EventHandler(this.completeTrueRBtn_CheckedChanged);
            // 
            // completeFalseRBtn
            // 
            this.completeFalseRBtn.AutoSize = true;
            this.completeFalseRBtn.Location = new System.Drawing.Point(434, 189);
            this.completeFalseRBtn.Name = "completeFalseRBtn";
            this.completeFalseRBtn.Size = new System.Drawing.Size(50, 17);
            this.completeFalseRBtn.TabIndex = 15;
            this.completeFalseRBtn.TabStop = true;
            this.completeFalseRBtn.Text = "False";
            this.completeFalseRBtn.UseVisualStyleBackColor = true;
            this.completeFalseRBtn.CheckedChanged += new System.EventHandler(this.completeFalseRBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Complete";
            // 
            // UpdateDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.completeFalseRBtn);
            this.Controls.Add(this.completeTrueRBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.passwordTxBox);
            this.Controls.Add(this.emailTxBox);
            this.Controls.Add(this.CookieTxBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDataFrm";
            this.Text = "UpdateDataFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox passwordTxBox;
        private System.Windows.Forms.TextBox emailTxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CookieTxBox;
        private System.Windows.Forms.RadioButton completeTrueRBtn;
        private System.Windows.Forms.RadioButton completeFalseRBtn;
        private System.Windows.Forms.Label label1;
    }
}