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
            Edit.Enabled = IsNotEmptyAndSelected();
        }        

        private bool IsNotEmpty() => !string.IsNullOrWhiteSpace(Nametbx.Text) && 
                                     !string.IsNullOrWhiteSpace(Surnametbx.Text) && 
                                     !string.IsNullOrWhiteSpace(Agetbx.Text);
        
        private void UsersLbx_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Delete.Enabled = IsSelected();
            Edit.Enabled = IsNotEmptyAndSelected();
            if (IsSelected() == false) return;
            User user = UsersLbx.SelectedItem as User;
            Nametbx.Text = user.Name;
            Surnametbx.Text = user.Surname;
            Agetbx.Text = user.Age;
        }
        private bool IsSelected() => UsersLbx.SelectedIndex != -1;

        private void Delete_Click(object sender, EventArgs e)
        {
            UsersLbx.Items.RemoveAt(UsersLbx.SelectedIndex);
            TextBoxesClear();
        }

        private void Edit_Click(object sender, EventArgs e)
        {   
            var user = new User(Nametbx.Text, Surnametbx.Text, Agetbx.Text);           
            int index = UsersLbx.SelectedIndex;
            UsersLbx.Items.Insert(UsersLbx.SelectedIndex,user);            
            UsersLbx.Items.RemoveAt(UsersLbx.SelectedIndex);
            UsersLbx.SelectedIndex = index;
            TextBoxesClear();
        }        
        private bool IsNotEmptyAndSelected() => IsNotEmpty() == true && 
                                                IsSelected() == true;
    }
}
//!string.IsNullOrWhiteSpace(Nametbx.Text) &&
//                                                !string.IsNullOrWhiteSpace(Surnametbx.Text) &&
//                                                !string.IsNullOrWhiteSpace(Agetbx.Text) &&
//                                                UsersLbx.SelectedIndex != -1;