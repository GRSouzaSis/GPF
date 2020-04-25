using GPF.Repository;
using GPF.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GPF
{
    public partial class fLogin : Form   {
      
       
        public fLogin()
        {
            InitializeComponent();           
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if(lbErroMessage.Visible == true)
            {
                lbErroMessage.Visible = false;
            }
            if (txtLogin.Text == "Login")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.LightGray;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Login";
                txtLogin.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (lbErroMessage.Visible == true)
            {
                lbErroMessage.Visible = false;
            }
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.WhiteSmoke;
                txtSenha.UseSystemPasswordChar = false;
            }
        }



        private void msgErro(string msg)
        {
            lbErroMessage.Text = msg;
            lbErroMessage.Visible = true;
        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository uso = new UsuarioRepository();
            if( txtLogin.Text != "Login")
            {
                if(txtSenha.Text != "Senha")
                {
                    try
                    {
                       var parame = uso.VerificaParametizacao();
                        var res =  uso.Login(txtLogin.Text, txtSenha.Text);              

                        if (Convert.ToInt32(parame) != 0 && Convert.ToInt32(res) > 0)
                        {
                            this.Hide();
                           // uso.carregarParametrizacao();
                            fPrincipal f = new fPrincipal();
                            f.Show();
                            f.FormClosed += Logout;
                           
                            //chamar formPrincipal               

                        }
                        else if (Convert.ToInt32(parame) == 0)
                        {
                            this.Hide();
                            fCadParametrizacao f = new fCadParametrizacao();
                            f.Show();
                            f.FormClosed += Logout; // chamar parametrizacao
                        }
                        else
                        {
                            msgErro(" Dados incorretos. \n Por favor tente novamente.");
                        }
                        // MessageBox.Show("Abrir Principal");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    msgErro("Por favor informar uma senha valida.");                   
                }
            }
            else
            {
                msgErro("Por favor informar um login valido.");               
            }            
        }

        
        
    
        public void Logout(object sender, FormClosedEventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
            lbErroMessage.Visible = false;
            this.Show();
            txtLogin.Focus();
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
