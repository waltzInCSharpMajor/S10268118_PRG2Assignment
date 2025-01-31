﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10268118_PRG2Assignment
{
    //==========================================================
    // Student Number : S10268118
    // Student Name : Ryan Wee Wei Yan
    // Partner Name : Ong Yong Sheng
    //==========================================================

    public abstract class Flight : IComparable<Flight>
    {
        private string _flightNumber;

        public string FlightNumber
        {
            get { return _flightNumber; }
            set { _flightNumber = value; }
        }

        private string _origin;

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        private string _destination;

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        private DateTime _expectedTime;

        public DateTime ExpectedTime
        {
            get { return _expectedTime; }
            set { _expectedTime = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public abstract double CalculateFees();

        public int CompareTo(Flight? other)
        {
            if (other == null) return 1;
            return this.ExpectedTime.CompareTo(other.ExpectedTime);
        }

        public override string ToString()
        {
            return $"Flight Number {FlightNumber}\nOrigin: {Origin}\nDestination: {Destination}\nExpected Time: {ExpectedTime}\nStatus: {Status}";
        }

        public Flight(
            string flightNumber,
            string origin,
            string destination,
            DateTime expectedTime,
            string status
        )
        {
            FlightNumber = flightNumber;
            Origin = origin;
            Destination = destination;
            ExpectedTime = expectedTime;
            Status = status;
        }
    }
}
