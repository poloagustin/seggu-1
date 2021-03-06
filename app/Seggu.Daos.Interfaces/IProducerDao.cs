﻿using Seggu.Domain;
using System.Collections.Generic;

namespace Seggu.Daos.Interfaces
{
    public interface IProducerDao : IIdEntityDao<Producer>
    {
        IEnumerable<Producer> GetCollectors();
        bool GetByRegistrationNumberId(string registrationNumber, long id);
        bool GetByRegistrationNumber(string registrationNumber);  
    }
}
