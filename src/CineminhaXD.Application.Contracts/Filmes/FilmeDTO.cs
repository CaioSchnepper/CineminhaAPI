using CineminhaXD.Horarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineminhaXD.Filmes
{
    public class FilmeDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Diretor { get; set; }
        public DateTime Duracao { get; set; }
        public string Genero { get; set; }
        public string Classificacao { get; set; }
        public string Distribuidora { get; set; }
        public int SalaDeExibicao { get; set; }
        public List<HorarioDTO> Horarios { get; set; }
    }
}
