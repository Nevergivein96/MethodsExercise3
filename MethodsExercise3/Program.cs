using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintThousand();
            //PrintByThree();
            //Console.WriteLine(IsEqual(4, 4));
            //Console.WriteLine(IsEqual2(5, 5));
            //Console.WriteLine(CheckOddEven(7));
            //Console.WriteLine(PositiveNegative(-5));
            //Console.WriteLine(VotingAge(23));
            //CheckRange();
           
            Console.WriteLine(Multiplication(32)); 

        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintByThree()
        {
            for (int three = 3; three <= 999; three += 3) 
            {
                Console.WriteLine(three);
            }
        }

        public static bool IsEqual2(int c, int d)
        {
            var check = c == d ? true : false;
            return check;
        }

        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;   
        }

        public static bool CheckOddEven(int a)
        {
            Console.WriteLine($"the number {a} is even");
            if(a%2 == 0)
            {
                return true;
            }
            return false;   
        }

        public static bool PositiveNegative(int a)
        {
            Console.WriteLine($"{a} is positive");
            if (a > 0) 
                return true;
            else
                return false;   
        }

        public static bool VotingAge(int age)
        {
            Console.WriteLine($"{age} is old enough to vote");
            if (age >= 18)
            {  
                return true;
            }
            return false;
        }

        public static void CheckRange()
        {
            Console.WriteLine("please enter a number between 10 and -10");
            var userInput=int.Parse(Console.ReadLine());
            var withinInstructions = userInput >= -10 && userInput <= 10 ? true : false;

            Console.WriteLine("you were able to follow instructions!!");
            Console.WriteLine(withinInstructions);
            //i could write an if statement here that would print differnt things based on the 
            //results but i am short on time and want to finish the next one))
        }

        public static string Multiplication(int num)
        {
            var answer = "";
       
            // The number your passing in is 32 //
            // The loop will run until i == 32 //
            for (int i = 1; i <= num; i++)
            {
           
                answer += $"{i} * {num} = {i * num}\n"; 
            
            }

            return answer; 
        }
        
    }
}