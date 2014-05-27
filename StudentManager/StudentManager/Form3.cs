using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void message_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txtChat = (TextBox)sender;

            if ((txtChat.Lines.Length > 1) && (e.KeyCode == Keys.Enter))
            {
                //DB.Insert();
            }

        }
    }
}

      