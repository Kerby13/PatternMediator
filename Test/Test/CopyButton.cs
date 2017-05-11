using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class CopyButton : ButtonClicking
    {
        public CopyButton(Mediator mediator)
            : base(mediator)
        {
            Text = "Copy";
        }
    }
}
