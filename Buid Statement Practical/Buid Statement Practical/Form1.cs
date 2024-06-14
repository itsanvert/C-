using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buid_Statement_Practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string store = "";
        private void btnOK_Click(object sender, EventArgs e)
        {

            store = "";

            int number = int.Parse(txtbstarNumber.Text);
            int i = 1;

            while (i <= number)
            {
                store = store + i + "+";
                i++;
            }

            txtbStore.Text = store;
        }
    }
}
