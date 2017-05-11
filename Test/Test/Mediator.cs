using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    abstract class Mediator
    {
        public abstract void Send(List<string> msg, ButtonClicking colleague);
    }
}
