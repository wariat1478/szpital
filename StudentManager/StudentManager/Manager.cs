using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public class Manager
    {
        public DB DB;
        public Dictionary<string, string> Session = new Dictionary<string, string>(); 

        public Manager()
        {
            this.DB = new DB();

            Form f1 = new Form1(this);
            f1.Show();
        }
    }
}
