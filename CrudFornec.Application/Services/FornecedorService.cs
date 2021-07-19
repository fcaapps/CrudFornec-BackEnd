using AutoMapper;
using CrudFornec.Application.ViewModels;
using CrudFornec.Domain.Entities;
using CrudFornec.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.Interfaces;

namespace CrudFornec.Application.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository fornecRepository;

        public FornecedorService(IFornecedorRepository fornecRepository, IMapper mapper)
        {
            this.fornecRepository = fornecRepository;
        }

        public List<FornecedorViewModel> Get()
        {
            List<FornecedorViewModel> _fornecViewModels = new List<FornecedorViewModel>();

            IEnumerable<Fornecedor> _fornec = this.fornecRepository.GetAll();

            foreach (var item in _fornec)
            {
                _fornecViewModels.Add(new FornecedorViewModel
                {
                    Id = item.Id,
                    RazaoSocial = item.RazaoSocial,
                    NomeFantasia = item.NomeFantasia,
                    Cnpj = item.Cnpj,
                    Cep = item.Cep,
                    Localidade = item.Localidade,
                    Numero = item.Numero,
                    Complemento = item.Complemento,
                    Bairro = item.Bairro
                });
            }

            return _fornecViewModels;
        }

    }
}
