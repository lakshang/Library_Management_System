﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v0._1
{
    public partial class Register_new_books : Form
    {
        public Register_new_books()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_new_books_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e) => new Add_New_Category().Show();

        private void buttonAddAuthor_Click(object sender, EventArgs e) => new Add_New_Author().Show();

        private void buttonAddPublisher_Click(object sender, EventArgs e) => new Add_New_Publisher().Show();

        private void buttonAddType_Click(object sender, EventArgs e) => new Add_New_Book_Type().Show();
    }
}
