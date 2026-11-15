
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Books book1 = new Books();
            book1.title = "Title";
            book1.pages = 5;
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.pages);
            if (book1.Equals(book1) == book1.Equals(book1))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine(book1.ToString());

            Console.WriteLine(book1.GetType());

            //logical error
            int pages1 = 464;
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally { Console.WriteLine("Done"); }
            int pages2 = 400;
            double pages3 = pages2;
            double price = 49.99;
            int priceint = Convert.ToInt32(price);
            Console.WriteLine(priceint);
            string pricestring = "494";
            int priceint2 = Convert.ToInt32(pricestring);
            Console.WriteLine(priceint2);
            string yearText = "2023";
            int yearint = int.Parse(yearText);
            Console.WriteLine(yearint);
            string badText = "abc";
            bool result = int.TryParse(badText, out int badint);
            if (result == false)
            {
                Console.WriteLine("Invalid Number");
            }
            Console.WriteLine(pages1.ToString());

            Console.WriteLine(pages1.GetType());
            object obj = 100;

            int j = (int)obj;
            Console.WriteLine(j);
            
                int?year = null;
           
      
           
           
                Console.WriteLine("it doesn't have a value");

           
           

                year = 2023;
            Console.WriteLine(year);
            string reviewer = null;
            Console.WriteLine("it's a null");
            Books book2 = null;
            try
            {
                Console.WriteLine(book2.title);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("It's a null reference exception");
            }
            finally
            {
                book2 = new Books(); 
                book2.title = "Untitle";

                Console.WriteLine(book2.title);
            }
            string name = "Ahmed";

            string confirmedName = name;
        }
        class Books
        {
            public String title;
            public int pages;
            public override string ToString()
            {
                return $"title:{title},pages:{pages}";
            }
       
        }
    }
}
