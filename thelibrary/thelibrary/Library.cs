using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Deployment.Application;
using System.Security.Policy;

namespace thelibrary
{
    internal class Library
    {
        //degiskenler
        List<Book> MainLibrary;
        List<Book> BorrowLibrary;
        List<Book> Templibrary;
        public Library()
        {
            MainLibrary = new List<Book>();
            BorrowLibrary = new List<Book>();
            Templibrary = new List<Book>();
  

            
            


        }

        //kitap ekleme
        public void AddToLibrary(String title,string author,string isbn,int copynumber)
        {
            GetDataFromSQLMain();
            foreach (Book b in MainLibrary)
            {
                if(b.ISBN == isbn)
                {
                    
                    if(!(b.Title == title) || !(b.Author== author))
                    {
                        MessageBox.Show("Wrong Title or Author!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        return;
                    }
                    b.CopyNumber+=copynumber;
                    clearList();
                    DeleteDataFromSQL("MainLibrary", b.ISBN);
                    SetMainLibraryDatatoSQL();
                    MainLibrary.Clear();
                    return;
                }
                
            }
            Book book = new Book()
            {
                Title = title,
                Author = author,
                ISBN = isbn,
                CopyNumber = copynumber,
                EnteranceDate = DateTime.Now,
            };
            MainLibrary.Add(book);
            SetMainLibraryDatatoSQL();
            MainLibrary.Clear();
        }


        //tüm kitapları görüntüleme              
        public string ShowBooks()
            {
            string value = "Available books: \n" ;

            GetDataFromSQLMain();
            foreach (Book book in MainLibrary)
                {
                    value += "\n"+ book.ToString()+"\n \n";
                
                }
            
            MainLibrary.Clear();
            return value;
            
            }

        //kitabı aratma                         geliştirilecek
        public string FindBookbyTitleorAuthor(string inputvalue)
        {
            string returnValue="Books your looking for: \n \n"+"***\n";
            GetDataFromSQLMain();


            foreach (Book book in MainLibrary)
            {
                if (book.Title.ToLower().Replace(" ", "") == inputvalue.ToLower().Replace(" ", "") || book.Author.ToLower().Replace(" ", "") == inputvalue.ToLower().Replace(" ", ""))
                {
                    returnValue += "\n" + book.ToString() + "\n \n";

                    
                }

                
            }
            MainLibrary.Clear() ;
            return returnValue+"\n***";
        }
        //Kitabı ödünç alma
        public void BorrowBook(string isbn)
        {
            GetDataFromSQLMain();
            GetDataFromSQLBorrowed();

            /*    
                // Book removebook = null;
                  foreach (Book book1 in MainLibrary)
                  {

                      if (isbn==book1.ISBN)
                      {

                          if (book1.CopyNumber>0)
                          {

                              Book book2 = new Book();
                              //removebook = book1;
                              book2.ISBN = book1.ISBN;
                              book2.Title = book1.Title;
                              book2.Author = book1.Author;
                              book2.CopyNumber = 0;
                              book2.EnteranceDate = book1.EnteranceDate;
                              book2.BorrowDate = DateTime.Now;
                              book2.ReturnDate = DateTime.Now.AddDays(14);
                              book1.CopyNumber--;
                   //       DeleteDataFromSQL("MainLibrary", book1.ISBN);
                              book2.CopyNumber = 1;
                              BorrowLibrary.Add(book2);
                              MessageBox.Show($"You Borrowed: {book2.ToString()}");
                              break;
                          }
                          if(book1.CopyNumber<=0)
                          {
                              MessageBox.Show("Book is borrowed.Check borrowed books");
                              break;
                          }




                      }
                  }
                  clearList();
                  clearborrowedList();
                  //MainLibrary.Remove(removebook);
                  SetBorrowedLibraryDatatoSQL();
                  SetMainLibraryDatatoSQL();
                  BorrowLibrary.Clear();
                  MainLibrary.Clear();
              */

            bool isborrwed = false;
            foreach(Book book in MainLibrary)
            {
                if (book.ISBN == isbn)
                {


                    if(book.CopyNumber > 0)
                    {
                    isborrwed=true;
                    book.CopyNumber--;
                    book.BorrowDate = DateTime.Now;
                    book.ReturnDate = DateTime.Now.AddDays(14);
                    BorrowLibrary.Add(book);
                    MessageBox.Show("Borrow sucsess.", "Borrow sucsess.");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Not enough book.");
                        break;
                    }
                }
            }
            if (isborrwed)
            {

            clearList();
            clearborrowedList();
            SetBorrowedLibraryDatatoSQL();
            SetMainLibraryDatatoSQL();
            }
            BorrowLibrary.Clear();
            MainLibrary.Clear();
            

        }

        //kitabı iade etme
        public void ReturnBook(int inputvalue)
        {
           
            GetDataFromSQLBorrowed();

            Book removedBook =null;
            foreach( Book book in BorrowLibrary)
            {
                if(book.Borrowid==inputvalue)
                {
                    if(DateTime.Now< book.ReturnDate )
                    {
                        
                        AddToLibrary(book.Title,book.Author,book.ISBN,1);
                        
                        removedBook = book;
                        break;
                    }
                    if(DateTime.Now> book.ReturnDate)
                    {
                        AddToLibrary(book.Title, book.Author, book.ISBN, 1);

                        removedBook = book;
                        MessageBox.Show("!!!!!!!!!!!!!!!!YOU ARE LATE!!!!!!!!!!!!");
                        break;
                    }
                }
            }
            
            BorrowLibrary.Remove(removedBook);
            MessageBox.Show($"Returned to library book: \n {removedBook}");
            clearborrowedList();
            SetBorrowedLibraryDatatoSQL();
            BorrowLibrary.Clear();

        }

        //odunc Alinmis kitaplari goster
        public string ShowBorrowedBooks()
        {
            string value = "";
            GetDataFromSQLBorrowed();
            foreach (Book book in BorrowLibrary)
            {
                value = value + "\n" +
                    $"\nBorrow Id: {book.Borrowid}"+"\n" +
                    book.ToString()+
                    $"\nBorrow date: {book.BorrowDate}"+
                    $"\nReturn date(exp): {book.ReturnDate}"+
                    "\n";

            }
            BorrowLibrary.Clear();
            return value;
            

        }

        //süresi geçmiş kitaplarla ilgili bilgileri gösterin
        public string ShowExpiredBooks()
        {
            string value = "";
            GetDataFromSQLBorrowed();
            foreach (Book book in BorrowLibrary)
            {
                if (book.ReturnDate < DateTime.Now)
                {
                    value += book.ToString();
                }
                
            }
            BorrowLibrary.Clear();
            return value;
        }
        /*
        //SQLden verileri alma ana kutuphane
        private void GetDataFromSQLMain()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data source=DataBase.db;Version=3"))
            {
                string sql = "SELECT Title, Author, ISBN, CopyNumber ,EnteranceDate FROM MainLibrary";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    string author = reader["Author"].ToString();
                    string isbn = reader["ISBN"].ToString();
                    int copyNumber = Convert.ToInt32(reader["CopyNumber"]);
                    DateTime enterancedate = Convert.ToDateTime(reader["EnteranceDate"].ToString());
                    MainLibrary.Add(new Book() { Title = title, Author = author, ISBN = isbn, CopyNumber = copyNumber ,EnteranceDate= enterancedate });
                }
                reader.Close();
            }

        }
        
        //SQLden veri alma emanetler kutuphanesi
        private void GetDataFromSQLBorrowed()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data source=DataBase.db;Version=3"))
            {
                string sql = "SELECT Title, Author, ISBN, CopyNumber, EnteranceDate, BorrowId, BorrowDate, ReturnDate FROM BorrowedLibrary";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    string author = reader["Author"].ToString();
                    string isbn = reader["ISBN"].ToString();
                    int copyNumber = Convert.ToInt32(reader["CopyNumber"]);
                    DateTime enterancedate = Convert.ToDateTime(reader["EnteranceDate"].ToString());
                    int borrowid = Convert.ToInt32(reader["BorrowId"]);
                    DateTime barrowdate = Convert.ToDateTime(reader["BorrowDate"].ToString());
                    DateTime retundate = Convert.ToDateTime(reader["ReturnDate"].ToString());
                    BorrowLibrary.Add(new Book() { Title = title, Author = author, ISBN = isbn, CopyNumber = copyNumber ,EnteranceDate = enterancedate , Borrowid=borrowid, BorrowDate = barrowdate , ReturnDate = retundate});
                }
                reader.Close();
            }

        }
        */
        private void GetDataFromSQLMain()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data source=DataBase.db;Version=3"))
            {
                string sql = "SELECT Title, Author, ISBN, CopyNumber, EnteranceDate FROM MainLibrary";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    string author = reader["Author"].ToString();
                    string isbn = reader["ISBN"].ToString();
                    int copyNumber = Convert.ToInt32(reader["CopyNumber"]);
                    DateTime enterancedate = Convert.ToDateTime(reader["EnteranceDate"]);
                    MainLibrary.Add(new Book() { Title = title, Author = author, ISBN = isbn, CopyNumber = copyNumber, EnteranceDate = enterancedate });
                }
                reader.Close();
                connection.Close();
            }
        }

