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
    public partial class Main : Form
    {
        TrezorLib.Manager _trezor;

        public Main()
        {
            InitializeComponent();

            statusStrip1.BackColor = Color.Red;
            _trezor = new TrezorLib.Manager();

            _trezor.Attached += _trezor_Attached;
            _trezor.Detached += _trezor_Detached;
            _trezor.PinRequest += _trezor_PinRequest;
            _trezor.PassphraseRequest += _trezor_PassphraseRequest;
            _trezor.PublicKey += _trezor_PublicKey;
            _trezor.Address += _trezor_Address;
            _trezor.Failure += _trezor_Failure;
        }
        
        private void AddListBox(string text)
        {
            this.Invoke((MethodInvoker)(() => logListBox.Items.Insert(0, text)));
        }

        private void _trezor_Failure(object sender, TrezorLib.FailureEventArgs e)
        {
            AddListBox(e.Type.ToString());
        }

        private void _trezor_PublicKey(object sender, TrezorLib.PublicKey e)
        {
            AddListBox("Public Key response");

            PublicKeyForm form = new PublicKeyForm();
            form.PublicKey = e.Xpub;
            form.ShowDialog(this);
        }

        private void _trezor_Address(object sender, TrezorLib.Address e)
        {
            AddListBox("Address response");

            AddressForm form = new AddressForm();
            form.Address = e.address;
            form.ShowDialog(this);
        }

        private void _trezor_PassphraseRequest(object sender, EventArgs e)
        {
            AddListBox("Passphrase requested");

            PassphraseForm passphraseForm = new PassphraseForm();
            if (passphraseForm.ShowDialog() == DialogResult.OK)
                _trezor.SendPassphraseAck(passphraseForm.Passphrase);
        }

        private void _trezor_PinRequest(object sender, EventArgs e)
        {
            AddListBox("Pin requested");

            PinPadForm pinPad = new PinPadForm();
            if (pinPad.ShowDialog(this) == DialogResult.OK)
                _trezor.SendPinMatrixAck(pinPad.Pin);
        }

        private void _trezor_Detached(object sender, EventArgs e)
        {
            AddListBox("Device Detached");
            SetControls();
        }

        private void _trezor_Attached(object sender, EventArgs e)
        {
            AddListBox("Device Attached");
            SetControls();
        }

        private void initializeMenuItem_Click(object sender, EventArgs e)
        {
            var features = _trezor.Initialize();

            AddListBox(string.Format("Device Initialized: {0}", features.Label));
        }

        private void getPubKeyMenuItem_Click(object sender, EventArgs e)
        {
            _trezor.RequestPublicKey();
        }

        private void SetControls()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                if (_trezor.IsConnected)
                    statusStrip1.BackColor = Color.Green;
                else
                    statusStrip1.BackColor = Color.Red;


                initializeMenuItem.Enabled = _trezor.IsConnected;
                getPubKeyMenuItem.Enabled = _trezor.IsConnected;
            }
            ));
        }

        private void getAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trezor.RequestAddress();
        }
    }
}
