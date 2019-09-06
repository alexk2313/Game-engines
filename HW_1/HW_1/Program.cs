using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting variables up

            int age = 0;
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 10);
            
            // establishing name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //establish age
            double accurateAge = age;
            accurateAge += 23;
    
            Console.WriteLine("Oh nice to meet you " + name + " my name is alex! How old are you?");
            age = Int32.Parse(Console.ReadLine());
            if(age < 20)
            {
                Console.WriteLine(age + " is the perfect age, still so much time to acheive great things.");
            }
            else if(age > 20)
            {
                Console.WriteLine("Youre getting old like me!");
            }

            
            Console.WriteLine("If we add our ages together we would be " + (age + accurateAge) + "! What is your favorite game?");
            string game = Console.ReadLine();

            Console.WriteLine("I also enjoy " + game + " , but if i had to choose, i think League of Legends would be my favorite!");
            Console.WriteLine("Lets play a little math game with your age! Answer the questions in order.");

            //setting up array for math game
            int[] myNumbers = new int[10];
           
            for (int i = 0; i < myNumbers.Length; i++)
            {
                myNumbers[i] = i + randomNumber;
            }

            int numCorrect = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine("What is " + age + "+" + myNumbers[i] + "?");
                
                //user answer

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                //get actual answer
                int actualAnswer = age + myNumbers[i];
                //compare answers
                if (userAnswer == actualAnswer)
                {
                    Console.WriteLine("good job!");
                    numCorrect += 1;
                }
                else
                {
                    Console.WriteLine("That is not correct");
                }
            }
            Console.WriteLine("You got " + numCorrect + " out of 10 correct!");
            
            Console.ReadLine();
        }
    }
}
