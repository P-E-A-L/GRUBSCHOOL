using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GRUBSCHOOL.Domain.Interfaces
{
    public interface IGenericoRepositorio<T>
    {
        Task Inserir(T obj);
        Task Inserir(ICollection<T> obj);
        void Alterar(T obj);
        void Alterar(ICollection<T> obj);
        void Remover(T obj);
        void Remover(ICollection<T> obj);
        Task Guardar(T obj);
        Task Guardar(ICollection<T> obj);
        Task<ICollection<T>> ListarTodos();
        Task<T> BuscarPorId(int id);
    }
}
