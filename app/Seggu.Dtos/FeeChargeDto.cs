﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seggu.Dtos
{
    [Serializable]
    public class FeeChargeDto
    {

        public string NºRecibo { get; set; }
        public DateTime CollectionDate { get; set; }
        public string FullClientName { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleChasis { get; set; }
        public string VehicleEngine { get; set; }
        public DateTime PolicyExpirationDate { get; set; }
        public string Coverage { get; set; }
        public IEnumerable<ChargeItemDto> Items { get; set; }
        public decimal ChargeTotal
        {
            get
            {
                return this.Items.Sum(i => i.Value);
            }
        }
    }
}
