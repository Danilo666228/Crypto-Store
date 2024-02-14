using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Crypto_Store
{
    public partial class Main : UserControl
    {
        Random rand = new Random();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            while (true)
            {

                lblPrice.Text = rand.Next(23000, 60000).ToString();
            }
        }
    }
}
