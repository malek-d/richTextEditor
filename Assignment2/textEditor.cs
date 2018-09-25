using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class textEditor : Form
    {
        public User User = new User();
        public textEditor(User user)
        {
            InitializeComponent();
            User = user;
            userNameLabel.Text += User.Username;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(opentext.FileName);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void createFile()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                //fbd.DefaultExt = "*.rtf";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    String path = fbd.SelectedPath.ToString();
                    File.CreateText(path).Close();
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            createFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createFile();
        }
    }
}
