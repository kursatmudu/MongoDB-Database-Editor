namespace MongoDBDatabaseEdit
{
    partial class AddDataFrm
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
            this.emailTxBox = new System.Windows.Forms.TextBox();
            this.passwordTxBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.statusTrueRBtn = new System.Windows.Forms.RadioButton();
            this.statusFalseRBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CookieTxBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTxBox
            // 
            this.emailTxBox.ForeColor = System.Drawing.Color.Gray;
            this.emailTxBox.Location = new System.Drawing.Point(195, 135);
            this.emailTxBox.Name = "emailTxBox";
            this.emailTxBox.Size = new System.Drawing.Size(195, 20);
            this.emailTxBox.TabIndex = 0;
            this.emailTxBox.Text = "example@example.com";
            this.emailTxBox.Enter += new System.EventHandler(this.emailTxBox_Enter);
            this.emailTxBox.Leave += new System.EventHandler(this.emailTxBox_Leave);
            // 
            // passwordTxBox
            // 
            this.passwordTxBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxBox.Location = new System.Drawing.Point(195, 173);
            this.passwordTxBox.Name = "passwordTxBox";
            this.passwordTxBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTxBox.TabIndex = 0;
            this.passwordTxBox.Text = "Password";
            this.passwordTxBox.Enter += new System.EventHandler(this.passwordTxBox_Enter);
            this.passwordTxBox.Leave += new System.EventHandler(this.passwordTxBox_Leave);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(195, 310);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(195, 30);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Ekle";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // statusTrueRBtn
            // 
            this.statusTrueRBtn.AutoSize = true;
            this.statusTrueRBtn.Location = new System.Drawing.Point(233, 216);
            this.statusTrueRBtn.Name = "statusTrueRBtn";
            this.statusTrueRBtn.Size = new System.Drawing.Size(47, 17);
            this.statusTrueRBtn.TabIndex = 8;
            this.statusTrueRBtn.TabStop = true;
            this.statusTrueRBtn.Text = "True";
            this.statusTrueRBtn.UseVisualStyleBackColor = true;
            this.statusTrueRBtn.CheckedChanged += new System.EventHandler(this.statusTrueRBtn_CheckedChanged);
            // 
            // statusFalseRBtn
            // 
            this.statusFalseRBtn.AutoSize = true;
            this.statusFalseRBtn.Location = new System.Drawing.Point(308, 216);
            this.statusFalseRBtn.Name = "statusFalseRBtn";
            this.statusFalseRBtn.Size = new System.Drawing.Size(50, 17);
            this.statusFalseRBtn.TabIndex = 8;
            this.statusFalseRBtn.TabStop = true;
            this.statusFalseRBtn.Text = "False";
            this.statusFalseRBtn.UseVisualStyleBackColor = true;
            this.statusFalseRBtn.CheckedChanged += new System.EventHandler(this.statusFalseRBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(195, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Complete Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CookieTxBox
            // 
            this.CookieTxBox.ForeColor = System.Drawing.Color.Gray;
            this.CookieTxBox.Location = new System.Drawing.Point(195, 242);
            this.CookieTxBox.Name = "CookieTxBox";
            this.CookieTxBox.Size = new System.Drawing.Size(195, 62);
            this.CookieTxBox.TabIndex = 10;
            this.CookieTxBox.Text = "Cookies (JSON)";
            this.CookieTxBox.Enter += new System.EventHandler(this.CookieTxBox_Enter);
            this.CookieTxBox.Leave += new System.EventHandler(this.CookieTxBox_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(82, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 93);
            this.label2.TabIndex = 11;
            this.label2.Text = "KULLANICI EKLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(192, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bekleniyor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusFalseRBtn);
            this.Controls.Add(this.statusTrueRBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.passwordTxBox);
            this.Controls.Add(this.emailTxBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CookieTxBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDataFrm";
            this.Text = "AddDataFrm";
            this.Load += new System.EventHandler(this.AddDataFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxBox;
        private System.Windows.Forms.TextBox passwordTxBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.RadioButton statusTrueRBtn;
        private System.Windows.Forms.RadioButton statusFalseRBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CookieTxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}