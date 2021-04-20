using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamosOrar.Data.Models
{
    public class PedidosOracoes
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Display(Name = "Motivo")]
        public TiposCausas Causas { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Responsável")]
        public string Responsavel { get; set; }

        public string DetalhesPedido { get; set; }
    }
}
