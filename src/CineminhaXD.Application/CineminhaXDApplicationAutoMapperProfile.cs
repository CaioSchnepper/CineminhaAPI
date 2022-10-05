using AutoMapper;
using CineminhaXD.Entities;
using CineminhaXD.Filmes;
using CineminhaXD.Horarios;

namespace CineminhaXD;

public class CineminhaXDApplicationAutoMapperProfile : Profile
{
    public CineminhaXDApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        #region Filmes

        CreateMap<FilmeDTO, Filme>();
        CreateMap<Filme, FilmeDTO>();
        CreateMap<FilmeCreateDTO, Filme>();

        #endregion

        #region Horarios

        CreateMap<Horario, HorarioDTO>();
        CreateMap<HorarioDTO, Horario>();

        #endregion

    }
}
