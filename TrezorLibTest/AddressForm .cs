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
    public partial class AddressForm : Form
    {
        public string Address
        {
            set { addressTextBox.Text = value; }
        }

        public AddressForm()
        {
            InitializeComponent();
        }
    }
}
