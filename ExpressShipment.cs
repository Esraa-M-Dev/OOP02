using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal class ExpressShipment:Shipment
    {
        #region fields
        private decimal extraFee;
        #endregion
        #region properties
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if(value>=0)
                extraFee = value;

            }
        }
        public override decimal EstimatedCost => base.EstimatedCost+ExtraFee;
        #endregion
        #region constructor
        public ExpressShipment(decimal extraFee,string trackingCode,string description,decimal weight,decimal deliveryFee,DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion
    }
}
