using System;
using System.Collections.Generic;
using System.Text;


namespace Blockbuster
{
    class BlockBusterVideo
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //You may only initialize values, but you may call any methods outside of another method
        //Movies.Add(new VHS("Die Hard", Genre.Action, 120, dieHardScenes));

        //Directly in a class, you may only declare and initalize properties and declare methods/constructors

        public BlockBusterVideo()
        {
            //Need to initialize an instance of a DVD to put the DVD play
            DVD d1 = new DVD();
            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            Movie d = new Movie(d1, "Shrek", Genre.Drama, 120, shrekScenes);
            List<string> meanGirls = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };
            Movie d2 = new Movie(d1, "Mean Girls", Genre.Comedy, 133, meanGirls);


            VHS v1 = new VHS();
            List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the building", "John McLane sneaks around", "Shoot out by the vault" };
            Movie v = new Movie(v1, "Die Hard", Genre.Action, 120, dieHardScenes);
            List<string> lordOfTheRingsScenes = new List<string>() { "Hobbiton", "Fireworks", "Mines of Moria", "Orcs attack" };
            Movie v2 = new Movie(v1, "Fellowship of the Ring", Genre.Drama, 225, lordOfTheRingsScenes);


            Movies.Add(v);
            Movies.Add(v2);
            Movies.Add(d);
            Movies.Add(d2);
        }
        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            return m;
        }

        public void PrintAllMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                string title = m.Title;
                Console.WriteLine($"{i}: {title}");
            }
        }
        public void Checkout()
        {
            Console.WriteLine($"What movie would you like to watch? 0 to {Movies.Count -1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie m = GetMovie(index);

            //Switched from PlayWholeMovie to play, so DVD and VHS Play(); functionality would present.
            m.Play(m.Scenes);
        }
    }
}
