using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace CineminhaXD.Entities
{
    public class Filme : Entity<int>
    {
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Diretor { get; set; }
        public DateTime Duracao { get; set; }
        public string Genero { get; set; }
        public string Classificacao { get; set; }
        public string Distribuidora { get; set; }
        public int SalaDeExibicao { get; set; }
        public List<Horario> Horarios { get; set; }
    }
}
