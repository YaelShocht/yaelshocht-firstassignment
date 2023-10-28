using System;

namespace ExeFirstCsharp
{
    internal class Lexus:Car
    {
    privat bool IsPlayingMusic;
        
        public Lexus(string model): base(model) {
            IsPlayingMusic = false;
        }
        public void StartMusic()
        {
            IsPlayingMusic = true;
        }

        public void StopMusic()
        {
            IsPlayingMusic = false;
        }
        public override void PrintDetails() 
        {
            base.PrintDetails();
          
        }

    }
}
