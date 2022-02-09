using SmartAstra.Business.Interfaces;
using SmartAstra.Data.Interfaces;
using SmartAstra.Dto;
using SmartAstra.Framework.Common;
//using SmartAstra.Framework.Entities;
using SmartAstra.Framework.Entities.Interfaces;
using System.Collections.Generic;

namespace SmartAstra.Business
{
    public class CompanyBusiness : IBusinessOperations
    {
        private IDataOperations<Entities.Company> _dataOperations;
        public CompanyBusiness()
        {
            _dataOperations = new Data.Company();
        }

        public IResponse<List<Dto.Company>> GetCompanies()
        {
            var result = _dataOperations.GetAll();
            var response = new Response<List<Dto.Company>>();

            if (result != null && result.Count > 0)
            {
                var listOfCompanies = new List<Dto.Company>();
                foreach (var company in result)
                {
                    var companyDto = new Dto.Company()
                    {
                        Id = company.Id,
                        Name = company.Name
                    };

                    listOfCompanies.Add(companyDto);
                }
            }
            return response;
        }


        public IResponse<Dto.Company> GetCompany(int id)
        {
            var result = _dataOperations.Get(id);
            var response = new Response<Dto.Company>();

            if (result != null)
            {
                var companyDto = new Dto.Company()
                {
                    Id = result.Id,
                    Name = result.Name
                };

                response.Result = companyDto;
            }
            return response;
        }

        public IResponse<Dto.Company> AddCompany(Dto.Company newCompany)
        {
            var response = new Response<Dto.Company>();
            if (newCompany != null)
            {
                if (DoesCompanyNameExist(newCompany.Name))
                {
                    response.Status = ResponseStatus.Duplicate;
                    return response;
                }

                var company = ConvertFromDtoToEntity(newCompany);
                var result = _dataOperations.Insert(company);

                if (result != null)
                {
                    response.Result = ConvertFromEntitiesToDto(result);
                }
            }
            return response;
        }


        private Entities.Company ConvertFromDtoToEntity(Dto.Company company)
        {
            return new Entities.Company()
            {

            };
        }


        private Dto.Company ConvertFromEntitiesToDto(Entities.Company company)
        {
            return new Dto.Company()
            {

            };
        }

        private bool DoesCompanyNameExist(string companyName)
        {
            return false;
        }
    }
}
