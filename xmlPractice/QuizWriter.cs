﻿using QuizMaker.Services;

namespace QuizMaker
{
    internal class QuizWriter
    {

        private XService _xMLService;

        public QuizWriter(XService xMLService)
        {
            this._xMLService = xMLService;
        }

        internal void RunMenu()
        {
            while (true)
            {
                Console.WriteLine("=======================");
                string q = Utils.ReadFromUser("Write a question: ");
                //maybe check if question already exist.
                string ans = Utils.ReadFromUser("Write the answer: ");
               
                SaveToXml(q, ans);
            }
        }

       

        private void SaveToXml(string q, string ans)
        {
            _xMLService.addItem(new Model.QuizItem(q, ans));
        }
    }
}