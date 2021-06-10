using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    public class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        //Base- reference to the parent class
        // If the parent has parameters in its constructor,
        //The child must call base in it's own constructor to pass values up to the parent

     
        public VHS(string Title, Genre Category, int Runtime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            Console.WriteLine("You've picked a VHS");
            if (CurrentTime < Scenes.Count)
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }
            
        
        public override void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }

        }

        public void Rewind()
        {
            CurrentTime = 0;
            Console.WriteLine("You have rewinded you VHS!");
        }

    }

}
