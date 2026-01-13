using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Contains / String
            string texto = "Este tipo de variável é alfanumérica.";

            if (texto.Contains("tipo"))
            {
                label1.Text = "Contém.";
            }
            else
            {
                label1.Text = "Não contém.";
            }
            #endregion

            #region To Upper
            //string nome = "joao";

            //string nomeMaiusculo = nome.ToUpper();

            //label1.Text = nomeMaiusculo;
            #endregion

            #region To Lower
            //string nome = "Joao";

            //string nomeMin = nome.ToLower();

            //label1.Text = nomeMin;
            #endregion

            string nome = "Gabriel Artigas";

            nome.IndexOf('a');
        }
    }
}
