using GPF.Helper;
using GPF.Model;
using GPF.Repository;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GPF.View
{
    public partial class fCadParametrizacao : Form
    {
        public Bitmap bmp;
        public Parametrizacao Parametrizacao { get; set; }

        ParametrizacaoRepository acc = new ParametrizacaoRepository();       

        public fCadParametrizacao()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Parametrizacao = new Parametrizacao();
            // HabilitarControles();
            AtualizarInterface();
            bExcluir.Visible = false;
            bNovo.Visible = false;
           // bSalvar.Enabled = false;
        }

        private void AtualizarInterface()
        {
            if (Parametrizacao == null)
            {
                Parametrizacao = new Parametrizacao();
            }
            else
            {
                txtNome.Text = Parametrizacao.nome.ToString();
                txtCnpj.Text = Parametrizacao.cnpj.ToString();
                picFundo.Image = null;
                picPrincipal.Image = null;
                picRelatorio.Image = null;

            }
        }

        private bool AtualizarObjeto()
        {

            string nome = txtNome.Text.Trim();
            if (nome == string.Empty)
            {
                DialogHelper.Alerta("Informe um nome para a empresa.");
                txtNome.Focus();
                return false;
            }

            string cnpj = txtCnpj.Text.Trim();
            if (cnpj == string.Empty)
            {
                DialogHelper.Alerta("Informe um cnpj.");
                txtCnpj.Focus();
                return false;
            }

            string caminho = txtDescricao.Text.Trim();
            if (caminho == string.Empty)
            {
                DialogHelper.Alerta("Selecione uma Imagem.");
                bBuscar.Focus();
                return false;
            }

            MemoryStream memory = new MemoryStream();                   
            bmp.Save(memory, ImageFormat.Bmp);
            byte[] foto = memory.ToArray();
            
           

            if (Parametrizacao == null)
            {
                Parametrizacao = new Parametrizacao();
            }

           // Parametrizacao.id = id;
            Parametrizacao.nome = nome.ToUpper();
            Parametrizacao.cnpj = cnpj;
            Parametrizacao.foto = foto;

            return true;
        }

        private bool validaObjeto()
        {
            if (txtNome.Text.Length > 22)
            {
                DialogHelper.Alerta("O nome de empresa não pode ser maior que 22 caracteres");
                txtNome.Focus();
                return false;
            }
            if (txtNome.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um nome para a empresa");
                txtNome.Focus();
                return false;
            }


            if (txtCnpj.Text == String.Empty)
            {
                DialogHelper.Alerta("Informe um cnpj para a empresa");
                txtCnpj.Focus();
                return false;
            }

            if (ValidaCNPJ() == false)
            {
                DialogHelper.Alerta("Informe um cnpj valido para a empresa");
                txtCnpj.Focus();
                return false;
            }

            string caminho = txtDescricao.Text.Trim();
            if (caminho == string.Empty)
            {
                DialogHelper.Alerta("Selecione uma Imagem.");
                bBuscar.Focus();
                return false;
            }
            return true;
        }
        bool ValidaCNPJ()
        {
            try
            {
                if (!(txtCnpj.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(txtCnpj.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(txtCnpj.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(txtCnpj.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(txtCnpj.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(txtCnpj.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(txtCnpj.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(txtCnpj.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(txtCnpj.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(txtCnpj.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(txtCnpj.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(txtCnpj.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(txtCnpj.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(txtCnpj.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(txtCnpj.Text.Substring(17, 1));

                    if (n1 == 0 && n2 == 0 && n3 == 0 && n4 == 0 && n5 == 0 && n6 == 0 && n7 == 0 && n8 == 0 && n9 == 0 && n10 == 0 && n11 == 0 && n12 == 0 && digito1 == 0 && digito2 == 0)
                    {
                        return false;
                    }

                    int Soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador1 = Soma1 % 11;

                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    int Soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador1 * 2;

                    int digitoVerificador2 = Soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se CNPJ é verdadeiro ou falso
                    if (digito1 == digitoVerificador1 && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch { return false; }

        }


        private void bBuscar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;
                txtDescricao.Text = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                picPrincipal.Image = bmp;
                picFundo.Image = bmp;
                picRelatorio.Image = bmp;
            }
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {
            ParametrizacaoRepository acc = new ParametrizacaoRepository();
            var res = acc.VerificaParametizacao();
            if (res == false)
            {
                try
                {
                    if (validaObjeto())
                    {
                        AtualizarObjeto();
                        acc.cadastrar(Parametrizacao);
                        // MostrarPerfis();//---> Atualiza Data grid view
                        this.Hide();
                        fPrincipal f = new fPrincipal();
                        f.Show();
                         // f.FormClosed += Logout;
                        MessageBox.Show("Parametrizacao incluida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bSalvar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {                
                MessageBox.Show("Já existe uma parametrização cadastrada por favor utilizar o comando alterar");
                bSalvar.Enabled = false;
            }
           
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void fCadParametrizacao_Load(object sender, EventArgs e)
        {
            try
            {
                carregarConfiguracoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void carregarConfiguracoes()
        {
            try
            {
              //  ParametrizacaoRepository acc = new ParametrizacaoRepository();
                var reader = acc.GetParametrizacao();

                reader.Read();
                if (reader.HasRows)
                {

                    txtNome.Text = reader[1].ToString();
                    txtCnpj.Text = reader[2].ToString();
                    byte[] imagem = (byte[])(reader[3]);
                    if(imagem == null)
                    {
                        picFundo.Image = null;
                        picPrincipal.Image = null;
                        picRelatorio.Image = null;
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(imagem);

                        picFundo.Image = Image.FromStream(memory);
                        picPrincipal.Image = Image.FromStream(memory);
                        picRelatorio.Image = Image.FromStream(memory);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            bSalvar.Visible = false;
            DialogResult resultado = MessageBox.Show("Confirma alteração da parametrização?", "Confirma Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (validaObjeto())
                    {
                        AtualizarObjeto();
                        ParametrizacaoRepository acc = new ParametrizacaoRepository();
                        acc.alterar(Parametrizacao);
                        MessageBox.Show("Parametrização alterada com sucesso. Fazer Logout para efetuar as alterações!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                        this.Close(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       
    }
}
