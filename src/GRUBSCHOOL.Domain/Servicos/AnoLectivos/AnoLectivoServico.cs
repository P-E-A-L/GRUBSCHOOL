using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Domain.Interfaces.Repositorios;
using GRUBSCHOOL.Domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Domain.Servicos
{
    public class AnoLectivoServico : IAnoLectivoServico
    {
        private readonly IAnoLectivoRepositorio _anoLectivoRepositorio;

        public AnoLectivoServico(IAnoLectivoRepositorio anoLectivoRepositorio)
        {
            _anoLectivoRepositorio = anoLectivoRepositorio;
        }

        #region "Inserir"
        public async Task Inserir(AnoLectivo obj)
        {


            if (obj.IsValid)
                await _anoLectivoRepositorio.Inserir(obj);
        }

        public async Task Inserir(ICollection<AnoLectivo> obj)
        {
            foreach (var item in obj)
                await Inserir(item);
        }
        #endregion

        #region "Alterar"
        public void Alterar(AnoLectivo obj)
        {
            if (obj.IsValid)
                _anoLectivoRepositorio.Alterar(obj);
        }

        public void Alterar(ICollection<AnoLectivo> obj)
        {
            foreach (var item in obj)
                Alterar(item);
        }
        #endregion

        public Task Guardar(AnoLectivo obj)
        {
            throw new System.NotImplementedException();
        }

        public Task Guardar(ICollection<AnoLectivo> obj)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(AnoLectivo obj)
        {
            _anoLectivoRepositorio.Remover(obj);
        }

        public void Remover(ICollection<AnoLectivo> obj)
        {
            foreach (var item in obj)
                Remover(item);

        }

        public async Task<ICollection<AnoLectivo>> ListarTodos()
        {
           return await _anoLectivoRepositorio.ListarTodos();
        }


        public async Task<AnoLectivo> BuscarPorAno(int ano)
        {
            return await _anoLectivoRepositorio.BuscarPorAno(ano);
        }

        public async Task<AnoLectivo> BuscarPorId(int id)
        {
            return await _anoLectivoRepositorio.BuscarPorId(id);
        }

    }
}
