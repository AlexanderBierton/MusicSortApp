namespace Music_Sort_App
{
    partial class Form2
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
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeDeleteBtn = new System.Windows.Forms.Button();
            this.clearSelDelBtn = new System.Windows.Forms.Button();
            this.clearSelRenameBtn = new System.Windows.Forms.Button();
            this.removeRenameBtn = new System.Windows.Forms.Button();
            this.listToDelete = new System.Windows.Forms.ListView();
            this.listToRename = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // acceptBtn
            // 
            this.acceptBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptBtn.Location = new System.Drawing.Point(252, 303);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 1;
            this.acceptBtn.Text = "Proceed";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.remItems);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(62, 303);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelRem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items to Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items to Rename";
            // 
            // removeDeleteBtn
            // 
            this.removeDeleteBtn.Location = new System.Drawing.Point(282, 43);
            this.removeDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeDeleteBtn.Name = "removeDeleteBtn";
            this.removeDeleteBtn.Size = new System.Drawing.Size(94, 22);
            this.removeDeleteBtn.TabIndex = 6;
            this.removeDeleteBtn.Text = "Remove";
            this.removeDeleteBtn.UseVisualStyleBackColor = true;
            this.removeDeleteBtn.Click += new System.EventHandler(this.remDelBtn);
            // 
            // clearSelDelBtn
            // 
            this.clearSelDelBtn.Location = new System.Drawing.Point(283, 86);
            this.clearSelDelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearSelDelBtn.Name = "clearSelDelBtn";
            this.clearSelDelBtn.Size = new System.Drawing.Size(94, 22);
            this.clearSelDelBtn.TabIndex = 7;
            this.clearSelDelBtn.Text = "Clear Selection";
            this.clearSelDelBtn.UseVisualStyleBackColor = true;
            // 
            // clearSelRenameBtn
            // 
            this.clearSelRenameBtn.Location = new System.Drawing.Point(284, 226);
            this.clearSelRenameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearSelRenameBtn.Name = "clearSelRenameBtn";
            this.clearSelRenameBtn.Size = new System.Drawing.Size(94, 22);
            this.clearSelRenameBtn.TabIndex = 9;
            this.clearSelRenameBtn.Text = "Clear Selection";
            this.clearSelRenameBtn.UseVisualStyleBackColor = true;
            // 
            // removeRenameBtn
            // 
            this.removeRenameBtn.Location = new System.Drawing.Point(283, 183);
            this.removeRenameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeRenameBtn.Name = "removeRenameBtn";
            this.removeRenameBtn.Size = new System.Drawing.Size(94, 22);
            this.removeRenameBtn.TabIndex = 8;
            this.removeRenameBtn.Text = "Remove";
            this.removeRenameBtn.UseVisualStyleBackColor = true;
            this.removeRenameBtn.Click += new System.EventHandler(this.remRenBtn);
            // 
            // listToDelete
            // 
            this.listToDelete.Location = new System.Drawing.Point(17, 30);
            this.listToDelete.Name = "listToDelete";
            this.listToDelete.Size = new System.Drawing.Size(260, 97);
            this.listToDelete.TabIndex = 10;
            this.listToDelete.UseCompatibleStateImageBehavior = false;
            this.listToDelete.View = System.Windows.Forms.View.Details;
            // 
            // listToRename
            // 
            this.listToRename.Location = new System.Drawing.Point(17, 168);
            this.listToRename.Name = "listToRename";
            this.listToRename.Size = new System.Drawing.Size(260, 97);
            this.listToRename.TabIndex = 11;
            this.listToRename.UseCompatibleStateImageBehavior = false;
            this.listToRename.View = System.Windows.Forms.View.Details;
            // 
            // Form2
            // 
            this.AcceptButton = this.acceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.listToRename);
            this.Controls.Add(this.listToDelete);
            this.Controls.Add(this.clearSelRenameBtn);
            this.Controls.Add(this.removeRenameBtn);
            this.Controls.Add(this.clearSelDelBtn);
            this.Controls.Add(this.removeDeleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.MaximumSize = new System.Drawing.Size(400, 370);
            this.MinimumSize = new System.Drawing.Size(400, 370);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Items to be Removed";
            this.Load += new System.EventHandler(this.getList);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeDeleteBtn;
        private System.Windows.Forms.Button clearSelDelBtn;
        private System.Windows.Forms.Button clearSelRenameBtn;
        private System.Windows.Forms.Button removeRenameBtn;
        private System.Windows.Forms.ListView listToDelete;
        private System.Windows.Forms.ListView listToRename;
    }
}