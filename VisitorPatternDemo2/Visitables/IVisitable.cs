using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo2.Visitors;

namespace VisitorPatternDemo2.Visitables
{
    public interface IVisitable
    {
        void accept(IVisitor visitor);
    }
}
