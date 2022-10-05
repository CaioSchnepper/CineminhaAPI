using CineminhaXD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace CineminhaXD.Filmes
{
    public class FilmesAppService : ApplicationService
    {
        #region Properties

        private readonly IRepository<Filme, int> _filmesRepository;
        private readonly IObjectMapper _objectMapper;

        #endregion

        #region Constructor

        public FilmesAppService(
            IRepository<Filme, int> filmesRepository,
            IObjectMapper objectMapper)
        {
            _filmesRepository = filmesRepository;
            _objectMapper = objectMapper;
        }

        #endregion

        #region Methods

        public async Task<FilmeDTO> GetAsync(int id)
        {
            var filme = await _filmesRepository.GetAsync(filme => filme.Id == id);

            return _objectMapper.Map<Filme, FilmeDTO>(filme);
        }

        public async Task<List<FilmeDTO>> GetListAsync()
        {
            var filmes = await _filmesRepository.GetListAsync();

            return _objectMapper.Map<List<Filme>, List<FilmeDTO>>(filmes);
        }

        public async Task<FilmeDTO> CreateAsync(FilmeCreateDTO filmeCreateDTO)
        {
            var filme = _objectMapper.Map<FilmeCreateDTO, Filme>(filmeCreateDTO);

            var filmeInserted = await _filmesRepository.InsertAsync(filme);

            return _objectMapper.Map<Filme, FilmeDTO>(filmeInserted);
        }

        public async Task<FilmeDTO> UpdateAsync(FilmeDTO filmeDTO)
        {
            var filme = _objectMapper.Map<FilmeDTO, Filme>(filmeDTO);

            var filmeUpdated = await _filmesRepository.UpdateAsync(filme);

            return _objectMapper.Map<Filme, FilmeDTO>(filmeUpdated);
        }

        public async Task DeleteAsync(int id)
        {
            await _filmesRepository.DeleteAsync(id);
        }

        #endregion

    }
}
