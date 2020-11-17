﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Models
{
    public enum Fuel
    {
        Diesel,
        Petrol,
        Electric,
        LPG
    }
    public enum Condition
    {
        Damaged,
        Undamaged
    }
    public enum DriveType
    {
        FWD,
        RWD,
        AWD
    }
    public class AdvertDetails
    {
        public int Id { get; set; }
        public int AdvertId { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public int CarProductionDate { get; set; }
        public Fuel Fuel { get; set; }
        public Condition Condition { get; set; }
        public int Horsepower { get; set; }
        public int Displacement { get; set; }
        public string Location { get; set; }
        public bool HasBeenCrashed { get; set; }
        public bool AutomaticTransmisson { get; set; }
        public DriveType DriveType { get; set; }
        public int VisitCount { get; set; }
        public Advert Advert { get; set; }
    }
}
