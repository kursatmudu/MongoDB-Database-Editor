using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBDatabaseEdit
{
    public partial class DelDataFrm : Form
    {
        private string columnName = Properties.Settings.Default.COLUMN_NAME;
        public DelDataFrm()
        {
            InitializeComponent();
        }
        private MongoHelper _mongoHelper = new MongoHelper();
        private async void DelBtn_ClickAsync(object sender, EventArgs e)
        {
            if (emailTxBox.Text == "example@example.com")
                label3.Text = "Lütfen mail adresi girin";
            else
            {
                label3.Text = "Bekleniyor.";
                label3.Enabled = false;
                MongoEncapsulation mongoEncapsulation = new MongoEncapsulation();
                await _mongoHelper.DeleteDocument(columnName, Builders<MongoEncapsulation>.Filter.Eq("email", emailTxBox.Text));
                label3.Enabled = true;
                label3.Text = "Başarılı.";
            }
        }
        private void emailTxBox_Enter(object sender, EventArgs e)
        {
            if (emailTxBox.Text == "example@example.com")
            {
                emailTxBox.ForeColor = Color.Black;
                emailTxBox.Text = "";
            }
        }
        private void emailTxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTxBox.Text))
            {
                emailTxBox.ForeColor = Color.Gray;
                emailTxBox.Text = "example@example.com";
            }
        }
    }
}
