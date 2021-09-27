using System.Collections.Generic;
using System.Linq;
using ControleFinanceiroApi.Business.Entities;
using ControleFinanceiroApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroApi.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ControleFinanceiroApiDbContext _context;

        public UsuarioRepository(ControleFinanceiroApiDbContext context)
        {
            _context = context;
        }

        public void adicionaUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void commit()
        {
            _context.SaveChanges();
        }

        public List<Usuario> obterUsuarios(int UsuarioID)
        {
            return _context.Usuarios.Include(i => i.UsuarioID).Where(w => w.UsuarioID == UsuarioID).ToList();
        }
    }
}