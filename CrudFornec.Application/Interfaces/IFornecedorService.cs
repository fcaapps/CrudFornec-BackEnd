using System;
using System.Collections.Generic;
using System.Text;
using CrudFornec.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface IFornecedorService
    {
        List<FornecedorViewModel> Get();        

    }
}
