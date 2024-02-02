using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thelibrary
{
    public partial class Form1 : Form
    {
        private Library MainLibrary = new Library();

        public Form1()
        {
            InitializeComponent();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        //Kitap Ekleme Buttonu
        private void AddBookButton_Click(object sender, EventArgs e)
        {

            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            string isbn = isbnTextBox.Text;
            int copyNumber = Convert.ToInt32(CopyNumberCountBox.Value);

            
            string value = isbnTextBox.Text.Replace(isbnTextBox.PromptChar.ToString(), "");
            if (value.Length != 13)
            {
                MessageBox.Show("The ISBN number consists of a 13-digit number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MainLibrary.SaveFullData();//autosave icin
                return;
            }

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please complete all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MainLibrary.SaveFullData();//autosave icin
                return; 
            }


            MainLibrary.AddToLibrary(title,author,isbn,copyNumber);
            MessageBox.Show("successful.", "successful.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //kitaplari gosterme butonu
        private void ShowAllBooksButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = MainLibrary.ShowBooks();
        }
        
        //kitap arama butonu
        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            string input = SearchBarTextBox.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please complete all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            richTextBox1.Clear();
            richTextBox1.Text= MainLibrary.FindBooks(input);

        }
        
        //kitabi odunc alma
        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            string input = BorrowReturnTextBox.Text;
            string value = BorrowReturnTextBox.Text.Replace(BorrowReturnTextBox.PromptChar.ToString(), "");
            if (value.Length != 13)
            {
                MessageBox.Show("The ISBN number consists of a 13-digit number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MainLibrary.SaveFullData();//autosave icin
                return;
            }
            MainLibrary.BorrowBook(input);
            richTextBox1.Clear() ;
            MainLibrary.ShowBooks();
            MessageBox.Show("successful.", "successful.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        //Kitap geri verme
        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            string input = ReturnBookTextBox.Text;
            if(string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Borrow Id please.", "Borrow Id please.");
                return;
            }
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            MainLibrary.ReturnBook(Convert.ToInt32(input));
            richTextBox1.Clear();
            MainLibrary.ShowBooks();
            MessageBox.Show("successful.", "successful.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        //odunc alinanlari gosterme
        private void ShowBorrowedBooksButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = MainLibrary.ShowBorrowedBooks();

        }



        //misclick
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //cıkıs butonu
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainLibrary.SetMainLibraryDatatoSQL();
            MainLibrary.SetBorrowedLibraryDatatoSQL();
            Application.Exit();

        }

        private void ShowExpiredBooksButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text= MainLibrary.ShowExpiredBooks();
        }
    }
}
