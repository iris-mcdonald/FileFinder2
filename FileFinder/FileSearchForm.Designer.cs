﻿namespace FileFinder
{
    partial class searchFileForm
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
            this.components = new System.ComponentModel.Container();
            this.fileExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchFile = new System.Windows.Forms.TextBox();
            this.searchPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileExtension
            // 
            this.fileExtension.Location = new System.Drawing.Point(247, 67);
            this.fileExtension.MaxLength = 10;
            this.fileExtension.Name = "fileExtension";
            this.fileExtension.Size = new System.Drawing.Size(228, 22);
            this.fileExtension.TabIndex = 0;
            this.fileExtension.Tag = "Enter a file extension:";
            this.fileExtension.Text = "(i.e. .XML, .TXT, .JSON, .CONFIG)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a file extension:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "String of text to search: ";
            // 
            // searchFile
            // 
            this.searchFile.Location = new System.Drawing.Point(247, 168);
            this.searchFile.MaxLength = 50;
            this.searchFile.Name = "searchFile";
            this.searchFile.Size = new System.Drawing.Size(238, 22);
            this.searchFile.TabIndex = 3;
            this.searchFile.TextChanged += new System.EventHandler(this.searchFile_TextChanged);
            // 
            // searchPath
            // 
            this.searchPath.Location = new System.Drawing.Point(247, 99);
            this.searchPath.MaxLength = 75;
            this.searchPath.Name = "searchPath";
            this.searchPath.Size = new System.Drawing.Size(318, 22);
            this.searchPath.TabIndex = 4;
            this.searchPath.Text = "C:\\Users\\CC5 STUDENT\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path to search: ";
            // 
            // searchButton
            // 
            this.searchButton.AccessibleDescription = " ";
            this.searchButton.Location = new System.Drawing.Point(247, 274);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(372, 274);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fileList
            // 
            this.fileList.Location = new System.Drawing.Point(80, 392);
            this.fileList.MaximumSize = new System.Drawing.Size(4, 50);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(0, 22);
            this.fileList.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 322);
            this.textBox1.MinimumSize = new System.Drawing.Size(200, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(608, 242);
            this.textBox1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // searchFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 605);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchPath);
            this.Controls.Add(this.searchFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileExtension);
            this.Name = "searchFileForm";
            this.Text = "File Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.button1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchFile;
        private System.Windows.Forms.TextBox searchPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox fileList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

