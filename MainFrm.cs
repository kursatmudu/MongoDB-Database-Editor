using Amazon.Runtime.Internal.Util;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
    public partial class MainFrm : Form
    {
        private MongoHelper _mongoHelper = new MongoHelper();

        public MainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
        private void getForm(Form form)
        {
            panel2.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            panel2.Controls.Add(form);
            form.Show();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            getForm(new AddDataFrm());
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            getForm(new UpdateDataFrm());
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            getForm(new DelDataFrm());
        }

        private void GetDataBtn_Click(object sender, EventArgs e)
        {
            getForm(new DataFrm());
        }        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
