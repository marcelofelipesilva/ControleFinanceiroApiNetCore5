using System.Collections.Generic;
using System.Linq;
using ControleFinanceiroApi.Business.Entities;
using ControleFinanceiroApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroApi.Infra.Data.Repositories
{
    public class ReceitaMapping : IReceitaRepository
    {
        private readonly ControleFinanceiroApiDbContext _context;

        public ReceitaMapping(ControleFinanceiroApiDbContext context)
        {
            _context = context;
        }

        public void adicionaReceita(Receita receita)
        {
            _context.Add(receita);
        }

        public void commit()
        {
            _context.SaveChanges();
        }

        public List<Receita> obterReceitas(int ReceitaID)
        {
            return _context.Receitas.Include(i => i.ReceitaID).Where(w => w.ReceitaID == ReceitaID).ToList();
        }
    }
}