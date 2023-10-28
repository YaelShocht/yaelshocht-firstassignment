using System;


namespace ConsoleApp2
{
    internal class Task
    {
 
        public static bool CheackIsPrime(int number) 
        {
            bool isPrime = false; 

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                     
                }
            }

            return isPrime;
        }
       
        public static int MaxValue()
        {
            
            int max = 0;
            Console.WriteLine("הקש מספר");

            int x = int.Parse(Console.ReadLine());
            while (x > -1)
            {
              (x > max) ? x: max
                   
                Console.WriteLine("הקש מספר");
                
                x = int.TryParse(Console.ReadLine(), out int id);  
                //How do I check it?
            }
            return max;
        }
        //exe3
        static void PrintFibonacci(int n)
        {
            int first = 0, second = 1, next;

            Console.Write( first + ", " + second);

           while(i<n)
            {
                if (first + second > n)
                    break;
                next = first + second;
                Console.Write(", " + next);
                first = second;
                second = next;
            }

            
        }
        
        public static void ThirdMax()
        {
        
            
            int number, first = 0, second = 0, maxSum =first+second, currentSum = 0, third = 0, firstNumberHandler = 0, second2 = 0, third2 = 0; //CR - you don't have to use so much variables. A prominent sign for that is using first2, second2...
            
            Console.WriteLine("press number"); 
            
            number = int.TryParse(Console.ReadLine(), out int id);
            
        
            while (number != -1)
            {
                first = second;
                second = third;
                third = number;
                currentSum = first + second + third;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    first2 = first;
                    second2=second; 
                    third2 = third;

                }
                Console.WriteLine("press number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0},{1},{2}", first2, second2, third2);
            
        }
       
        
        //CR - the main should be in a different file
    static void Main(string[] args)
        {
             bool b = Cheack(11);
               Console.WriteLine(b);
             Console.WriteLine(MaxValue());
             PrintFibonacci(12);
             ThirdMax();
            
             Audi car1 = new Audi("AAA");
             Console.WriteLine(car1.Speed);
             Console.WriteLine("כמה ברצונך להאיץ?");
             int x=int.Parse(Console.ReadLine());
            car1.Accelerate(x);
              Console.WriteLine(car1.Speed);
             car1.PrintDetails();
             car1.Decelerate(2);
             car1.PrintDetails();
             car1.Stop();

             Lexus car2 = new Lexus("bbb");
            Console.WriteLine(car2.Speed);
             Console.WriteLine("כמה ברצונך להאיץ?");
            int x=int.Parse(Console.ReadLine());
            car2.Accelerate(x);
              car2.PrintDetails();
             car2.StartMusic();
              car2.Decelerate(2);
              car2.PrintDetails();
             car2.StopMusic();
            car2.Stop();



            Console.Read();
        }
    }
}
        
    

