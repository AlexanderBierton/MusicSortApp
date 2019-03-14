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
    public partial class Form1 : Form
    {
        List<string> files = new List<string>();
        List<string> remFiles = new List<string>();
        List<string> renamedFiles = new List<string>();

        mainFunc mainFunc = new mainFunc();

        static string selectedPath;

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void sortMusic(object sender, EventArgs e)
        {
            for(int i = 0; i < files.Count; i++)
            {
                if (mainFunc.HasStartNumber(Path.GetFileName(files[i])))
                {
                    string toRemove = mainFunc.numToRemove;

                    string newFile = files[i].Replace(toRemove, "");

                    Console.WriteLine(newFile);
                    if (newFile != files[i])
                    {
                        if (File.Exists(newFile))
                            remFiles.Add(files[i]);
                        else
                            renamedFiles.Add(files[i] + "|" + newFile);
                    }
                    
                }
                else if(mainFunc.HasEndNumber(Path.GetFileName(files[i])))
                {
                    string toRemove = mainFunc.numToRemove;

                    string newFile = files[i].Replace(" " + toRemove, ".mp3");

                    Console.WriteLine(newFile);
                    if (newFile != files[i])
                    {
                        if (File.Exists(newFile))
                            remFiles.Add(files[i]);
                        else
                            renamedFiles.Add(files[i] + "|" + newFile);
                    }
                }
            }

            if (remFiles.Count >= 1 || renamedFiles.Count >= 1)
            {
                mainFunc.ListItems(remFiles);
                mainFunc.curList = files;
                mainFunc.renList = renamedFiles;

                form2.ShowDialog();
            } 
            else
                MessageBox.Show("There are items to edit in the directory", "Nothing to do",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void browseFiles(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    selectedPath = fbd.SelectedPath;

                    folderDirectory.Text = selectedPath;

                    mainFunc.SetPath(selectedPath);

                    fillList();
                }
            }
        }

        public void fillList()
        {
            if (files.Count >= 1)
                files.Clear();

            files = Directory.GetFiles(selectedPath).ToList();

            fileList.Items.Clear();

            for (int i = 0; i < files.Count; i++)
            {
                fileList.Items.Add(Path.GetFileName(files[i]));
            }

            noOfFiles.Text = files.Count.ToString();
            startSort.Enabled = true;
            
        }
    }
}
