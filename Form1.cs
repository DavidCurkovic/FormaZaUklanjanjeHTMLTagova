using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Copy/Paste html koda unutar Textboxa1 radi dobivanja modificiranog koda, tj. u slučaju da se treba prevesti samo određeni dio koda
        private void ReplaceBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Replace("<br />", Environment.NewLine);
                textBox1.Text = Regex.Replace(textBox1.Text, @"<(.|\n)*?>", string.Empty);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        //Add dodaje datoteku spremnu za modifikacije
        private void AddBtn(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string filename = openFileDialog1.FileName;

            FileInfo file = new FileInfo(filename);

            AddedTextBox.Text = file.Name;

        }

        //Delete briše dodanu datoteku
        private void DeleteBtn_Click(object sender, EventArgs e)
        { 
            string filename = openFileDialog1.FileName;

            if (File.Exists(filename)){

                FileInfo file = new FileInfo(filename);

                File.Delete(filename);
                MessageBox.Show("File Deleted!");

                DeletedTextBox.Text = file.Name;
            }

            else
                MessageBox.Show("File doesn't exist!");


        }

        //Replace zamjenjuje datoteku za promijenjenu
        private void ReplaceBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = openFileDialog1.FileName;

                FileInfo file = new FileInfo(filename);

                string text = File.ReadAllText(filename);

                if (!string.IsNullOrEmpty(text))
                    text = Regex.Replace(text, @"<(.|\n)*?>", string.Empty);

                File.WriteAllText(filename, text);

                ReplacedTextBox.Text = file.Name;
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("File doesn't exist!");

            }
        }



        // SaveAs kreira novi file sa promijenjenom datotekom, stara datoteka ostaje nepromijenjena
        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();

                string filename = openFileDialog1.FileName;
                string filename2 = saveFileDialog1.FileName;

                FileInfo file2 = new FileInfo(filename2);
                FileInfo file = new FileInfo(filename);

                string text = File.ReadAllText(filename);

                if (!string.IsNullOrEmpty(text))
                    text = Regex.Replace(text, @"<(.|\n)*?>", string.Empty);

                File.WriteAllText(filename2, text);

                ReplacedTextBox.Text = file.Name;
                SavedAsTextBox.Text = file2.Name;
            }

            catch(FileNotFoundException)
            {
                MessageBox.Show("File doesn't exist!");

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Clear postavlja prazan sadržaj TextBox-ova osim AddedTextBoxa koji ostaje radi preglednosti datoteka koje su trenutno na modificiranju 
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DeletedTextBox.Text = "";
            ReplacedTextBox.Text = "";
            SavedAsTextBox.Text = "";
            textBox1.Text = "";
        }
    }
    
}
