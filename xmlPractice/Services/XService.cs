using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using QuizMaker.Model;

namespace QuizMaker.Services
{
    internal class XService
    {
        private readonly string _path;
        private XDocument _activeDoc;
        public XService(string path)
        {
            _path = path;
            if (!File.Exists(path))
            {
                var root = new XDocument(new XElement("Quiz"));
                root.Save(_path);
            }
            _activeDoc = XDocument.Load(path);
        }

        public List<QuizItem> GetQuizItems()
        {

            return _activeDoc.Root.Elements().Where(item => item.Name == "QuizItem").Select((qa) => new QuizItem(qa.Element("Question")!.Value,
                     qa.Element("Answer")!.Value)).ToList();

        }

        public void addItem(QuizItem item)
        {
            XElement t = new XElement("QuizItem", new XElement("Question", item.Question), new XElement("Answer", item.Answer));
            _activeDoc.Root.Add(t);
            _activeDoc.Save(_path);
        }
    }
}
