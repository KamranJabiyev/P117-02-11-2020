using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention
{
    class Program
    {
        #region Enum
        public enum WeekDays { Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        public enum Errors { NotFound=404,ServerSideError=500};
        #endregion
        static void Main(string[] args)
        {
            #region Nullable value type
            //Write(null);

            //bool? isTrue = null;
            //long? number = null;
            #endregion

            #region Enum - value type
            //Console.WriteLine((int)WeekDays.Monday);
            //foreach (var item in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine((int)item);
            //}
            //int num = 1;
            //switch (num)
            //{
            //    case (int)WeekDays.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case (int)WeekDays.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    default:
            //        Console.WriteLine("Other day");
            //        break;
            //}
            #endregion

            #region Indexer
            //int[] arr = { 1, 2, 3, 4, 5 };
            //arr[0] = 10;
            //Console.WriteLine(arr[0]);
            //Book b1 = new Book("Davinchinin shifresi");
            //Book b2 = new Book("Heyat eshqi");
            //Book b3 = new Book("Cehennem");
            //Book b4 = new Book("Xemse");

            //Library libraff = new Library("Libraff");
            //libraff.AddBook(0,b1);
            //libraff.AddBook(1, b2);
            //libraff.AddBook(5, b3);
            //libraff.AddBook(100, b4);
            //libraff.ShowBooks();
            //Console.WriteLine(libraff.GetBook(100));
            //libraff[0] = b1;
            //libraff[1] = b2;
            //libraff[2] = b3;
            //libraff[100] = b4;
            //Console.WriteLine(libraff[1]);
            #endregion

            #region Task
            //Person p1 = new Person("Melek", 24);
            //Person p2 = new Person("Vasif", 27);
            //Person p3 = new Person("Nahide", 22);
            //Person[] people = { p1, p2, p3 };
            //Array.Sort(people);
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region Extention
            string email = "k@code.edu.az";
            Console.WriteLine(email.IsEmail());
            double num = 5;
            double pow = 3;
            Console.WriteLine(num.CustomPow(pow));
            //Console.WriteLine(Extention.IsEmail(email));
            //Console.WriteLine(IsEmail(email));
            #endregion
        }

        //static bool IsEmail(string email)
        //{
        //    try
        //    {
        //        MailAddress mail = new MailAddress(email);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        #region Nullable value type
        public static void Write(int? n)
        {
            if(n==null)
            {
                Console.WriteLine("Ana sehife");
                return;
            }
            Console.WriteLine(n);
        }
        #endregion
    }

    #region Task
    //class Person:IComparable
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Person(string name,int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        return Age.CompareTo(((Person)obj).Age);
    //    }
    //}
    #endregion

    #region Indexer
    class Library
    {
        public string Name { get; set; }
        private Book[] books;
        public Library(string name)
        {
            Name = name;
            books = new Book[100];
        }

        public Book this[int index]
        {
            get 
            {
                try
                {
                    return books[index];
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set 
            {
                try
                {
                    books[index] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine($"{index}-ci index yoxdur");
                }
            }
        }

        //public void AddBook(int index,Book book)
        //{
        //    try
        //    {
        //        books[index] = book;
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine($"{index}-ci index yoxdur");
        //    }
        //}

        //public Book GetBook(int index)
        //{
        //    try
        //    {
        //        return books[index];
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public void ShowBooks()
        {
            foreach (Book item in books)
            {
                if(item!=null)
                    Console.WriteLine(item);
            }
        }
    }
    class Book
    {
        public string Name { get; set; }
        public Book(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    #endregion
}
