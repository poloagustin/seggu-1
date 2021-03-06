﻿using System;

namespace Seggu.Dtos
{
    [Serializable]
    public class AccessoryDto: KeyValueDto
    {
        public string Oblea { get; set; }
        public DateTime Vencimiento { get; set; }
        public decimal Valor { get; set; }
        public int VehicleId { get; set; }
        public int AccessoryTypeId { get; set; }
    }
}
