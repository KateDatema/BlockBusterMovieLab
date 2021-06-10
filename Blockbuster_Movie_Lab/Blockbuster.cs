using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    public class BlockBuster
    {
        // we are setting declaring our variables, in this case we are creating a list
        public List<Movie> Movies { get; set; } = new List<Movie>();


        public BlockBuster()
        {
           
            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            DVD m1 = new DVD("Shrek", Genre.Comedy, 95, shrekScenes);
            Movies.Add(m1);

            List<string> legallyBlondeScences = new List<string>() { "the break up", "Applying to Havard", "Bend and snap", "Kicking but in court" };
            DVD m2 = new DVD("Legally Blonde", Genre.Drama, 97, legallyBlondeScences);
            Movies.Add(m2);

            List<string> findingNemo = new List<string>() { "Nemo gets lost", "Dad looks for Nemo", "Nemo is found" };
            DVD m3 = new DVD("Finding Nemo", Genre.Drama, 120, findingNemo);
            Movies.Add(m3);
                

            List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the Building", "JOhn Mclane sneaks arounds", "shoot out by the vault" };
            VHS v1 = new VHS("Die Hard", Genre.Action, 120, dieHardScenes);
            Movies.Add(v1);

            List<string> dalmatians = new List<string>() { "puppies are stolen", "Cruella tires to turn puppies into a fur coat", "puppies are saved" };
            VHS v2 = new VHS("101 Dalmatians", Genre.Horror, 120, dalmatians);
            Movies.Add(v2);

            List<string> peterPan = new List<string>() { "Meet Peter Pan", "Travel to the island", "kiddos miss their old life" };
            VHS v3 = new VHS("Peter Pan", Genre.Action, 125, peterPan);
            Movies.Add(v3);

        }
    
        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i} :{Movies[i].Title}"); 
                
            }
        }

        public Movie CheckOut()
        {
            Console.WriteLine("What movie would you like to check out?");
            PrintMovies();
            string input = Console.ReadLine();
            int userInput = int.Parse(input);

            Movies[userInput].PrintInfo();

            return Movies[userInput];

            //so we are trying to get the list name and then the index useing the input
            

        }

    }
}
