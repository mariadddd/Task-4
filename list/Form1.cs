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
            Delete.Enabled = false;
            Edit.Enabled = false;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            User user = new User(Nametbx.Text, Surnametbx.Text, Agetbx.Text);
            UsersLbx.Items.Add(user);
            TextBoxesClear();
        }
        private void TextBoxesClear()
        {
            Nametbx.Clear();
            Surnametbx.Clear();
            Agetbx.Clear();
        }
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            Add.Enabled = IsNotEmpty();
        }        

        private bool IsNotEmpty() => !string.IsNullOrWhiteSpace(Nametbx.Text) && 
                                     !string.IsNullOrWhiteSpace(Surnametbx.Text) && 
                                     !string.IsNullOrWhiteSpace(Agetbx.Text);
        
        private void UsersLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UsersLbx.SelectedIndex == -1) 
            {
                Delete.Enabled = false;
                Edit.Enabled = false;
                return; 
            }
            Delete.Enabled = true;
            Edit.Enabled = true;
            User user = UsersLbx.SelectedItem as User;
            Nametbx.Text = user.Name;
            Surnametbx.Text = user.Surname;
            Agetbx.Text = user.Age;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            UsersLbx.Items.RemoveAt(UsersLbx.SelectedIndex);
            TextBoxesClear();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //temp
            if (UsersLbx.SelectedIndex == -1) return;
            //end
            var user = new User();
            user.Name = Nametbx.Text;
            user.Surname = Surnametbx.Text;
            user.Age = Agetbx.Text;
            int index = UsersLbx.SelectedIndex;
            UsersLbx.Items.Insert(UsersLbx.SelectedIndex,user);            
            UsersLbx.Items.RemoveAt(UsersLbx.SelectedIndex);
            UsersLbx.SelectedIndex = index;
        }
    }
}
