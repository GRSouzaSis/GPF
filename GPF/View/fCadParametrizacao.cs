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
        Ajudas ajuda = new Ajudas();
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
           ;
            if (!ajuda.ValidaCNPJ(txtCnpj.Text))
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
                DialogResult resultado = MessageBox.Show("Confirma alteração da parametrização?", "Confirma Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        if (validaObjeto())
                        {
                            AtualizarObjeto();
                            ParametrizacaoRepository repPar = new ParametrizacaoRepository();
                            repPar.alterar(Parametrizacao);
                            MessageBox.Show("Parametrização alterada com sucesso. Fazer Logout para efetuar as alterações!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
              //  MessageBox.Show("Já existe uma parametrização cadastrada por favor utilizar o comando alterar");
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
           
        }
       
    }
}
