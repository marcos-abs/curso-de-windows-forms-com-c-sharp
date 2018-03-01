using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win15 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            webBrowser1.DocumentText = "Olá Mundo <strong>HTML</strong><br/><br/><b>Este texto é negrito</b> este não é negrito.";
        }
    }
}
