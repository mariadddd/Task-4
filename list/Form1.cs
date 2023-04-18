using System;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            User user = new User(Nametbx.Text, Surnametbx.Text, Agetbx.Text);
            UsersLbx.Items.Add(user.Info());
            if (Nametbx.Text == "") { Add.Enabled = false; }
        }
        private void Add_NametbxIsEmpty(object sender, EventArgs e)
        {
            if (Nametbx.Text != null) { Add.Enabled = true; }
        }
    }
}
