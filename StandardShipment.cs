using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal class StandardShipment:Shipment
    {

        //chaining
        #region constructor
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliverFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliverFee, destination)
        {

        } 
        #endregion
    }
}
