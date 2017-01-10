using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boom = this.Owner;
            //boom.thing++;
            boom.Text = "бебебе";

            boom.TabIndex = 1;
            //Text = stuff.ToString();
        }

        private int stuff;
    }
}
