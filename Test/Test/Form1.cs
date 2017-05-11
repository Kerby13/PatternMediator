using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        static ManagerMediator mediator = new ManagerMediator();
        CopyButton cpbutton = new CopyButton(mediator);
        ClearButton clrbutton = new ClearButton(mediator);

        ListBox1 listbox1 = new ListBox1();
        ListBox2Class listbox2 = new ListBox2Class();


        public Form1()
        {
            InitializeComponent();
            mediator.ClearButton = clrbutton;
            mediator.CopyButton = cpbutton;
            mediator.lb2 = listbox2;
            cpbutton.Click += CopyButton_Click;
            clrbutton.Click += ClearButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listbox1.Location = new Point(122, 54);
            listbox1.Size = new Size(136, 356);
            Controls.Add(listbox1);

            listbox2.Location = new Point(366, 54);
            listbox2.Size = new Size(136, 356);
            Controls.Add(listbox2);

            cpbutton.Location = new Point(145, 422);
            cpbutton.Size = new Size(91, 42);
            Controls.Add(cpbutton);

            clrbutton.Location = new Point(390, 422);
            clrbutton.Size = new Size(91, 42);
            Controls.Add(clrbutton);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            mediator.Send(null, clrbutton);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            mediator.Send(listbox1.Items.Cast<String>().ToList(), cpbutton);
        }
    }
}
