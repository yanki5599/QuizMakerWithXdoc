using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuizMaker.Model
{
    internal class QuizItem
    {
       
        public string Question { get; set; }

        public string Answer { get; set; }

        public QuizItem(string q, string ans)
        {
            Question = q;
            Answer = ans;
        }

        public QuizItem() { }

        public override string ToString()
        {
            return $"q: {Question}\nans: {Answer}";
        }
    }
}
