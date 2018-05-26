﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v0._1
{
    public partial class Add_New_Book_Type : Form
    {
        Register_new_books rnbinstance;
        public Add_New_Book_Type(Register_new_books rnb)
        {
            InitializeComponent();
            this.rnbinstance = rnb;
        }

        private void buttonSaveBookType_Click(object sender, EventArgs e)
        {
            String newBookType = textBoxAddBookType.Text;
            String addNewBookTypeQuery = "INSERT INTO book_type (name) VALUES (@name)";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand newBookTypeCommand = new MySqlCommand(addNewBookTypeQuery, mySqlConnection);
            newBookTypeCommand.CommandText = addNewBookTypeQuery;
            newBookTypeCommand.Parameters.AddWithValue("@name", newBookType);
            newBookTypeCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            DialogResult dialogResult = MessageBox.Show("New Book Type Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                textBoxAddBookType.Text = String.Empty;
                //Register_new_books
                new Register_new_books().Show();
                rnbinstance.Hide();
                this.Dispose();
            }
        }
    }
}
