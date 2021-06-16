using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
   public class Movie
    {

        public IPlay PlayMovie { get; set; }
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(IPlay PlayMovie, string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
            this.PlayMovie = PlayMovie;

        }

       public void Play(List<string> Scenes)
        {
            //It's the job of the PlayMovie variable to decide how the movie is played

            PlayMovie.Play(Scenes);
            
        }
        
        
        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: "+ Category);
            Console.WriteLine("Run Time: "+ Runtime);
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            foreach(string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }

        public virtual void PlayWholeMovie()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}:{scene}");
            }
        }
    }
}
