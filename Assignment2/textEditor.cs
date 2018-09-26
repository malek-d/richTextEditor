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
    public partial class TextEditor : Form
    {
        public User User = new User();
        public TextEditor(User user)
        {
            InitializeComponent();
            User = user;
            userNameLabel.Text += User.Username;
            fontComboBox.SelectedIndex = 2;
            fontComboBox.SelectionLength = 0;
            
            if(User.User_Type == Type.View)
            {
                richTextBox1.ReadOnly = true;
                richTextBox1.BackColor = System.Drawing.Color.LightGray;
                richTextBox1.Enabled = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            createFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createFile();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
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
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void createFile()
        {
            using (var fbd = new SaveFileDialog())
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();

                // Initialize the SaveFileDialog to specify the RTF extension for the file.
                saveFile1.DefaultExt = "*.rtf";
                saveFile1.Filter = "RTF Files|*.rtf";

                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
                {
                    String path = Path.GetFullPath(saveFile1.FileName);
                    File.CreateText(path).Close();
                    richTextBox1.Text = File.ReadAllText(saveFile1.FileName);
                }
            }

        }

        private void showAboutMessage()
        {
            MessageBox.Show("Application name: ProEdit\n" +
                            "Version: 1.00\n" +
                            "Created by: Malek Darwiche (12580357)\n" +
                            "Email: 12580357@student.uts.edu.au", "About ProEdit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(fontComboBox.SelectedItem.ToString(), out int size);
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", size);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAboutMessage();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            showAboutMessage();
        }
    }
}
