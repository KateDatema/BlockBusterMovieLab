using System;
using System.Collections.Generic;
using System.Linq;


namespace Blockbuster_Movie_Lab
{
    class MainClass
    {
        static void Main(string[] args)


        {
            BlockBuster blockBuster = new BlockBuster();
            bool goOn = true;
            while (goOn == true)
            {

                Console.WriteLine("Welcome to GC Blockbuster!");

                Console.WriteLine("Please Select a Movie to check out from the list");

                Movie selected = blockBuster.CheckOut();

                Console.WriteLine("Do you want to watch this move?");

                string userInput = Console.ReadLine();


                if (userInput == "y")
                {

                    Console.WriteLine("press 1 to play the whole movie or press 2 to play a scene");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "1")
                    {
                        selected.PlayWholeMovie();
                        goOn = GetContinue();
                    }
                    else if (userInput2 == "2")
                    {
                        selected.Play();
                        goOn = GetContinue();
                    }

                    else
                    { goOn = GetContinue(); }



                }


            }
        }
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            //There are 3 cases we care about 
            //1) y - we want to continue 
            //2) n - we want to stop 
            //3) anything else - we want to try again

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                //Calling a method inside itself is called recursion
                //Think of this as just trying again 
                return GetContinue();
            }
        }
    }

}
