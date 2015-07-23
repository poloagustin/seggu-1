﻿using Seggu.Dtos;
using System.Collections.Generic;


namespace Seggu.Services.Interfaces
{
    public interface IUseService
    {
        IEnumerable<UseDto> GetAll();
        void Save(UseDto bank);
        void Update(UseDto bank);
        void Delete(string id);
        bool ExistName(string name);

    }
}
