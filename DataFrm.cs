using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MongoDBDatabaseEdit
{
    public partial class DataFrm : Form
    {
        private MongoHelper _mongoHelper = new MongoHelper();
        private string columnName = Properties.Settings.Default.COLUMN_NAME;
        public DataFrm()
        {
            InitializeComponent();
        }
        private async void DataFrm_Load(object sender, EventArgs e)
        {
            List<MongoEncapsulation> User = await GetAsync();
            foreach (MongoEncapsulation item in User)
            {
                dataGridView1.Rows.Add(item.email, item.password, item.Cookies.AsQueryable(), item.complete);
            }
        }
        public async Task<List<MongoEncapsulation>> GetAsync()
        {
            return await _mongoHelper.GetAllDocumentsAsync<MongoEncapsulation>(columnName);
        }

        private async void emailTxBox_TextChanged(object sender, EventArgs e)
        {
            FilterDefinition<MongoEncapsulation> filter = Builders<MongoEncapsulation>.Filter.Eq("email", emailTxBox.Text);
            List<MongoEncapsulation> findUser = await _mongoHelper.GetFilteredDocuments(columnName, filter);
            if (findUser.Count > 0 && dataGridView1.Rows.Count > 0)dataGridView1.Rows.Clear();
            foreach (MongoEncapsulation user in findUser)
            {
                dataGridView1.Rows.Add(user.email, user.password, user.Cookies.AsQueryable(), user.complete);
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
