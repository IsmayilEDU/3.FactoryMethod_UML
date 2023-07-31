using FromClassDiagram.Button;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromClassDiagram.Dialog
{
    internal abstract class Dialog
    {
        IButton button;

        public abstract IButton CreateButton();
    }
}
