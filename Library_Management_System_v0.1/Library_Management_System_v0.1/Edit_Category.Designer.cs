﻿namespace Library_Management_System_v0._1
{
    partial class Edit_Category
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
            this.buttonSaveCategory = new System.Windows.Forms.Button();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSaveCategory
            // 
            this.buttonSaveCategory.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCategory.Location = new System.Drawing.Point(298, 364);
            this.buttonSaveCategory.Name = "buttonSaveCategory";
            this.buttonSaveCategory.Size = new System.Drawing.Size(149, 47);
            this.buttonSaveCategory.TabIndex = 28;
            this.buttonSaveCategory.Text = "Update";
            this.buttonSaveCategory.UseVisualStyleBackColor = true;
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddCategory.Location = new System.Drawing.Point(290, 240);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(363, 34);
            this.textBoxAddCategory.TabIndex = 27;
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.Location = new System.Drawing.Point(79, 238);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(204, 32);
            this.categoryName.TabIndex = 26;
            this.categoryName.Text = "New Category Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 73);
            this.label1.TabIndex = 25;
            this.label1.Text = "Edit Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(290, 173);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(363, 30);
            this.comboBoxCategory.TabIndex = 30;
            // 
            // Edit_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveCategory);
            this.Controls.Add(this.textBoxAddCategory);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCategory;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}