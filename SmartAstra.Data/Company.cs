using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class Company : BaseDbOperations<Entities.Company>
    {
        public override Entities.Company Delete(Entities.Company companyToBeDeleted)
        {
            var company = AstraDbContext.Companies.FirstOrDefault(c => c.Id == companyToBeDeleted.Id);
            if (company != null)
            {
                AstraDbContext.Remove(company);
            }
            return company;
        }

        public override Entities.Company Get(int id)
        {
            return AstraDbContext.Companies.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public override IList<Entities.Company> GetAll()
        {
            return AstraDbContext.Companies.AsNoTracking().ToList();
        }

        public override Entities.Company Insert(Entities.Company newCompany)
        {
            lock (this)
            {
                AstraDbContext.Companies.Add(newCompany);
                return newCompany;
            }
        }

        public override Entities.Company Update(Entities.Company existingCompany)
        {
            var company = AstraDbContext.Companies.FirstOrDefault(c => c.Id == existingCompany.Id);
            if (company != null)
            {
                company = existingCompany;
                AstraDbContext.Companies.Update(company);
            }
            return company;
        }
    }
}
