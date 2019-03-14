namespace Music_Sort_App
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
            this.folderDirectory = new System.Windows.Forms.TextBox();
            this.startSort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.noOfFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderDirectory
            // 
            this.folderDirectory.Location = new System.Drawing.Point(12, 45);
            this.folderDirectory.Name = "folderDirectory";
            this.folderDirectory.ReadOnly = true;
            this.folderDirectory.Size = new System.Drawing.Size(333, 20);
            this.folderDirectory.TabIndex = 0;
            // 
            // startSort
            // 
            this.startSort.Enabled = false;
            this.startSort.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSort.Location = new System.Drawing.Point(12, 290);
            this.startSort.Name = "startSort";
            this.startSort.Size = new System.Drawing.Size(451, 59);
            this.startSort.TabIndex = 1;
            this.startSort.Text = "Sort";
            this.startSort.UseVisualStyleBackColor = true;
            this.startSort.Click += new System.EventHandler(this.sortMusic);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.browseFiles);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(13, 72);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(450, 186);
            this.fileList.TabIndex = 3;
            // 
            // noOfFiles
            // 
            this.noOfFiles.Location = new System.Drawing.Point(406, 265);
            this.noOfFiles.Name = "noOfFiles";
            this.noOfFiles.ReadOnly = true;
            this.noOfFiles.Size = new System.Drawing.Size(56, 20);
            this.noOfFiles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noOfFiles);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startSort);
            this.Controls.Add(this.folderDirectory);
            this.MaximumSize = new System.Drawing.Size(491, 400);
            this.MinimumSize = new System.Drawing.Size(491, 400);
            this.Name = "Form1";
            this.Text = "Sort Music";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderDirectory;
        private System.Windows.Forms.Button startSort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.TextBox noOfFiles;
        private System.Windows.Forms.Label label1;
    }
}

