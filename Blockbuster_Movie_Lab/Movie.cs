using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blockbuster_Movie_Lab;

namespace Blockbuster_Movie_Lab
{


    public abstract class Movie
    {
        //This is the blue print, you say what needs to be set
        public string Title { get; set; } 
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        ////This is PUBLIC, you are declaring a contructor (which is a special METHOD that uses the new keyword to create a new object) 
        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;

        }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Run Time: {Runtime}");

        }

        public virtual void PrintScenes()
        {
            Console.WriteLine("Scenes:");
            foreach (string scene in Scenes)
            { Console.WriteLine(scene); }
        }

        public abstract void Play();

        public abstract void PlayWholeMovie();


    }

}
