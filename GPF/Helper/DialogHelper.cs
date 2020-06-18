using System.Windows.Forms;

namespace GPF.Helper
{
    public class DialogHelper
    {
        public static void Alerta(string texto)
        {
            MessageBox.Show(texto, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Informacao(string texto)
        {
            MessageBox.Show(texto, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Erro(string texto)
        {
            MessageBox.Show(texto, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirmacao(string texto)
        {
            return MessageBox.Show(texto, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
    }
}
