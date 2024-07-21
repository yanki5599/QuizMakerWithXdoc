
using QuizMaker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class Controller
    {
        XService _xservice;
        QuizWriter quizWriter;
        QuizReader quizReader;

        public Controller()
        {
            _xservice = new XService(".\\data.xml");
            quizWriter = new QuizWriter(_xservice);
            quizReader = new QuizReader(_xservice);
        }


        public void Run()
        {
            while (true)
            {
                PrintMenu();
                string userChoice = Console.ReadLine();
                if (userChoice != null)
                    RunChoice(userChoice);

            }
        }

        private void RunChoice(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    quizWriter.RunMenu();
                    break;
                case "2":
                    quizReader.RunMenu();
                    break;
                default: 
                    Console.WriteLine("invlid choice");
                    break;
            }
        }

        private void PrintMenu()
        {
            const string menu = "1. Create questions\n2. Answer Questions";

            Console.WriteLine(menu);
        }
    }
}
