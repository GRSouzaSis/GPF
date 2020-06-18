using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPF.Helper
{
    public class txtValor: TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if(Text == "")
            {
                return;
            }
            try
            {
                var valor = Convert.ToDouble(Text.Replace("R$ ", ""));
                Text = String.Format("{0:c}", valor);
            }
            catch
            {
                Text = "";
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.KeyCode == Keys.Escape)
            {
                Text = "";
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            TextAlign = HorizontalAlignment.Left;
        }
    }
}
