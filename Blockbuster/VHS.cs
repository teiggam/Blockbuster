using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    
    public class VHS : IPlay
    {
        //We want current time to always start at 0
        public int CurrentTime { get; set; } = 0;

        public VHS() { }
 

        public void Rewind()
        {
            CurrentTime = 0;
        }

        public void Play(List<string> Scenes)
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }
        }
    }
}
