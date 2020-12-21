using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Advert
{
    public class QueryAdvertDto
    {
        public enum FuelType
        {
            Diesel,
            Petrol,
            Electric,
            LPG
        }
        public enum ConditionState
        {
            Damaged,
            Undamaged
        }
        public enum DriveTypes
        {
            FWD,
            RWD,
            AWD
        }
        public enum TransmissionTypes
        {
            Sequence,
            Automatic,
            Manual
        }
        public string VIN { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public int MinMileage { get; set; }
        public int MaxMileage { get; set; }
        public DateTime? FromCarProductionDate { get; set; }
        public DateTime? ToCarProductionDate { get; set; }
        public FuelType? Fuel { get; set; }
        public ConditionState? Condition { get; set; }
        public int MinHorsepower { get; set; }
        public int MaxHorsepower { get; set; }
        public int MinDisplacement { get; set; }
        public int MaxDisplacement { get; set; }
        public TransmissionTypes? TransmissionType { get; set; }
        public DriveTypes? DriveType { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string GenerationName { get; set; }
    }
}
