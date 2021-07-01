using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 6, 7, 8, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Recursive Function for Fibonacci Calculator."
                    + "\n6. Iteration Function for Fibonacci Calculator."
                    + "\n7. Recursive Even Function."
                    + "\n8. Iteration Even Function."
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input !!
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        RecursiveFunction();
                        break;
                    case '6':
                        IterationFunction();
                        break;
                    case '7':
                        RecursiveEven();
                        break;
                    case '8':
                        IterationEven();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7, 8)");
                        break;
                }
            }
        }
        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            List<string> theList = new List<string>();//Creae list for adding user input
            bool result = true;
            do
            {
                Console.WriteLine("For adding name to the list  write '+' with the name  ex:'+Adam' or '-' for  removing '-Adam' :");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                //cheack if user want to add new name to the list or remove name  
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    default:
                        Console.WriteLine("Please enter  valid input !!");
                        Console.WriteLine();
                        break;
                }
                //Display current name list 
                Console.WriteLine("\nCurrent List :");
                foreach (var item in theList)
                    Console.WriteLine(item.ToString());
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For adding or removing another name press 1 or 0 for main menu?");
            } while (result);

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> thequeue = new Queue<string>();//create queue for user input
            bool result = true;
            do
            {
                Console.WriteLine("--------- ICA kön till kassan----------");
                Console.WriteLine("For Enqueueing name to the queue  press '1'  or '2' for  Dequeueing :");
                string nav = Console.ReadLine();
                //cheack if user want to add new name to the list or remove name  
                switch (nav)
                {
                    case "1":
                        //add new name in queue
                        Console.WriteLine("\nEnter the name:");
                        string value = Console.ReadLine();
                        thequeue.Enqueue(value);
                        break;
                    case "2":
                        //remove first name in the queue
                        thequeue.Dequeue();
                        break;
                    default:
                        Console.WriteLine("\nPlease enter  valid input !!");
                        break;
                }
                //Display current queue 
                Console.WriteLine("\nCurrent Queue :");
                foreach (var item in thequeue)
                {
                    Console.WriteLine(item.ToString());
                }
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For Enqueueing or Dequeueing another name press 1 or 0 for main menu?");
            } while (result);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> thestack = new Stack<string>();
            bool result = true;
            do
            {
                Console.WriteLine("----------Reversing Text----------");
                Console.WriteLine("Enter the Text :");
                string Text = Console.ReadLine();//read user text
                if (string.IsNullOrWhiteSpace(Text))
                {
                    Console.WriteLine("\nPlease enter  valid text !!");
                }
                else
                {
                    // Iterate on input string to push each char into stack
                    for (int i = 0; i < Text.Length; i++)
                    {
                        thestack.Push(Text.Substring(i, 1));//Divide  input string to char
                    }
                }
                Console.WriteLine("\n Reversing Text :");
                string Rev_Text = null;
                //Iterate through the stack to reverse the input string
                //(stack already reverse the text because in the stack last in first out)
                foreach (var item in thestack)
                    Rev_Text += item.ToString();
                //Display the reverse text
                Console.WriteLine(Rev_Text);
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For Reverse another Text press 1 or 0 for main menu?");
            } while (result);
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            bool result = true;
            do
            {
                Console.WriteLine("---------- Check Parantheses ----------");
                Console.WriteLine("Enter the Text :");
                string Text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Text))
                {
                    Console.WriteLine("\nPlease enter  valid text !!");
                }
                else
                {
                    bool Check_Balanced = true;
                    Stack<char> brackets = new Stack<char>();
                    Dictionary<char, char> bracket_Pairs = new Dictionary<char, char>() {
                        { '(', ')' },
                        { '{', '}' },
                        { '[', ']' },
                        { '<', '>' }
                    };
                    try
                    {
                        // Iterate through each character in the input string
                        foreach (char chr in Text)
                        {
                            // check if the character is one of the 'opening' brackets
                            if (bracket_Pairs.Keys.Contains(chr))
                            {
                                // if yes, push to stack
                                brackets.Push(chr);
                            }
                            else
                            // check if the character is one of the 'closing' brackets
                            if (bracket_Pairs.Values.Contains(chr))
                            {
                                // check if the closing bracket matches the 'latest' 'opening' bracket
                                if (brackets.Any() && chr == bracket_Pairs[brackets.First()])
                                {
                                    brackets.Pop();
                                }
                                else
                                {
                                    // if not, its an unbalanced string
                                    Check_Balanced = false;
                                    break;
                                }
                            }
                            else
                                // continue looking
                                continue;
                        }
                    }
                    catch
                    {
                        // an exception will be caught in case a closing bracket is found, before any opening bracket.
                        // that implies, the string is not balanced. Return false
                        Check_Balanced = false;
                    }

                    // Ensure all brackets are closed
                    if (brackets.Count() == 0 && Check_Balanced != false)
                        Check_Balanced = true;
                    else
                        Check_Balanced = false;
                    Console.WriteLine($"\nThe text is { (Check_Balanced ? string.Empty : "not ")}well-formed.");

                }
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For Checking another Text press 1 or 0 for main menu?");
            } while (result);
        }

        //Method for Ask the user for trying again or back to the main menu
        private static bool RepeateMethod(string Message)
        {
            Console.WriteLine("\n" + Message);
            string answer = Console.ReadLine();
            if (answer == "1")
                return true;
            else if (answer == "0")
            {
                Main();
                return false;
            }
            else
            {
                Console.WriteLine("\nPlease enter  valid text !!");
                return true;
            }
        }

        static void RecursiveFunction()
        {
            bool result = true;
            do
            {
                Console.WriteLine("---------- Recursive Function for Fibonacci Calculator----------");
                Console.WriteLine("Enter the Length of  Fibonacci series:");
                string Text = Console.ReadLine();// Read the length of Fibonacci series
                bool Chck_number = int.TryParse(Text, out int number);
                if (string.IsNullOrWhiteSpace(Text) || Chck_number == false)
                {
                    Console.WriteLine("\nPlease enter  valid number !!");
                }
                else
                {
                    for (int i = 0; i < number; i++)//Iterate to calculate Fibonacci Series
                    {
                        Console.Write("{0} ", RecursiveFunction(i).ToString());
                    }
                }
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For trying Iteration Function for Fibonacci Calculator again press 1 or 0 for main menu?");
            } while (result);
        }
        static int RecursiveFunction(int n)
        {
            if (n == 0)
                return 0;// First number in series
            if (n == 1)
                return 1;// Second number in series
            return (RecursiveFunction(n - 1) + RecursiveFunction(n - 2));// Continue to calculate numbers of series
        }
        static void IterationFunction()
        {
            bool result = true;
            do
            {
                Console.WriteLine("---------- Iteration Function for Fibonacci Calculator----------");
                Console.WriteLine("Enter the Length of Fibonacci series:");
                string Text = Console.ReadLine();// Read the length of Fibonacci series
                bool Chck_number = int.TryParse(Text, out int number);
                if (string.IsNullOrWhiteSpace(Text) || Chck_number == false)
                {
                    Console.WriteLine("\nPlease enter  valid number !!");
                }
                else
                {
                    for (int i = 0; i < number; i++)//Iterate to calculate Fibonacci Series
                    {
                        Console.Write("{0} ", IterationFunction(i).ToString());
                    }
                }
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For trying  Iteration Function for Fibonacci Calculator again press 1 or 0 for main menu?");
            } while (result);
        }
        static int IterationFunction(int n)
        {
            int Result = 0;
            int FirstNumber = 0;
            int SecondNumber = 1;
            if (n == 0)
                return 0;// First number in series
            if (n == 1)
                return 1;// Second number in series

            for (int i = 2; i <= n; i++)// Continue to calculate numbers of series
            {
                Result = FirstNumber + SecondNumber;
                FirstNumber = SecondNumber;
                SecondNumber = Result;
            }
            return Result;
        }
        private static void RecursiveEven()
        {
            bool result = true;
            do
            {
                Console.WriteLine("---------- Recursive Even Function----------");
                Console.WriteLine("Enter the length of even series:");
                string Text = Console.ReadLine();// Read the length of Even series
                bool Chck_number = int.TryParse(Text, out int number);
                if (string.IsNullOrWhiteSpace(Text) || Chck_number == false)
                {
                    Console.WriteLine("\nPlease enter  valid number !!");
                }
                else
                {
                    for (int i = 0; i < number; i++)//Iterate to calculate Even Series
                    {
                        Console.Write("{0} ", RecursiveEven(i).ToString());
                    }
                }
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For trying Recursive Even Function again press 1 or 0 for main menu?");
            } while (result);
        }

         static int RecursiveEven(int n)
        {
            if (n == 0)
                return 0;// First number in series
            if (n == 1)
                return 2;// Second number in series
            return (RecursiveEven(n - 1)+2 );// Continue to calculate numbers of series
        }
         static void IterationEven()
        {
            bool result = true;
            do
            {
                Console.WriteLine("---------- Iteration Even Function ----------");
                Console.WriteLine("Enter the length of even series :");
                string Text = Console.ReadLine();// Read the length of Even series
                bool Chck_number = int.TryParse(Text, out int number);
                if (string.IsNullOrWhiteSpace(Text) || Chck_number == false)
                {
                    Console.WriteLine("\nPlease enter  valid number !!");
                }
                else
                {
                    for (int i = 0; i < number; i++)//Iterate to calculate Even Series
                    {
                        Console.Write("{0} ", IterationEven(i).ToString());
                    }
                }
                //Ask the user for trying again or back to the main menu
                result = RepeateMethod("For trying  Iteration Even Function again press 1 or 0 for main menu?");
            } while (result);
        }
         static object IterationEven(int n)
        {
            int Result = 0;
            if (n == 0)
                return 0;// First number in series

            for (int i = 1; i <= n; i++)// Continue to calculate numbers of series
            {
                Result += 2;
            }
            return Result;
        }
    }
}

