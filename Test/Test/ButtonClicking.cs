using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    abstract class ButtonClicking : Button
    {
        protected Mediator mediator;

        public ButtonClicking(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(List<string> message)
        {
            mediator.Send(message, this);
        }
    }
}
