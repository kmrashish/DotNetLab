using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing simple output on the console using the write line method of the console class
            /*Console.WriteLine("I just learnt how to configure my IDE");
            Console.WriteLine("Always wanted to keep my IDE background black, looks nice.. ;)");
            Console.WriteLine("This was taught to me in the first dot net class");

            //integer variable usage block
            int x, y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);

            //string variable usage block
            String myFirstName;
            myFirstName = "Ashish";
            string myLastName = "Kumar";
            Console.WriteLine(myFirstName+" "+myLastName);

            //use of the var keyword - simplifies the variable declaration problem and is for experienced developers
            var myName = "Ashish Kumar Baranwal";
            Console.WriteLine(myName);

            //an example of implicit data type conversion
            int a = 7;
            string myFirstTry = "usict dwarka";
            Console.WriteLine(a + myFirstTry);

            //an example of explicit data conversion from integer to string
            Console.WriteLine(a.ToString() + myFirstTry);

            //explicit data  conversion from string to integer
            string b="6";
            Console.WriteLine(a + int.Parse(b));*/

            Console.WriteLine("Please enter any value you want and press enter");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You entered: " + userValue);

            Console.WriteLine("Would you like to open the door number one, two or three? press the relevant number key!!");
            string userValue2 = Console.ReadLine();
            //string tempMsg;
            /*if (userValue2 == "1")
            {
                tempMsg="Congratulations One, you just won yourself a car!!";
            }
            else if (userValue2 == "2")
            {
                tempMsg = "Congratulations Two, you just won yourself a Transformer Truck!!";
            }
            else if (userValue2 == "3")
            {
                tempMsg = "Hey!! Aren't you three?? :O";
            }
            else
            {
                tempMsg = "We dont understand what you just entered.. you lose";
            }
            */

            string message = (userValue2 == "1") ? "boat" : "nothing man";

            
            Console.WriteLine("you won {0}!! and earlier to that you typed {1}" , message, userValue);
            Console.ReadLine();


            //waiting for the user to press any key!!
            //Console.ReadLine();
            //Console.ReadKey();


            
        }
    }
}
