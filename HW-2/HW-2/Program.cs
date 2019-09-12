using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting variables up and instances of my class

            int age = 0;



            // establishing name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //establish age
            double accurateAge = age;
            accurateAge += 23;

            Console.WriteLine("Oh nice to meet you " + name + " my name is alex! How old are you?");
            age = Int32.Parse(Console.ReadLine());
            if (age < 20)
            {
                Console.WriteLine(age + " is the perfect age, still so much time to acheive great things.");
            }
            else if (age > 20)
            {
                Console.WriteLine("Youre getting old like me!");
            }


            Console.WriteLine("If we add our ages together we would be " + (age + accurateAge) + "! What is your favorite game?");
            string game = Console.ReadLine();

            Console.WriteLine("I also enjoy " + game + " , but if i had to choose, i think League of Legends would be my favorite!");








            //************************************** classes area *******************************
            
            Console.WriteLine("Lets play a little math game!");

            //setting up array for math game
            Questions[] myQuestions = new Questions[10];
            myQuestions[0] = new Questions("what is 2+2", 4);
            myQuestions[1] = new Questions("what is 4+4", 8);
            myQuestions[2] = new Questions("what is 2+4", 6);
            myQuestions[3] = new Questions("what is 5+6", 11);
            myQuestions[4] = new Questions("what is 5+5", 10);
            myQuestions[5] = new Questions("what is 2-2", 0);
            myQuestions[6] = new Questions("what is 6-3", 3);
            myQuestions[7] = new Questions("what is 2+10", 12);
            myQuestions[8] = new Questions("what is 12-6", 6);
            myQuestions[9] = new Questions("what is 5+7", 12);

            
         


            int numCorrect = 0;

            for (int i = 0; i < myQuestions.Length; i++)
            {
                Console.WriteLine(myQuestions[i].getQuestion());
               

                //user answer

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                //get actual answer
                int actualAnswer = myQuestions[i].getAnswer();
               
                
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
            Result myResult = new Result(name, numCorrect);
            Console.WriteLine("congratulations! " + myResult.getName() + " you got " + myResult.getScore() + " correct!");
            Console.ReadLine();
        }
    }
}
