using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public interface IDocumentElement
    {
        void Accept(IVisitor visitor);
    }

    public class TextElement : IDocumentElement
    {
        public string Text { get; set; }

        public TextElement(string text)
        {
            Text = text;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTextElement(this);
        }
    }

    public class ImageElement : IDocumentElement
    {
        public string Url { get; set; }

        public ImageElement(string url)
        {
            Url = url;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitImageElement(this);
        }
    }

    public class TableElement : IDocumentElement
    {
        public List<List<string>> Rows { get; set; }

        public TableElement(List<List<string>> rows)
        {
            Rows = rows;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTableElement(this);
        }
    }
}
