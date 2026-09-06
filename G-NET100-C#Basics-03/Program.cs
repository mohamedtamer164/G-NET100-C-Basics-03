using System.Drawing;
using System.Dynamic;

namespace G_NET100_C_Basics_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Assignment 

            //1- Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object.Print it.
            #region object frist answer
            BOOK obj = new BOOK();
            obj.title = "The Great Gatsby";
            obj.pages = 180;
            Object obj2 = obj;

            Console.WriteLine(obj2);

            #endregion


            // 2-   Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            #region  OBJECT FUNCTOIN second answer
            Console.WriteLine(obj2.ToString());
            Console.WriteLine(obj2.Equals(obj2));
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine(obj2.GetType());
            #endregion
            // third aswer

            #region error  third answer
            // 3 
            //  int pages = "464";   is error this string not int 
            int pages = 464; // this is correct int type
            Console.WriteLine(pages);

            #endregion
            // fourth answer
            #region try /catch / finally  foreth answer
            // fourth answer
            int x = 0;

            try //  هنا انت بتجرب تقسم علي صفر ف هيطلع ايرور  Exception
            {
                int result = 10 / x;
            }
            catch // هنا عشان تقوله مينفعش اقسم علي صفر 
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally // هنا عشان تقوله مهما حصل في الكود اللي فوق سواء حصل ايرور او لا هيعمل اللي جوا ال finally
            {
                Console.WriteLine("Done");
            }
            #endregion


            // fifth answer
            #region implicit conversion  fifth answer
            int pages2 = 300;

            double pagesDouble = pages2;

            Console.WriteLine(pagesDouble);
            #endregion

            // sixth answer
            #region   sixth answer
            double price = 49.99;

            int priceInt = (int)price;

            Console.WriteLine(priceInt);

            #endregion

            // seventh answer
            #region seventh answer
            string pages3Text = "464";

            int pages3 = Convert.ToInt32(pages3Text);

            Console.WriteLine(pages3);
            #endregion

            //Eighth answer
            #region eighth answer
            string yearText = "2023";

            int year = int.Parse(yearText);

            Console.WriteLine(year);


            string badText = "abc";

            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion
            // ninth answer
            #region ninth answer
            int pages4 = 464;

            string pages4Text = pages4.ToString();

            Console.WriteLine(pages4Text);
            Console.WriteLine(pages4Text.GetType());

            #endregion
            // tenth answer
            #region tenth answer
            int copies = 100;

            object obj3 = copies;   // Boxing

            int newCopies = (int)obj3;   // Unboxing

            Console.WriteLine(copies);
            Console.WriteLine(newCopies);
            #endregion 
        }
    }
}
