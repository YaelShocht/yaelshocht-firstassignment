using System;


//CR - where is your Program.cs file? this is the main .cs file from where we can run our program.

namespace ExeFirstCsharp
{
    internal class Car
    {
        private string Model { get; set; } 
        private int Speed { get;  set; }
      
        public Car(string model)
        {
            Model = model;
            Speed = 0;
        }

      



        public virtual void Accelerate(int accelerate)
        {
            Speed += accelerate;
        }

        public virtual void Decelerate(int decelerate)
        {
            Speed -= decelerate;
        }

        public void Stop()
        {
            Speed = 0;
        }

       

       

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Speed: {Speed}");
            

        } } } //CR - formatting (you should read about linting in C#)

     

