using System.Collections.Generic;
using ControleFinanceiroApi.Business.Entities;

namespace ControleFinanceiroApi.Business.IRepositories
{
    public interface IContaPagarRepository
    {
        void adicionaContaPagar(ContaPagar contaPagar);
        void commit();
        List<ContaPagar> obterContasPagar(int ContaPagarID);
        
    }
}