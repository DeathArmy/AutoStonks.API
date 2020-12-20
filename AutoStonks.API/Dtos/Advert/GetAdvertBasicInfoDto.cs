using AutoStonks.API.Dtos.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Advert
{
    public class GetAdvertBasicInfoDto
    {
        public enum States
        {
            New, //Dodane, nieopłacone
            Active, //Dodane, opłacone
            Expired,
            Terminated
        }
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
        public int Id { get; set; }
        public bool IsPromoted { get; set; }
        public States State { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public DateTime CarProductionDate { get; set; }
        public FuelType Fuel { get; set; }
        public ConditionState Condition { get; set; }
        public int Horsepower { get; set; }
        public string Title { get; set; }
        public int Displacement { get; set; }
        public string Location { get; set; }
        public int GenerationId { get; set; }
        public PlainGenerationDto Generation { get; set; }
        public List<Models.Photo> Photos { get; set; }
    }
}