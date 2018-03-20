using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscrição_estadual
{
    public partial class Valida3 : Form
    {
        public Valida3()
        {
            InitializeComponent();
        }
        ValidaIE IE = new ValidaIE();

        private void btnValidar_Click(object sender, EventArgs e)
        {
            IE.retorno("RS", "860316734");
            

        }
    }
}
