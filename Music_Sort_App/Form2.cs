using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Music_Sort_App
{
    public partial class Form2 : Form
    {
        List<string> removeList = new List<string>();
        List<string> renameList = new List<string>();
        List<string> currntList = new List<string>();
        mainFunc mainFunc = new mainFunc();

        public Form2()
        {
            InitializeComponent();
        }

        private void remItems(object sender, EventArgs e)
        {
            for (int i = 0; i < removeList.Count; i++)
            {
                File.Delete(removeList[i]);
            }
            for (int i = 0; i < renameList.Count; i++)
            {
                string oldName = renameList[i].Substring(0, renameList[i].IndexOf("|"));
                string newName = renameList[i].Substring(renameList[i].LastIndexOf("|") + 1);
                try
                {
                    File.Move(oldName, newName);
                }
                catch (Exception ex)
                {
                    File.Delete(newName);
                }
                
            }

            mainFunc.ClearItems();
            Close();
        }

        private void cancelRem(object sender, EventArgs e)
        {
            mainFunc.ClearItems();
            Close();
        }

        private void getList(object sender, EventArgs e)
        {
            removeList = mainFunc.GetList();
            renameList = mainFunc.renList;

            for (int i = 0; i < removeList.Count; i++)
            {
                listToDelete.Items.Add(Path.GetFileName(removeList[i]));
            }

            for (int i = 0; i < renameList.Count; i++)
            {
                string filePath = renameList[i].Substring(0, renameList[i].IndexOf("|"));

                listToRename.Items.Add(Path.GetFileName(filePath));
            }
        }

        private void remDelBtn(object sender, EventArgs e)
        {
            if(listToDelete.SelectedItems.Count > 0)
            {
                foreach(Object item in listToDelete.SelectedItems)
                {
                    MessageBox.Show(item.ToString(), "Confirmation");
                }
            }
            else
            {
                MessageBox.Show("No item has been selected", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void remRenBtn(object sender, EventArgs e)
        {
            if (listToRename.SelectedItems.Count > 0)
            {
                foreach (Object item in listToRename.SelectedItems)
                {
                    MessageBox.Show(item.ToString(), "Confirmation");
                }
            }
            else
            {
                MessageBox.Show("No item has been selected", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
