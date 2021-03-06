﻿using System;
using System.Collections.Generic;
using System.Text;
using ParkingLot;
using Xunit;

namespace ParkingLotTest
{
    public class SuperSmartParkingBoyTest
    {
        [Fact]
        public void Should_Return_ticket_Super_Smart_Parking_Boy()
        {
            //given
            var parkingLot1 = new ParkingLot.ParkingLot(1, 3);
            var parkingLot2 = new ParkingLot.ParkingLot(2, 4);
            var parkingLotList = new List<ParkingLot.ParkingLot>
            {
                parkingLot1,
                parkingLot2,
            };
            //when
            var parkingBoy = new SuperSmartParkingBoy(parkingLotList);
            var ticket0 = parkingBoy.ParkACarAndGetTicket("abc123");
            var ticket1 = parkingBoy.ParkACarAndGetTicket("abc123");
            var ticket2 = parkingBoy.ParkACarAndGetTicket("abc124");
            var expectedTicket = new Ticket("abc124", 2);
            //then
            Assert.Equal(expectedTicket.GetParkingLotNumber(), ticket2.GetParkingLotNumber());
        }
    }
}
