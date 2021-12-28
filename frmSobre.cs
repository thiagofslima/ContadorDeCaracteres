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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
            this.ControlBox = false; //Oculta o botão fechar
        }

        #region Remover botão fechar sem remover icone
        /*private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }*/
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
