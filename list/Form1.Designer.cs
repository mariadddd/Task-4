﻿namespace list
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersLbx = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.Agelbl = new System.Windows.Forms.Label();
            this.Nametbx = new System.Windows.Forms.TextBox();
            this.Surnametbx = new System.Windows.Forms.TextBox();
            this.Agetbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersLbx
            // 
            this.UsersLbx.FormattingEnabled = true;
            this.UsersLbx.ItemHeight = 16;
            this.UsersLbx.Location = new System.Drawing.Point(47, 83);
            this.UsersLbx.Name = "UsersLbx";
            this.UsersLbx.Size = new System.Drawing.Size(442, 292);
            this.UsersLbx.TabIndex = 0;
            this.UsersLbx.Tag = "";
            this.UsersLbx.SelectedIndexChanged += new System.EventHandler(this.UsersLbx_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Enabled = false;
            this.Add.Location = new System.Drawing.Point(515, 352);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(686, 352);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(512, 99);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(44, 16);
            this.Namelbl.TabIndex = 3;
            this.Namelbl.Text = "Name";
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.Location = new System.Drawing.Point(512, 143);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(61, 16);
            this.Surnamelbl.TabIndex = 4;
            this.Surnamelbl.Text = "Surname";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Location = new System.Drawing.Point(512, 187);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(32, 16);
            this.Agelbl.TabIndex = 5;
            this.Agelbl.Text = "Age";
            // 
            // Nametbx
            // 
            this.Nametbx.Location = new System.Drawing.Point(16, 10);
            this.Nametbx.Name = "Nametbx";
            this.Nametbx.Size = new System.Drawing.Size(147, 22);
            this.Nametbx.TabIndex = 6;
            this.Nametbx.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // Surnametbx
            // 
            this.Surnametbx.Location = new System.Drawing.Point(16, 54);
            this.Surnametbx.Name = "Surnametbx";
            this.Surnametbx.Size = new System.Drawing.Size(147, 22);
            this.Surnametbx.TabIndex = 7;
            this.Surnametbx.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // Agetbx
            // 
            this.Agetbx.Location = new System.Drawing.Point(16, 98);
            this.Agetbx.Name = "Agetbx";
            this.Agetbx.Size = new System.Drawing.Size(147, 22);
            this.Agetbx.TabIndex = 8;
            this.Agetbx.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Nametbx);
            this.panel1.Controls.Add(this.Agetbx);
            this.panel1.Controls.Add(this.Surnametbx);
            this.panel1.Location = new System.Drawing.Point(584, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 141);
            this.panel1.TabIndex = 9;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(600, 352);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.Surnamelbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.UsersLbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UsersLbx;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Surnamelbl;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.TextBox Nametbx;
        private System.Windows.Forms.TextBox Surnametbx;
        private System.Windows.Forms.TextBox Agetbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Edit;
    }
}

