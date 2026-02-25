using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        //prompt List
        List<string> reflectionPrompts = [
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        //Question List
        List<string> questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        List<string> listingPrompts = [
            "Who are the people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heros?"
        ];


        Timer myTimer = new Timer();

        //Simple menu
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Please select an activity:\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
            Console.Write(">");
            choice = int.Parse(Console.ReadLine());

            //Breathing Activity
            if (choice == 1)
            {
                // Initialize
                Breathing breathe = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                
                //Start and set duration
                Console.WriteLine(breathe.StartMessage());
                breathe.SetDuration();

                

                //Get Ready
                Console.WriteLine("Get Ready...");
                myTimer.PlayAnimation();
                Console.WriteLine();
                Console.WriteLine();

                //Start timer
                DateTime timeEnd = myTimer.StartTimer(breathe.GetDuration());

                //Continue activity until timer ends
                while (DateTime.Now < timeEnd)
                {
                    breathe.BreatheIn();
                    //Check timer in between breathsc
                    if (DateTime.Now >= timeEnd)
                    {
                        break;
                    }

                    breathe.BreatheOut();
                }

                Console.WriteLine(breathe.GetCloseMsg());
                myTimer.PlayAnimation();
                myTimer.PlayAnimation();
            }
            //Reflection Activity
            else if (choice == 2)
            {
                Reflection reflect = new Reflection(
                    "Reflection", 
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    reflectionPrompts, 
                    questions
                );
                //Start msg and set duration
                Console.WriteLine(reflect.StartMessage());
                reflect.SetDuration();
                
                //Get ready
                Console.WriteLine("Get Ready...");
                myTimer.PlayAnimation();
                Console.WriteLine();
                Console.WriteLine();

                //Prompt the user
                Console.WriteLine($"Consider the following prompt:\n\n{reflect.GetPrompt()}\n\nWhen you have something in mind, press enter to continue.");
                Console.ReadLine();

                //start the timer
                DateTime timeEnd = myTimer.StartTimer(reflect.GetDuration());

                //play activity
                Console.WriteLine("Now consider the following questions...\n");

                while (DateTime.Now < timeEnd)
                {
                    reflect.AskQuestion();
                }
                
                //end activity
                Console.WriteLine(reflect.GetCloseMsg());
                myTimer.PlayAnimation();
                myTimer.PlayAnimation();
            }
            //Listing Activity
            else if (choice == 3)
            {
                Listing listing = new Listing(
                    "Listing", 
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certian area.", 
                    listingPrompts
                );

                //Start msg and set the duration.
                Console.WriteLine(listing.StartMessage());
                listing.SetDuration();
                
                //Get Ready
                Console.WriteLine("Get Ready...");
                myTimer.PlayAnimation();
                Console.WriteLine();
                Console.WriteLine();

                //Provide the user with a prompt
                Console.WriteLine("List as many response as you can to the following prompt.");
                Console.WriteLine($"-----{listing.GetPrompt()}-----");

                //Think time for the prompt.
                Console.Write("You may begin in:   ");
                listing.ThinkTime();

                //Start the activity timer
                //  Explanation: Creates a new date time variable that holds the time the timer ends at. Use this variable to check in time has ended.
                DateTime timeEnd = myTimer.StartTimer(listing.GetDuration());

                //User lists answers until timer ends
                while (DateTime.Now < timeEnd)
                {
                    listing.SetAnswers();
                }
                
                //end activity
                Console.WriteLine($"You listed {listing.GetListCount()} items.\n\nWell done!");
                Console.WriteLine($"\n{listing.GetCloseMsg()}");
                myTimer.PlayAnimation();
                myTimer.PlayAnimation();
                
            }
            //Quit Program
            else if (choice == 4)
            {
                break;
            }
            //Edge cases (anything outside of 1, 2, 3, 4)
            else
            {
                Console.WriteLine("Please enter: 1, 2, 3, or 4.");
            }
        }
    }
}