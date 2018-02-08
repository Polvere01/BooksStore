using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Repositories.Contracts
{
    public interface IAutorRepository : IDisposable
    {
        List<Autor> Get();
        Autor Get(int id);
        List<Autor> GetByName(string name);
        bool Create(Autor autor);
        bool Update(Autor autor);
        void Delete(int id);
    }
}