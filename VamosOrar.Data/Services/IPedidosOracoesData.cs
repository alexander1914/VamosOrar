using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamosOrar.Data.Models;

namespace VamosOrar.Data.Services
{
    public interface IPedidosOracoesData
    {
        PedidosOracoes GetById(int id);
        IEnumerable<PedidosOracoes> GetAll();
        void Add(PedidosOracoes pedidosOracoes);
        void Update(PedidosOracoes pedidosOracoes);
        void Delete(int id);
    }
}
