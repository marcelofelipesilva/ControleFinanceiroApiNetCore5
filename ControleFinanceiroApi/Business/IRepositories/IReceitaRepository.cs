using System.Collections.Generic;
using ControleFinanceiroApi.Business.Entities;

namespace ControleFinanceiroApi.Business.IRepositories
{
    public interface IReceitaRepository
    {
        void adicionaReceita(Receita receita);
        void commit();
        List<Receita> obterReceitas(int ReceitaID);
    }
}