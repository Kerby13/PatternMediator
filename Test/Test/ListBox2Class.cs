using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class ListBox2Class : ListBox
    {
        public ListBox2Class()
        { }

        public void Notify(List<string> message)
        {
            if (message != null)
                foreach (string m in message)
                    Items.Add(m);
            else
            {
                while (Items.Count != 0)
                {
                    Items.RemoveAt(0);
                }
            }
        }
    }
}
