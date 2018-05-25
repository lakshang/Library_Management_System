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
    public partial class Add_New_Author : Form
    {
        public Add_New_Author()
        {
            InitializeComponent();
        }
        private void buttonSaveAuthor_Click(object sender, EventArgs e)
        {
            if (textBoxAddAuthor.Text == "" || textBoxAuthorDescription.Text == "")
            {

                MessageBox.Show(" Invalid Entry ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                DateTime dateTime = DateTime.Now;
                dateTime.ToString("yyyyMMddHHmmss");

                String authorName = textBoxAddAuthor.Text;
                String authorDescp = textBoxAuthorDescription.Text;
                int bookCount = 0;
                int isActive = 1;
                int user_login_id = 1;
                //MySqlConnection connection = DataConnection.getDBConnection();
                String newAuthor_SQL = "INSERT INTO book_author (name,description,bookCount,createDateTime,updateDateTime,isActive,user_login_history_id) VALUES (@name,@description,@bookCount,@createDateTime,@updateDateTime,@isActive,@user_login_history_id)";

                // try
                //{
                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();

                MySqlCommand command_newBookCatergory = new MySqlCommand(newAuthor_SQL, mySqlConnection);
                command_newBookCatergory.CommandText = newAuthor_SQL;
                command_newBookCatergory.Parameters.AddWithValue("@name", authorName);
                command_newBookCatergory.Parameters.AddWithValue("@description", authorDescp);
                command_newBookCatergory.Parameters.AddWithValue("@bookCount", bookCount);
                command_newBookCatergory.Parameters.AddWithValue("@createDateTime", dateTime);
                command_newBookCatergory.Parameters.AddWithValue("@updateDateTime", dateTime);
                command_newBookCatergory.Parameters.AddWithValue("@isActive", isActive);
                command_newBookCatergory.Parameters.AddWithValue("@user_login_history_id", user_login_id);

                command_newBookCatergory.ExecuteNonQuery();
                mySqlConnection.Close();
                //}
                //catch (MySqlException e)
                //{

                //  MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}


                DialogResult dialogResult = MessageBox.Show(" Author Added ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    textBoxAddAuthor.Text = String.Empty;
                    textBoxAuthorDescription.Text = String.Empty;
                }

            }
        }
    }
}
