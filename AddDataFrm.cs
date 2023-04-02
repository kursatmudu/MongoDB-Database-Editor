using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MongoDBDatabaseEdit
{
    public partial class AddDataFrm : Form
    {
        private MongoHelper _mongoHelper = new MongoHelper();
        private string columnName = Properties.Settings.Default.COLUMN_NAME;
        public AddDataFrm()
        {
            InitializeComponent();
        }

        private void AddDataFrm_Load(object sender, EventArgs e)
        {
            statusFalseRBtn.Checked = true;
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
        private void passwordTxBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxBox.Text == "Password")
            {
                passwordTxBox.ForeColor = Color.Black;
                passwordTxBox.Text = "";
            }
        }
        private void passwordTxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTxBox.Text))
            {
                passwordTxBox.ForeColor = Color.Gray;
                passwordTxBox.Text = "Password";
            }
        }
        bool complete = false;
        private async void AddBtn_Click(object sender, EventArgs e)
        {
            label3.Enabled = false;
            label3.Text = "Bekleniyor";
            JObject cookieData = new JObject();
            List<string> requirements = new List<string>() { "_timezone", "logged_out_locale", "bsid", "vendor_user_tracker", "sweeper_session", "_xsrf" };
            MongoEncapsulation mongoEncapsulation = new MongoEncapsulation();
            if (emailTxBox.Text == "example@example.com")
            {
                MessageBox.Show("Email metni boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordTxBox.Text == "Password")
            {
                MessageBox.Show("Password metni boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CookieTxBox.Text == "Cookies (JSON)")
            {
                MessageBox.Show("Cookies metni boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mongoEncapsulation.email = emailTxBox.Text;
                mongoEncapsulation.password = passwordTxBox.Text;
                try
                {
                    JArray cookieJson = (JArray)JsonConvert.DeserializeObject(CookieTxBox.Text);
                    foreach (JObject token in cookieJson)
                    {
                        foreach (var requirement in requirements)
                        {
                            if ((string)token["name"] == requirement)
                            {
                                cookieData.Add((string)token["name"], (string)token["value"]);
                            }
                        }
                    }
                    mongoEncapsulation.Cookies = BsonDocument.Parse(JsonConvert.SerializeObject(cookieData));
                }
                catch (JsonReaderException)
                {
                    MessageBox.Show("Cookies geçerli bir json metni değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mongoEncapsulation.complete = complete;
                await _mongoHelper.CreateDocument(columnName, mongoEncapsulation);
                label3.Enabled = true;
                label3.Text = "İşlem başarılı";
            }
        }

        private void statusTrueRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (statusTrueRBtn.Checked)
            {
                statusFalseRBtn.Checked = false;
                complete = true;
            }
        }

        private void statusFalseRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (statusFalseRBtn.Checked)
            {
                statusTrueRBtn.Checked = false;
                complete = false;
            }
        }

        private void CookieTxBox_Enter(object sender, EventArgs e)
        {
            if (CookieTxBox.Text == "Cookies (JSON)")
            {
                CookieTxBox.ForeColor = Color.Black;
                CookieTxBox.Text = "";
            }
        }

        private void CookieTxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CookieTxBox.Text))
            {
                CookieTxBox.ForeColor = Color.Gray;
                CookieTxBox.Text = "Cookies (JSON)";
            }
        }
    }
}
