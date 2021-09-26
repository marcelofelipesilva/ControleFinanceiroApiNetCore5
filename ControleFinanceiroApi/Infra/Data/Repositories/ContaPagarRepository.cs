using System.Collections.Generic;
using System.Linq;
using ControleFinanceiroApi.Business.Entities;
using ControleFinanceiroApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroApi.Infra.Data.Repositories
{
    public class ContaPagarRepository : IContaPagarRepository
    {
        private readonly ControleFinanceiroApiDbContext _context;

        public ContaPagarRepository(ControleFinanceiroApiDbContext context)
        {
            _context = context;
        }

        public void adicionaContaPagar(ContaPagar contaPagar)
        {
           _context.Add(contaPagar);
        }

        public void commit()
        {
           _context.SaveChanges();
        }

        public List<ContaPagar> obterContasPagar(int ContaPagarID)
        {
            return _context.ContasPagar.Include(i => i.ContaPagarID).Where(w => w.ContaPagarID == ContaPagarID).ToList();
        }
    }
}