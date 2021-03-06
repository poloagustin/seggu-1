﻿using Seggu.Domain;
using System;
using System.Collections.Generic;

namespace Seggu.Daos.Interfaces
{
    public interface IVehicleDao : IIdEntityDao<Vehicle>
    {
        Vehicle GetByPolicyId(long PolicyId);
        IEnumerable<Vehicle> GetByPlate(string plate);
        void SaveVehicle(Vehicle vehicle);
    }
}
