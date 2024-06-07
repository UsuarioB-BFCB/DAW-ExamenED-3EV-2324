using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen3EV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiccionarioBFCB diccionario = new DiccionarioBFCB();
            String frase1 = txtFrase1.Text;
            String frase2 = txtFrase2.Text;
            try
            {
                diccionario.Analizar(frase1, frase2);
            }
            catch (Exception error)
            {
                if (error.Message.Contains(diccionario.ERROR_FRASE1_VACIA))
                {
                    MessageBox.Show("La primera frase esta vacia");
                }
                else
                if (error.Message.Contains(diccionario.ERROR_FRASE2_VACIA))
                {
                    MessageBox.Show("La primera frase esta vacia");
                }
            }
            int resultado = diccionario.Analizar(txtFrase1.Text, txtFrase2.Text);
            if (resultado == 0)
            {
                for (int i = 0; i < diccionario.Palabras.Count; i++)
                    txtDiccionario.Text += diccionario.Palabras[i] + Environment.NewLine;
            }
        }    
    }
}
