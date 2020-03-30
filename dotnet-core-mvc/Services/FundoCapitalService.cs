using dotnet_core_mvc.CrossCutting;
using dotnet_core_mvc.Models.Config;
using dotnet_core_mvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_mvc.Services
{
    public class FundoCapitalService
    {
        private readonly FundoCapitalRepository _fundoCapitalRepository;
        private readonly ContextBase _contextBase;

        public FundoCapitalService(FundoCapitalRepository fundoCapitalRepository, ContextBase contextBase)
        {
            _fundoCapitalRepository = fundoCapitalRepository;
            _contextBase = contextBase;
        }

        public List<FundoCapitalDto> GetById(Guid id)
        {
            var dto =  _fundoCapitalRepository.GetById(id)
                //.Select(x => new FundoCapitalDto()
                //{
                //    Id = x.Id,
                //    DataResgate = x.DataResgate,
                //    Nome = x.Nome
                //});

            return dto;
        }

    }
}