        private void GetDataFromSQLBorrowed()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data source=DataBase.db;Version=3"))
            {
                string sql = "SELECT Title, Author, ISBN, CopyNumber, EnteranceDate, BorrowId, BorrowDate, ReturnDate FROM BorrowedLibrary";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    string author = reader["Author"].ToString();
                    string isbn = reader["ISBN"] .ToString();
                    int copyNumber = Convert.ToInt32(reader["CopyNumber"]);
                    DateTime enterancedate = Convert.ToDateTime(reader["EnteranceDate"]);
                    int borrowid = Convert.ToInt32(reader["BorrowId"]);
                    DateTime barrowdate = Convert.ToDateTime(reader["BorrowDate"]);
                    DateTime retundate = Convert.ToDateTime(reader["ReturnDate"]);
                    BorrowLibrary.Add(new Book() { Title = title, Author = author, ISBN = isbn, CopyNumber = copyNumber, EnteranceDate = enterancedate, Borrowid = borrowid, BorrowDate = barrowdate, ReturnDate = retundate });
                    
                }
                reader.Close();
                connection.Close();
            }
        }

        //SQLe veri gonderme ana kutuphane
        public void SetMainLibraryDatatoSQL()
        {
                string connectionString = "Data source=DataBase.db;Version=3";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    foreach (Book book in MainLibrary)
                    {
                        string sql = "INSERT INTO MainLibrary (Title, Author, ISBN, CopyNumber, EnteranceDate) VALUES (@Title, @Author, @ISBN, @CopyNumber, @EnteranceDate)";

                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@Title", book.Title);
                            command.Parameters.AddWithValue("@Author", book.Author);
                            command.Parameters.AddWithValue("@ISBN", book.ISBN);
                            command.Parameters.AddWithValue("@CopyNumber", book.CopyNumber);
                            command.Parameters.AddWithValue("@EnteranceDate", book.EnteranceDate);

                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }    
        }
    
        //SQLe Veri Gonderme emanetler kutuphanesi
        public void SetBorrowedLibraryDatatoSQL()
    {
        string connectionString = "Data source=DataBase.db;Version=3";
        string sql = "INSERT INTO BorrowedLibrary (Title, Author, ISBN, CopyNumber, EnteranceDate, BorrowDate, ReturnDate) VALUES (@Title, @Author, @ISBN, @CopyNumber, @EnteranceDate, @BorrowDate, @ReturnDate)";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            foreach (Book book in BorrowLibrary)
            {
               
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    command.Parameters.AddWithValue("@CopyNumber", book.CopyNumber);
                    command.Parameters.AddWithValue("@EnteranceDate", book.EnteranceDate);
                    command.Parameters.AddWithValue("@BorrowDate", book.BorrowDate);
                    command.Parameters.AddWithValue("@ReturnDate", book.ReturnDate);
                    

                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
    }

        //SQLden kosullu veri silme
        public void DeleteDataFromSQL(string tablename,string isbn)
        {
            string connectionString = "Data source=DataBase.db;Version=3";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
             
                string sql = $"DELETE FROM {tablename} WHERE {isbn}";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                   
                  
                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"{rowsAffected} rows deleted.");
                }
                connection.Close() ;    

                
            }
        }

        public void clearList()
        {
            
                using (SQLiteConnection connection = new SQLiteConnection("Data source=DataBase.db;Version=3"))
                {
                    string sql = "SELECT Title, Author, ISBN, CopyNumber, EnteranceDate FROM MainLibrary";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();
                        string author = reader["Author"].ToString();
                        string isbn = reader["ISBN"].ToString();
                        int copyNumber = Convert.ToInt32(reader["CopyNumber"]);
                        DateTime enterancedate = Convert.ToDateTime(reader["EnteranceDate"]);
                        Templibrary.Add(new Book() { Title = title, Author = author, ISBN = isbn, CopyNumber = copyNumber, EnteranceDate = enterancedate });
                    }
                    reader.Close();
                    connection.Close();
                }
            

                foreach(Book aaa in Templibrary)
            {
                foreach (Book bbb in MainLibrary)
                {

                    if(aaa.ISBN==bbb.ISBN)
                    {
                        DeleteDataFromSQL("MainLibrary", aaa.ISBN);

                    }
                    
                }
            }

                Templibrary.Clear();
        }

        public void clearborrowedList()
        {

            using (SQLiteConnection connection = new SQLiteConnection("Data source=DataBase.db;Version=3"))
            {
                string sql = "SELECT Title, Author, ISBN, CopyNumber, EnteranceDate FROM BorrowedLibrary";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["Title"].ToString();
                    string author = reader["Author"].ToString();
                    string isbn = reader["ISBN"].ToString();
                    int copyNumber = Convert.ToInt32(reader["CopyNumber"]);
                    DateTime enterancedate = Convert.ToDateTime(reader["EnteranceDate"]);
                    Templibrary.Add(new Book() { Title = title, Author = author, ISBN = isbn, CopyNumber = copyNumber, EnteranceDate = enterancedate });
                }
                reader.Close();
                connection.Close();
            }


            foreach (Book aaa in Templibrary)
            {
                foreach (Book bbb in BorrowLibrary)
                {

                    if (aaa.ISBN == bbb.ISBN)
                    {
                        DeleteDataFromSQL("BorrowedLibrary", aaa.ISBN);

                    }

                }
            }

            Templibrary.Clear();
        }


        //SQLe full save alma
        public void SaveFullData()
        {
            SetMainLibraryDatatoSQL();
            SetBorrowedLibraryDatatoSQL();

            MainLibrary.Clear();
            BorrowLibrary.Clear();

            GetDataFromSQLMain();
            GetDataFromSQLBorrowed();

        }
    }
}


