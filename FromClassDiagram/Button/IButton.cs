using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromClassDiagram.Button
{
    internal interface IButton
    {
        public void render();
        public void OnClick();
    }
}
