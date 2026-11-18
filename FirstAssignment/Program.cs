namespace FirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Create a Book class with a Title
            //(string) and Pages (int). Create a Book
            //object and store it in a variable of type object.Print it.
            BOOK b1 = new BOOK();
            b1.title = "#C";
            b1.pages = 500;
            object obj = b1;
            Console.WriteLine(obj);
            #endregion

        }
    }
}
