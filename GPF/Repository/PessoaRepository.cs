using System.Data;
using System.Data.SqlClient;

namespace GPF.Repository
{
    public class PessoaRepository : Connection
    {
       /*
        public void Excluir(Pessoa pessoa)
        {
            Connection.Execute("delete from pessoa where pes_id=@pes_id", pessoa);
        }

        public void Excluir()
        {
            Connection.Execute("delete from pessoa");
        }

        public Pessoa Get(int? pes_id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> GetAll(int pes_id)
        {
            throw new NotImplementedException();
        }

        public void Gravar(Pessoa pessoa)
        {
            if (pessoa.pes_id == 0)
            {
                Connection.Execute("insert into pessoa(pes_ativo) values (@pes_ativo)", pessoa);
                pessoa.pes_id = Convert.ToInt32(Connection.ExecuteScalar("select last_insert_id()"));
            }
            else
            {
                Connection.Execute("update pessoa set pes_ativo = @pes_ativo where pes_id = @pes_id", pessoa);
            }
        }*/
    }
}
