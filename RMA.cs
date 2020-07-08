using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest
{
    public partial class RMA : Form
    {
        public RMA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RMA 1 Form Button. Today is " + DateTime.Now.ToShortDateString() + "Hello, How are you?");
        }
    }
}
