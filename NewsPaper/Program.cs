using NewsPaper.Constants;
using NewsPaper.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsPaperContext newsPaperContext = new NewsPaperContext();
            Console.WriteLine("Welcome To the Newspaper Application");

            while (true)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("Enter Your Command");
                string input = Console.ReadLine();
                string [] splittedInput = input.Split(' ');
                string inputCommand = splittedInput[0];
                switch (inputCommand.Trim().ToLowerInvariant())
                {
                    case Commands.PRINT_INFO:
                        {
                            newsPaperContext.PrintInfo();
                            break;
                        }
                    case Commands.ADD_Q:
                        {
                            newsPaperContext.AddQ();
                            break;
                        }
                    case Commands.REMOVE_Q:
                        {
                            newsPaperContext.RemoveQ();
                            break;
                        }
                    case Commands.ADD_STAR:
                        {
                            newsPaperContext.AddStar();
                            break;
                        }
                    case Commands.REMOVE_STAR:
                        {
                            newsPaperContext.RemoveStar();
                            break;
                        }
                    case Commands.CREATE_MODEL:
                        {
                            newsPaperContext.CreateModel(splittedInput[1], splittedInput[2]);
                            break;
                        }
                    case Commands.CREATE_CHARACTER:
                        {
                            newsPaperContext.CreateCharacter(splittedInput[1], splittedInput[2]
                                , splittedInput[3], (GenderType)Enum.Parse(typeof(GenderType), splittedInput[4]));
                            break;
                        }
                    case Commands.SUBSCRIBE:
                        {
                            newsPaperContext.Subscribe(splittedInput[1], int.Parse(splittedInput[2]));
                            break;
                        }
                    case Commands.GET_EDITING_PROGRESS:
                        {
                            newsPaperContext.GetEditingProgress(splittedInput[1]);
                            break;
                        }
                    case Commands.START_PRINTING:
                        {
                            newsPaperContext.StartPrinting(splittedInput[1]);
                            break;
                        }
                    case Commands.GET_PRINTING_PROGRESS:
                        {
                            newsPaperContext.GetPrintingProgress(splittedInput[1]);
                            break;
                        }
                    case Commands.START_PUBLISHING:
                        {
                            newsPaperContext.StartPublishing(splittedInput[1]);
                            break;
                        }
                    case Commands.PUBLISH:
                        {
                            newsPaperContext.Publish(splittedInput[1],splittedInput[2]);
                            break;
                        }
                    case Commands.SET_PUBLISHING_METHOD:
                        {
                            newsPaperContext.SetPublishingMode(splittedInput[1],splittedInput[2]);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
