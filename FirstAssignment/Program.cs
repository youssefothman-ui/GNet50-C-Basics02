namespace FirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Create a Book class with a Title
            //(string) and Pages(int). Create a Book
            //object and store it in a variable of type object.Print it.
            //BOOK b1 = new BOOK();
            //b1.title = "#C";
            // b1.pages = 500;
            //object obj = b1;
            //Console.WriteLine(obj);
            #endregion


            #region Q2
            //Using the Book class above, print the result of
            //calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book.

            BOOK b1 = new BOOK();
            b1.title = "#C";
            b1.pages = 500;

            Console.WriteLine(b1.ToString());

            Console.WriteLine(b1.Equals(b1));

            Console.WriteLine(b1.GetHashCode());

            Console.WriteLine(b1.GetType());

            #endregion

        }
    }
}
