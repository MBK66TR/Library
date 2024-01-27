using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace thelibrary
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public int CopyNumber;
        public int Borrowid;
        public DateTime EnteranceDate;
        public DateTime BorrowDate;
        public DateTime ReturnDate;
        public override string ToString()
        {

            return $"Name : {Title}\n" +
                   $"Author : {Author}\n" +
                   $"ISBN : {ISBN}\n" +
                   $"Copy Number : {CopyNumber}\n" +
                   $"Enterance Date: {EnteranceDate.ToString("dd/MM/yyyy")}";
        }
    }
}
