using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo2.Visitables
{
    public interface IVisitable
    {
        void accept(IVisitor visitor);
    }
}
