using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaptureXML.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            CaptureXML.Service.HelloServiceClient client = new CaptureXML.Service.HelloServiceClient();

            labelResponse.Text = client.SayHello(textBoxName.Text);
        }
    }
}
