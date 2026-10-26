using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelegatesCodeRealise
    {
        delegate void MessageDelegate(string message);

        delegate int CalculateDelegate(int a, int b);

        public static void RunLauncher()
        {
            Action sayHello = SayHello;
            sayHello();

            void SayHello()
            {
                Console.WriteLine("Hello");
            }

            MessageDelegate messageDelegate = ShowMessage;
            // CalculateDelegate addDelegate = Add;
            Func<int, int, int> addDelegate = Sum;
            messageDelegate("C# is the Best!!!");
            int sum = addDelegate(5, 6);
            Console.WriteLine(sum);


            Action notify = FirstMessage;
            notify += SecondMessage;
            notify += ThirdMessage;

            notify();

            notify -= SecondMessage;
            notify();

            Func<double, double, double> operation = Add;
            Console.WriteLine($"Add: {operation(20, 5)}");
            operation = Mult;
            Console.WriteLine($"Mult: {operation(20, 5)}");
            operation = Sub;
            Console.WriteLine($"Sub: {operation(20, 5)}");
            operation = Div;
            Console.WriteLine($"Div: {operation(20, 5)}");

            operation = Add;
            Console.WriteLine(operation(20, 5));
            operation += Sub;
            Console.WriteLine(operation(20, 5));
            operation += Div;
            Console.WriteLine(operation(20, 5));
            operation += Mult;
            Console.WriteLine(operation(20, 5));

            //----------------------------------- METHODS --------------------------------------
            static void ShowMessage(string message)
            {
                Console.WriteLine(message);
            }



            int Sum(int a, int b)
            {
                return a + b;
            }

            double Add(double a, double b)
            { return a + b; }

            double Sub(double a, double b)
            {
                return a - b;
            }

            double Mult(double a, double b)
            { return a * b; }

            double Div(double a, double b)
            { return a / b; }

            static void FirstMessage()
            {
                Console.WriteLine("First");
            }

            static void SecondMessage()
            {
                Console.WriteLine("Second");
            }

            static void ThirdMessage()
            {
                Console.WriteLine("Third");
            }
        }
        }
}
