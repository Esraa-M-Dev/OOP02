using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal class Shipment
    {
        #region Fields
        // private string trackingCode; //backing field
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        #endregion
        #region Properties
        public string TrackingCode { get; }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }
        public DeliveryAddress Destination { get; set; }
        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5);
        #endregion
        #region Constructors

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                TrackingCode = trackingCode;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public Shipment(string trackingCode):this(trackingCode,"unknown",1,50,new DeliveryAddress("un known","unknown",0))
        {
           
          
        }
       
        #endregion
        #region methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"TrackingCode:{TrackingCode}");
            Console.WriteLine($"Description:{Description}");
            Console.WriteLine($"Weight:{Weight}");
            Console.WriteLine($"DeliveryFee:{DeliveryFee}");
            Console.WriteLine($"Destination:{Destination.GetFullAdress()}");
            Console.WriteLine($"EstimatedCost:{EstimatedCost}");


        }
        #endregion
    }
}
