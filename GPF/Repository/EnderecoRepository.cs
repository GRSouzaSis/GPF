using GPF.Model;
using System;

namespace GPF.Repository
{
    public class EnderecoRepository
    {
        public AcessoHelper db = new AcessoHelper();

        public void cadastrar(Endereco endereco)//passar uma classe
        {
            try
            {
                string sql = @"Insert Into endereco(end_logradouro,end_bairro,cid_id) 
                            values (@end_logradouro,@end_bairro,@cid_id)";
                db.AddParameter("@end_logradouro", endereco.end_logradouro);
                db.AddParameter("@end_bairro", endereco.end_bairro);
                db.AddParameter("@cid_id", endereco.Cidade.cid_id);
                db.ExecuteNonQuery(sql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void alterar(Endereco endereco)//passar uma classe 
        {
            try
            {
                string sql = @"Update endereco set end_logradouro=@end_logradouro, 
                                                 end_bairro=@end_bairro,
                                                 cid_id=@cid_id
                                                 where 
                                                 end_id = @end_id";
                db.AddParameter("@end_logradouro", endereco.end_logradouro);
                db.AddParameter("@end_bairro", endereco.end_bairro);
                db.AddParameter("@cid_id", endereco.Cidade.cid_id);
                db.AddParameter("@per_id", endereco.end_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void excluir(int end_id)
        {
            try
            {
                string sql = "Delete From endereco where end_id=@end_id";
                db.AddParameter("@end_id", end_id);
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
