using System;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Add.Enabled = false;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            User user = new User(Nametbx.Text, Surnametbx.Text, Agetbx.Text);
            UsersLbx.Items.Add(user);
            Nametbx.Clear();
            Surnametbx.Clear();
            Agetbx.Clear();
        }
        private void Nametbx_TextChanged(object sender, EventArgs e)
        {
            Add.Enabled = IsNotEmpty();
        }
        private void Surnametbx_TextChanged(object sender, EventArgs e)
        {
            Add.Enabled = IsNotEmpty();
        }
        private void Agetbx_TextChanged(object sender, EventArgs e)
        {
            Add.Enabled = IsNotEmpty();
        }

        private bool IsNotEmpty() => !string.IsNullOrWhiteSpace(Nametbx.Text) && 
                                     !string.IsNullOrWhiteSpace(Surnametbx.Text) && 
                                     !string.IsNullOrWhiteSpace(Agetbx.Text);
    }
}
