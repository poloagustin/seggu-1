﻿using Seggu.Daos.Interfaces;
using Seggu.Data;
using Seggu.Dtos;
using Seggu.Services.DtoMappers;
using Seggu.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Seggu.Services
{
    public sealed class CompanyService : ICompanyService
    {
        private ICompanyDao companyDao;
        private IProducerCodeDao producerCodeDao;
        private IProducerDao producerDao;


        public CompanyService(ICompanyDao companyDao, IProducerCodeDao producerCodeDao, IProducerDao producerDao)
        {
            this.companyDao = companyDao;
            this.producerCodeDao = producerCodeDao;
            this.producerDao = producerDao;
        }
        public IEnumerable<CompanyDto> GetAll()
        {
            var companies = this.companyDao.GetIndex();

            return companies
                .OrderBy(x => x.Name).Where(x => x.Active == true)
                .Select(c => CompanyDtoMapper.GetDto(c));
        }        
        public CompanyFullDto GetFullById(string id)
        {
            var obj = this.companyDao.GetById(new Guid(id));           
            return CompanyDtoMapper.GetFormDto(obj);
        }
        public CompanyDto GetById(string id)
        {
            return CompanyDtoMapper.GetDto(companyDao.GetById(new Guid(id)));
        }
        public void DeleteProducerCode(string companyId, string producerId)
        {
            var idC = new Guid(companyId);
            var idP = new Guid(producerId);
            var obj = producerCodeDao.GetByCompanyProducer(idC, idP);
            producerCodeDao.Delete(obj);
            
        }        
        public void AddProducer(ProducerCodeDto prodCode)
        {
            producerCodeDao.Save(ProducerCodeDtoMapper.GetObject(prodCode));
        }
        public void DeleteCompany(CompanyDto company)
        {
            var c = CompanyDtoMapper.GetObject(company);
            //companyDao.Delete(c);
            companyDao.Delete(c.Id);
        }        
        public void Create(CompanyDto company)//debería guardar un CompanyFormDto (objeto con dependencias)
        {
            companyDao.Save(CompanyDtoMapper.GetObject(company));
        }        
        public void Update(CompanyDto company)//debería guardar un CompanyFormDto (objeto con dependencias)
        {
            companyDao.Update(CompanyDtoMapper.GetObject(company));
        }



        public bool ExistName(string name)
        {
            return companyDao.GetByName(name);
        }
    }
}
