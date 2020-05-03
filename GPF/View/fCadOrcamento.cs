using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadOrcamento : Form
    {
        public fCadOrcamento()
        {
            InitializeComponent();
            AplicarEventos(txtValorTotal);
            PreencherDataVencimento();
        }
        public void PreencherDataVencimento()
        {           

            for (int i = 1; i <= 31; i++)
            {
               cbbVencimento.Items.Add(i);
            }           
        }
       

    #region Mascára dinheiro 

    private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(txt.Text == "")
            {

            }
            else
            {
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
#endregion
    }
}
