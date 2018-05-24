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
    public partial class Add_New_Publisher : Form
    {
        public Add_New_Publisher()
        {
            InitializeComponent();
        }

        private void buttonSavePublisher_Click(object sender, EventArgs e)
        {
            if (textBoxAddPublisher.Text == "" || textBoxPublisherDescp.Text == "")
            {

                MessageBox.Show(" Invalid Entry ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                DateTime dateTime = DateTime.Now;
                dateTime.ToString("yyyyMMddHHmmss");

                String publisherName = textBoxAddPublisher.Text;
                String publisherDescp = textBoxPublisherDescp.Text;
                int bookCount = 0;
                int isActive = 1;
                int user_login_id = 2;
                //MySqlConnection connection = DataConnection.getDBConnection();
                String newAuthor_SQL = "INSERT INTO book_printers (name,description,bookCount,createDateTime,updateDateTime,isActive,user_login_history_id) VALUES (@name,@description,@bookCount,@createDateTime,@updateDateTime,@isActive,@user_login_history_id)";
                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();

                MySqlCommand command_newBookCatergory = new MySqlCommand(newAuthor_SQL, mySqlConnection);
                command_newBookCatergory.CommandText = newAuthor_SQL;
                command_newBookCatergory.Parameters.AddWithValue("@name", publisherName);
                command_newBookCatergory.Parameters.AddWithValue("@description", publisherDescp);
                command_newBookCatergory.Parameters.AddWithValue("@bookCount", bookCount);
                command_newBookCatergory.Parameters.AddWithValue("@createDateTime", dateTime);
                command_newBookCatergory.Parameters.AddWithValue("@updateDateTime", dateTime);
                command_newBookCatergory.Parameters.AddWithValue("@isActive", isActive);
                command_newBookCatergory.Parameters.AddWithValue("@user_login_history_id", user_login_id);

                command_newBookCatergory.ExecuteNonQuery();
                mySqlConnection.Close();

                DialogResult dialogResult = MessageBox.Show(" Publisher Added ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    textBoxAddPublisher.Text = String.Empty;
                    textBoxPublisherDescp.Text = String.Empty;
                }

            }
        }
    }
}
