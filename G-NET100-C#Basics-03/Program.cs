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


        }
    }
}
