﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seggu.Daos.Interfaces;
using Seggu.Data;
using Seggu.Dtos;
using Seggu.Services.DtoMappers;
using Seggu.Services.Interfaces;

namespace Seggu.Services
{
    public sealed class ClientService : IClientService
    {
        private IClientDao clientDao;
        private IAddressDao addressDao;

        public ClientService(IClientDao clientDao, IAddressDao addressDao)
        {
            this.clientDao = clientDao;
            this.addressDao = addressDao;
        }

        public void Save(ClientFullDto clientInformation)
        {
            var isNew = string.IsNullOrEmpty(clientInformation.Id);
            var client = ClientDtoMapper.GetObject(clientInformation);
            if (isNew)
                this.clientDao.Save(client);            
            else
                this.clientDao.Update(client);

            clientInformation.Id = client.Id.ToString();

            #region Home Address

            var homeAddress = AddressDtoMapper.GetHome(clientInformation);
            if (homeAddress.Id == Guid.Empty)
                this.addressDao.Save(homeAddress);
            else
                this.addressDao.Update(homeAddress);

            #endregion

            #region Collection Address

            var collectionAddress = AddressDtoMapper.GetCollection(clientInformation);
            if (collectionAddress.Id == Guid.Empty)
                this.addressDao.Save(collectionAddress);
            else
                this.addressDao.Update(collectionAddress);

            #endregion
        }

        public IEnumerable<ClientFullDto> GetByDNI(string str)
        {
            var clients = this.clientDao.GetByDni(str);
            return clients.Select(x => ClientDtoMapper.GetDto(x));
        }

        public IEnumerable<ClientFullDto> GetByName(string str)
        {
            var clients = this.clientDao.GetByFullName(str);
            return clients.Select(x => ClientDtoMapper.GetDto(x));
        }

        public IEnumerable<ClientIndexDto> GetAll()
        {
            var clients = this.clientDao.GetAll().OrderBy(x => x.LastName);
            return clients.Select(x => ClientDtoMapper.GetIndexDto(x));
        }

        public ClientIndexDto GetShortDtoById(string clientId)
        {
            var client = this.clientDao.Get(new Guid(clientId));
            return ClientDtoMapper.GetIndexDto(client);
        }

        public ClientFullDto GetById(string clientId)
        {
            var id = new Guid(clientId);
            var client = this.clientDao.Get(id);
            return ClientDtoMapper.GetDto(client);
        }
        public IEnumerable<ClientIndexDto> GetValids()
        {
            var clients = this.clientDao.GetValids().OrderBy(x => x.LastName);
            return clients.Select(x => ClientDtoMapper.GetIndexDto(x));
        }
    }
}
