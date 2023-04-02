using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace MongoDBDatabaseEdit
{
    public partial class UpdateDataFrm : Form
    {
        private MongoHelper _mongoHelper = new MongoHelper();
        private string columnName = Properties.Settings.Default.COLUMN_NAME;
        public UpdateDataFrm()
        {
            InitializeComponent();
        }
        bool complete = false;
        private async void UpdateBtn_ClickAsync(object sender, EventArgs e)
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
                    var cookieJson = JsonConvert.DeserializeObject(CookieTxBox.Text);
                    if (cookieJson.GetType().Name == "JObject")
                    {
                        foreach (var token in (JObject)cookieJson)
                        {
                            foreach (var requirement in requirements)
                            {
                                if ((string)token.Key == requirement)
                                {
                                    cookieData.Add((string)token.Key, (string)token.Value);
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (JObject token in (JArray)cookieJson)
                        {
                            foreach (var requirement in requirements)
                            {
                                if ((string)token["name"] == requirement)
                                {
                                    cookieData.Add((string)token["name"], (string)token["value"]);
                                }
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
                var filter = Builders<MongoEncapsulation>.Filter.Eq("email", emailTxBox.Text);
                var update = Builders<MongoEncapsulation>.Update
                    .Set(x => x.email, mongoEncapsulation.email)
                    .Set(x => x.password, passwordTxBox.Text)
                    .Set(x => x.Cookies, BsonDocument.Parse(CookieTxBox.Text))
                    .Set(x => x.complete, complete);
                await _mongoHelper.UpdateDocument(columnName, filter, update);
                label3.Enabled = true;
                label3.Text = "İşlem başarılı";
            }
        }
        private async void emailTxBox_TextChangedAsync(object sender, EventArgs e)
        {
            if (emailTxBox.Text != "example@example.com")
            {
                FilterDefinition<MongoEncapsulation> filter = Builders<MongoEncapsulation>.Filter.Eq("email", emailTxBox.Text);
                List<MongoEncapsulation> findUser = await _mongoHelper.GetFilteredDocuments(columnName, filter);
                CookieTxBox.Text = string.Empty;
                foreach (MongoEncapsulation user in findUser)
                {
                    CookieTxBox.Text = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(user.Cookies.ToString())).ToString();
                    emailTxBox.Text = user.email;
                    passwordTxBox.Text = user.password;
                    if ((bool)user.complete)
                    {
                        completeTrueRBtn.Checked = true;
                        completeFalseRBtn.Checked = false;
                    }
                    else if ((bool)user.complete)
                    {
                        completeTrueRBtn.Checked = false;
                        completeFalseRBtn.Checked = true;
                    }
                }
            }
            else
            {
                completeFalseRBtn.Checked = false;
                emailTxBox.Text = "example@example.com";
                passwordTxBox.Text = "Password";
            }
        }
        private void completeTrueRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (completeTrueRBtn.Checked)
            {
                completeFalseRBtn.Checked = false;
                complete = true;
            }
        }
        private void completeFalseRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (completeFalseRBtn.Checked)
            {
                completeTrueRBtn.Checked = false;
                complete = false;
            }
        }

        private void emailTxBox_Enter(object sender, EventArgs e)
        {
            if (emailTxBox.Text == "example@example.com")
            {
                emailTxBox.Text = string.Empty;
            }
        }

        private void emailTxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailTxBox.Text))
            {
                emailTxBox.Text = "example@example.com";
            }
        }

        private void passwordTxBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxBox.Text == "Password")
            {
                passwordTxBox.Text = string.Empty;
            }
        }

        private void passwordTxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTxBox.Text))
            {
                passwordTxBox.Text = "Password";
            }
        }

        private void CookieTxBox_Enter(object sender, EventArgs e)
        {
            if (CookieTxBox.Text == "Cookies(JSON)")
            {
                CookieTxBox.Text = string.Empty;
            }
        }

        private void CookieTxBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CookieTxBox.Text))
            {
                CookieTxBox.Text = "Cookies(JSON)";
            }
        }
    }
}