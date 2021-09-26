using System.Collections.Generic;
using ControleFinanceiroApi.Business.Entities;

namespace ControleFinanceiroApi.Business.IRepositories
{
    public interface IUsuarioRepository
    {
        void adicionaUsuario(Usuario usuario);
        void commit();
        List<Usuario> obterUsuarios(int ContaPagarID);
    }
}