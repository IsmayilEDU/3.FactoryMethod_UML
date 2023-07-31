using FromClassDiagram.Button;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromClassDiagram.Dialog
{
    internal class HTMLDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}
