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
            Add.Enabled = true;
            UsersLbx.Items.Add(user);
        }

        private void Nametbx_TextChanged(object sender, EventArgs e)
        {
            if (Nametbx.Text == "") { Add.Enabled = false; }
            else { Add.Enabled = true; }
        }

        private void Surnametbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
