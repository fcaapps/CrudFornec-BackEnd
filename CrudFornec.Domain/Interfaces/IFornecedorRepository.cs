using System;
using System.Collections.Generic;
using System.Text;
using CrudFornec.Domain.Entities;

namespace CrudFornec.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        IEnumerable<Fornecedor> GetAll();
    }
}
