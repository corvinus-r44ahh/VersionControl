using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName; // label1
            lblFirstName.Text = Resource1.FirstName; // label2
            btnAdd.Text = Resource1.Add; // button1
            button1.Text = Resource1.Save;


            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text
            };
            users.Add(u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Application.StartupPath;
            save.Filter = "Comma Seperated Values (*.csv) | *.csv";
            save.DefaultExt = "csv";
            save.AddExtension = true;

            if (save.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter kiiras = new StreamWriter(save.FileName, false, Encoding.UTF8))
            {
                foreach (var u in users)
                {
                    kiiras.Write(u.FirstName);
                    kiiras.Write(" ");
                    kiiras.Write(u.LastName);
                    kiiras.Write("; ");
                    kiiras.Write(u.ID);
                    
                }
            }
        }
    }
}
