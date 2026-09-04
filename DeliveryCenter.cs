using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal class DeliveryCenter
    {
        #region field
        private Shipment[] shipments;
        #endregion
        #region constructor
        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }

        #endregion
        #region properties
        //integer indexer
        public Shipment this[int position]
        {
            get
            {
                if (shipments != null && position >= 0 && position < 10)
                    return shipments[position];
                return default;
            }
            set
            {
                if (shipments != null && position >= 0 && position < 10)
                    shipments[position] = value;
            }
        }
        //string indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments != null)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (shipments[i].TrackingCode == trackingCode)
                        {
                            return shipments[i];

                        }


                    }
                }
                return default;
            }

        }

        #endregion
        #region method
        public bool AddShipment(Shipment shipment)
        {
            if (shipments != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (shipments[i].TrackingCode is null)
                    {
                        shipments[i] = shipment;
                        return true;
                    }

                }

            }
            return false;


        }
        #endregion
    }
}
