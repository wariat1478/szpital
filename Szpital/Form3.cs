using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szpital
{
    public partial class Form3 : Form
    {
        public Form3(string id)
        {
            InitializeComponent();
            Dictionary<string, string> patient = DB.Instance.getPatient(id);
            name.Text = "Edycja karty pacjenta: "+patient["imie"]+" "+patient["nazwisko"];
            sala.Text = patient["sala"];
            rozpoznanie.Text = patient["rozpoznanie"];
            data_przyjecia.Text = patient["data_przyjecia"];
            data_wypisu.Text = patient["data_wypisu"];
        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }
      
        
    }
}
