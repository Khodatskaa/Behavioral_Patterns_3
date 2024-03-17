using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Behavioral_Patterns_3
{
    public class Document
    {
        private List<IDocumentElement> _elements = new List<IDocumentElement>();

        public void Attach(IDocumentElement element)
        {
            _elements.Add(element);
        }

        public void Detach(IDocumentElement element)
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}