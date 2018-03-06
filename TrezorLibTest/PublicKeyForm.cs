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
    public partial class PublicKeyForm : Form
    {
        public string PublicKey
        {
            set { publicKeyTextBox.Text = value; }
        }

        public PublicKeyForm()
        {
            InitializeComponent();
        }
    }
}
