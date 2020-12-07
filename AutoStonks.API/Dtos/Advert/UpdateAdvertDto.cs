using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Advert
{
    public class UpdateAdvertDto
    {
        public enum States
        {
            New, //Dodane, nieopłacone
            Active, //Dodane, opłacone
            Expired,
            Terminated
        }
        public enum FuelTypes
        {
            Diesel,
            Petrol,
            Electric,
            LPG
        }
        public enum ConditionStates
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
        public int Id { get; set; }
        public bool IsPromoted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VIN { get; set; }
        public DateTime FirstRegistrationDate { get; set; }
        public string PlateNumber { get; set; }
        public States State { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public DateTime CarProductionDate { get; set; }
        public FuelTypes Fuel { get; set; }
        public ConditionStates Condition { get; set; }
        public int Horsepower { get; set; }
        public int Displacement { get; set; }
        public string Location { get; set; }
        public bool HasBeenCrashed { get; set; }
        public TransmissionTypes TransmissionType { get; set; }
        public DriveTypes DriveType { get; set; }
        public int GenerationId { get; set; }
        public string PhoneNumber { get; set; }
        public List<Models.Photo> Photos { get; set; }
        public List<Models.AdvertEquipment> AdvertEquipments { get; set; }
    }
}
