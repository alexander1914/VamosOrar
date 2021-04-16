using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamosOrar.Data.Models;

namespace VamosOrar.Data.Services
{
    public class SqlPedidosOracoesData : IPedidosOracoesData
    {
        private readonly VamosOrarDbContext db;
        
        public SqlPedidosOracoesData(VamosOrarDbContext db)
        {
            this.db = db;
        }

        public PedidosOracoes GetById(int id)
        {
            return db.PedidosOracoes.FirstOrDefault(p => p.Id == id);
        }      

        public IEnumerable<PedidosOracoes> GetAll()
        {
            return from p in db.PedidosOracoes
                   orderby p.Nome
                   select p;
        }

        public void Add(PedidosOracoes pedidosOracoes)
        {
            db.PedidosOracoes.Add(pedidosOracoes);
            db.SaveChanges();
        }

        public void Update(PedidosOracoes pedidosOracoes)
        {
            var entry = db.Entry(pedidosOracoes);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
        
        public void Delete(int id)
        {
            PedidosOracoes pedidosOracoes = db.PedidosOracoes.Find(id);
            db.PedidosOracoes.Remove(pedidosOracoes);
            db.SaveChanges();
        }

    }
}
