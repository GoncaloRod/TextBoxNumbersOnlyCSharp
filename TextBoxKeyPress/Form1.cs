using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxKeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Dados
            long n;
            TextBox txt = (TextBox)sender;
            if ((!long.TryParse(e.KeyChar.ToString(), out n)) && (!(e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = true;
            }
        }
    }
}
