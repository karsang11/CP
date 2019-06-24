using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first;
            int second;
            int result;
            result = 0;

            first = int.Parse(txtf.Text);
            second = int.Parse(txts.Text);
            arithmetic Arithmetic = new arithmetic(first, second);
            if (rbadd.Checked == true)
            {
                result = Arithmetic.add();
            }
            else if (rbsub.Checked==true)
            {
                result = Arithmetic.sub();
            }
            else if (rbmulti.Checked==true)
            {
                result = Arithmetic.multi();

            }
            else if (rbdiv.Checked==true)
            {
                result = Arithmetic.div();
            }
            else
            {
                MessageBox.Show("please select a button");
            }
                
            MessageBox.Show($"sum :{result}");
        }
    }
}
