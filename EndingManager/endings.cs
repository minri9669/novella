using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.EndingManager.EndingUsee;

namespace project
{
    public partial class endings : Form
    {
        EndingUse eu = new EndingUse();
        public endings()
        {
            InitializeComponent();
            //Unlocking("Концовка А"); <- пример как открывать концовки. Для тех, кто мейн будет писать
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = eu.ShowAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = eu.ShowAllUnlocked();
        }

        public void Unlocking(string a)
        {
            eu.Unlocking(a);
        }
    }
}
