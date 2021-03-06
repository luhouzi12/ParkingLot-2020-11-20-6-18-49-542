﻿using System.Collections.Generic;

namespace ParkingLot
{
    public class ParkingLot
    {
        private readonly int capacity;
        private readonly int parkingLotNumber;
        private readonly List<string> cars = new List<string>();

        public ParkingLot(int parkingLotNumber, int capacity = 10)
        {
            this.capacity = capacity;
            this.parkingLotNumber = parkingLotNumber;
        }

        public int GetParkingLotNumber()
        {
            return parkingLotNumber;
        }

        public void RemoveACar(string license)
        {
            cars.Remove(license);
        }

        public void ParkACar(string license)
        {
            cars.Add(license);
        }

        public bool HasPosition()
        {
            return capacity > cars.Count;
        }

        public int GetAvailablePosition()
        {
            return capacity - cars.Count;
        }

        public bool IsParked(string license)
        {
            return cars.Contains(license);
        }

        public bool IsValidLicense(string license)
        {
            int validLicenseLength = 6;
            return license.Length == validLicenseLength;
        }

        public double GetAvailableRate()
        {
            return ((double)capacity - (double)cars.Count) / (double)capacity;
        }
    }
}
