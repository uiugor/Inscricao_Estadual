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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string vInsc, string vUF);
        
        private void btnValida_Click(object sender, EventArgs e)
        {
            try
            {
                string vIE = txtInscricao.Text.Trim();
                int i;
                //Declaramos um Array separando os indices por virgula(,)
                string[] array = vIE.Split(',');

                //Buscamos os indices com For
                for (i = 0; i != array.Length; i++)
                {
                    string vInd = array[i].ToString();
                    //Insere na variável o retorno da função que estamos utilizando (0= IE Válida 1= //IE Inválida)
                    int vReturn = ConsisteInscricaoEstadual(vInd, cbUF.SelectedItem.ToString()); //cbUF.SelectedValue
                    string vStrRetorno;

                    if (vReturn == 0)
                    {
                        //Exibe mensagem caso a Inscrição for Válida (IE + UF)
                        MessageBox.Show(vStrRetorno = vInd + " - " + cbUF.SelectedItem.ToString() + ": Inscrição Válida", "Inscrição Válida",MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Exibe mensagem caso a Inscrição for Inválida (IE + UF)
                        MessageBox.Show(vStrRetorno = vInd + " - " + cbUF.SelectedItem.ToString() + ": Inscrição Inválida", "Inscrição Inválida",MessageBoxButtons.OK);
                    }
                    //lblTotal.Text = vContTotal.ToString();
                }

                txtInscricao.Text = "";
                cbUF.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtInscricao.Text = "";
            cbUF.SelectedIndex = -1;
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            Valida_2 V2 = new Valida_2();
            V2.Show();

        }

        private void brnV3_Click(object sender, EventArgs e)
        {
            Valida3 V3 = new Valida3();
            V3.Show();
        }
    }

}
