using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorDeCaracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back && contador >= 0)
            {
                if (contador != 0)
                    contador--;
            }
            else
                contador++;
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            //Se selecionar o texto todo e apagar, zera o contador
            if (txtTexto.Text == string.Empty)
                contador = 0;

            MudarCor(contador);



            //VERIFICAR ISSO AQUI!!!!!!!!!!!!!!!!!!!!!!!!!!
            slblContador.Text = contador.ToString();

            slblContador.Text = txtTexto.TextLength.ToString();
        }
        private void MudarCor(int contador)
        {
            if (contador <= 10)
                txtTexto.BackColor = Color.Black;
            if (contador > 10)
                txtTexto.BackColor = Color.Red;
            if (contador > 20)
                txtTexto.BackColor = Color.Blue;
            if (contador > 30)
                txtTexto.BackColor = Color.Green;
        }

        private void tsmiLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = string.Empty;
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiMudarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = txtTexto.Font; //Já abrir com a config atual
            
            if(fontDialog.ShowDialog() == DialogResult.OK)
                txtTexto.Font = fontDialog.Font;
        }

        private void tsmiSobre_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }
    }
}
