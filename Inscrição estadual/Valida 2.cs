using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Inscrição_estadual
{
    public partial class Valida_2 : Form
    {
        public Valida_2()
        {
            InitializeComponent();
        }
        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string vInsc, string vUF);

        private void btnValida_Click(object sender, EventArgs e)
        {
            try
            {
                lstResultado.Items.Clear();
                lblResultado.Text = "Resultado:";
                lblTotal.Text = "";
                string vIE = txtInsc.Text.Trim();
                int i;
                int vContTotal = 0;
                //Declaramos um Array separando os indices por virgula(,)

                string[] array = vIE.Split(',');
                for (i = 0; i != array.Length; i++)
                {
                    string vInd = array[i].ToString();
                    //Insere na variável o retorno da função que estamos utilizando (0= IE Válida 1= //IE Inválida)
                    int vReturn = ConsisteInscricaoEstadual(vInd, cbUF.SelectedItem.ToString());
                    //Insere registro no contador
                    vContTotal += 1;
                    string vStrRetorno;
                    if (vReturn == 0)
                    {
                        //Insere NºIE + IE Válida na ListBox
                        vStrRetorno = vInd + " - IE Válida ";
                        lstResultado.Items.Add(vStrRetorno.ToString());
                    }
                    else
                    {
                        //Insere NºIE + IE Inválida na ListBox
                        vStrRetorno = vInd + " - IE Inválida ";
                        lstResultado.Items.Add(vStrRetorno.ToString());
                    }
                    //Finaliza Contador e informa número de registro no ListBox
                    lblTotal.Text = "Total de Registros:" + vContTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            
        }
    }
}


