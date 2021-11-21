using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate_teaching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool action1(int x, int y)
        {
            return x + y == 5;
        }

        private bool action2(int x, int y)
        {
            return x + y == 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int market = 2;

            Dictionary<int, Func<int, int, bool>> data = new Dictionary<int, Func<int, int, bool>>
            {
                { 1, (x,y) => action1(1,2)},
                { 2, (x,y) => action1(x,4)},
            };

            //bool result = data[market](1, 0);
            data[3](0, 0);

            if (data.TryGetValue(2, out Func<int, int, bool> dealFunction))
            {
                dealFunction(0, 0);
            }
            else
            {
                int ihii = 1;
            }

            Application.Exit();
        }
    }
}