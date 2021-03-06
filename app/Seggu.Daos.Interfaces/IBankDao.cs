﻿using Seggu.Domain;

namespace Seggu.Daos.Interfaces
{
    public interface IBankDao : IIdEntityDao<Bank>
    {
        bool GetByName(string name);
        bool GetByNumber(string number);
    }
}
