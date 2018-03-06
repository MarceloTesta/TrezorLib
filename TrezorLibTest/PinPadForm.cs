using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrezorLibTest
{
    public partial class PinPadForm : Form
    {
        public string Pin
        {
            get { return pintextBox.Text; }
        }

        public PinPadForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            pintextBox.Text += (sender as Button).Tag.ToString();
        }
    }
}
