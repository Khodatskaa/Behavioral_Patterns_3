using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public interface IVisitor
    {
        void VisitTextElement(TextElement element);
        void VisitImageElement(ImageElement element);
        void VisitTableElement(TableElement element);
    }

    public class DocumentProcessor : IVisitor
    {
        public void VisitTextElement(TextElement element)
        {
            Console.WriteLine("Processing text element");
        }

        public void VisitImageElement(ImageElement element)
        {
            Console.WriteLine("Processing image element");
        }

        public void VisitTableElement(TableElement element)
        {
            Console.WriteLine("Processing table element");
        }
    }
}
