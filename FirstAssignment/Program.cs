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

            //BOOK b1 = new BOOK();
            //b1.title = "#C";
            //b1.pages = 500;

            //Console.WriteLine(b1.ToString());

            //Console.WriteLine(b1.Equals(b1));

            //Console.WriteLine(b1.GetHashCode());

            //Console.WriteLine(b1.GetType());

            #endregion


            #region Q3
            //Look at the line below. Is it a compile-time error,
            //a runtime error, or a logical error? Fix it.
            //int pages = "464";

            // the answer is : (compile-time error)

            //the correct code is :

            //int pages = 464;

            #endregion


            #region Q4
            //Write code that divides 10 by 0 inside a try block,
            //catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.

            //try {
            //    int x = 10;

            //    int y = 0;
            //    int sum = x / y;
            //    Console.WriteLine(sum);


            //}
            //catch (Exception ex) { Console.WriteLine("you cannot divide by zero"); }
            //finally { Console.WriteLine("done");}
            #endregion


            #region Q5
            //Declare an int pages = 300; then store
            //it in a double variable without using a cast.

            int pages = 300;
            double pageValue = pages;

            Console.WriteLine(pageValue);
            #endregion
        }
    }
}
