﻿using System;

namespace CommunalPayments.Models
{
    [Serializable]
    public class SettingsModel
    {
        public decimal ColdWaterPerCubeCost { get; set; }
        public decimal HotWaterPerCubeCost { get; set; }
        public decimal ElectricityPerKwtCost { get; set; }
        public decimal InternetCost { get; set; }
        public decimal WaterSumCost { get; set; }

        public SettingsModel()
        {

        }

        public SettingsModel(decimal coldWaterPerCubeCost, decimal hotWaterPerCubeCost,
            decimal electricityPerKwtCost, decimal internetCost, decimal waterSumCost)
        {
            ColdWaterPerCubeCost = coldWaterPerCubeCost;
            HotWaterPerCubeCost = hotWaterPerCubeCost;
            ElectricityPerKwtCost = electricityPerKwtCost;
            InternetCost = internetCost;
            WaterSumCost = waterSumCost;
        }
    }
}