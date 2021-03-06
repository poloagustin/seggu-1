﻿using Seggu.Daos.Interfaces;
using Seggu.Data;
using Seggu.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Seggu.Daos
{
    public sealed class BodyworkDao : IdEntityDao<Bodywork>, IBodyworkDao
    {
        public BodyworkDao(SegguDataModelContext context)
            : base(context)
        {
        }

        public bool GetByName(string name)
        {
            return this.Set.Any(c => c.Name == name);
        }

        public IEnumerable<Bodywork> GetByVehicleType(int vehicleTypeId)
        {
            return this.context.VehicleTypes.Find(vehicleTypeId).Bodyworks;
        }

        public void SaveChanges(VehicleType vehicleType, IEnumerable<Bodywork> existing)
        {
            vehicleType = this.context.VehicleTypes.Find(vehicleType.Id);

            foreach (var obj in existing)
            {
                if (!vehicleType.Bodyworks.Any(x => x.Id == obj.Id))
                {
                    vehicleType.Bodyworks.Add(obj);
                }
            }

            var nonExisting = vehicleType.Bodyworks.Where(b => !existing.Any(x => x.Id == b.Id));
            while (nonExisting.Any())
            {
                vehicleType.Bodyworks.Remove(nonExisting.First());
            }

            this.context.SaveChanges();
        }
    }
}
