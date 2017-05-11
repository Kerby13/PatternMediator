using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class ManagerMediator : Mediator
    {
        public ListBox2Class lb2 { get; set; }
        public ButtonClicking CopyButton { get; set; }
        public ButtonClicking ClearButton { get; set; }
        public override void Send(List<string> msg, ButtonClicking button)
        {
            if (CopyButton == button)
            {
                lb2.Notify(msg);
            }
            else if (ClearButton == button)
            {
                lb2.Notify(null);
            }
        }
    }
}
