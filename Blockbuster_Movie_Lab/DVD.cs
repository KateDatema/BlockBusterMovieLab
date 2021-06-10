using System;
using System.Collections.Generic;
using System.Linq;

namespace Blockbuster_Movie_Lab
{
    class DVD : Movie

    {
        //again making a special method that creates the object
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"You have selected a DVD! What scene would you like to watch? from {Title}");
            for (int i = 0; i < Scenes.Count(); i++)
            {
                Console.WriteLine(i);

            }
            string input = Console.ReadLine();
            int userInput = int.Parse(input);
            Console.WriteLine(Scenes[userInput]);

        }

        public override void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine(scene);
                i++;
            }

        }


    }


}

