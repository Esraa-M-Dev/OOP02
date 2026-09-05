using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal class InternationalShipment:Shipment
    {
        #region fields
        private string destinationCountry=null!;
        private decimal customsFee;
        #endregion
        #region properties
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                customsFee = value;
            }
        }
        public override decimal EstimatedCost => base.EstimatedCost+CustomsFee;

        #endregion
        #region constructor
        
        public InternationalShipment(string destinationCountry,decimal customsFee, string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
       
        #endregion
    }
}
