using AutoMapper;
using GRUBSCHOOL.Application.Interfaces;
using GRUBSCHOOL.Application.ViewModels;
using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Domain.Interfaces.Servicos;
using GRUBSCHOOL.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Application.Aplicacoes
{
    public class AnoLectivoApp : IAnoLectivoApp
    {
        private readonly IAnoLectivoServico _anoLectivoServico;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public AnoLectivoApp(IAnoLectivoServico anoLectivoServico, IMapper mapper, IUnitOfWork uow)
        {
            _anoLectivoServico = anoLectivoServico;
            _mapper = mapper;
            _uow = uow;
        }

        #region "Inserir"
        public async Task Inserir(AnoLectivoViewModel obj)
        {
            var anoLectivo = _mapper.Map<AnoLectivo>(obj);
            await _anoLectivoServico.Inserir(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }

        public async Task Inserir(ICollection<AnoLectivoViewModel> obj)
        {

            foreach (var item in obj)
            {
                var anoLectivo = _mapper.Map<AnoLectivo>(item);
                await _anoLectivoServico.Inserir(anoLectivo);
            }

            if (!await _uow.Commit())
                await _uow.Rollback();

        }
        #endregion

        #region "Alterar"
        public async void Alterar(AnoLectivoViewModel obj)
        {
            var anoLectivo = _mapper.Map<AnoLectivo>(obj);
            _anoLectivoServico.Alterar(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }

        public async void Alterar(ICollection<AnoLectivoViewModel> obj)
        {
            foreach (var item in obj)
            {
                var anoLectivo = _mapper.Map<AnoLectivo>(item);
                _anoLectivoServico.Alterar(anoLectivo);
            }

            if (!await _uow.Commit())
                await _uow.Rollback();
        }
        #endregion

        #region "Guardar"
        public async Task Guardar(AnoLectivoViewModel obj)
        {
            var anoLectivo = _mapper.Map<AnoLectivo>(obj);
            await _anoLectivoServico.Guardar(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }

        public async Task Guardar(ICollection<AnoLectivoViewModel> obj)
        {
            var anoLectivo = _mapper.Map<AnoLectivo>(obj);
            await _anoLectivoServico.Guardar(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }
        #endregion

        #region "Remover"
        public async void Remover(AnoLectivoViewModel obj)
        {

            var anoLectivo = _mapper.Map<AnoLectivo>(obj);
            _anoLectivoServico.Remover(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }

        public async void Remover(ICollection<AnoLectivoViewModel> obj)
        {
            foreach (var item in obj)
            {
                var anoLectivo = _mapper.Map<AnoLectivo>(item);
                _anoLectivoServico.Remover(anoLectivo);
            }

            if (!await _uow.Commit())
                await _uow.Rollback();

        }
        #endregion

        #region "Listagens e Bucas"
        public async Task<ICollection<AnoLectivoViewModel>> ListarTodos()
        {
           return _mapper.Map<ICollection<AnoLectivoViewModel>>(await _anoLectivoServico.ListarTodos());
        }

        public async Task<AnoLectivoViewModel> BuscarPorId(Guid id)
        {
            return _mapper.Map<AnoLectivoViewModel>(await _anoLectivoServico.BuscarPorId(id));
        }

        public async Task<AnoLectivoViewModel> BuscarPorAno(int ano)
        {
            return _mapper.Map<AnoLectivoViewModel>(await _anoLectivoServico.BuscarPorAno(ano));
        }
        #endregion
    }
}
