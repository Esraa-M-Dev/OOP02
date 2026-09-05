using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal class DeliveryCenter
    {
        #region field
        private Shipment[] shipments;
        private string centerName=null!;
        #endregion
        #region constructor
        public DeliveryCenter(string centerName)
        {
            shipments = new Shipment[20];
            CenterName= centerName;
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
        public string CenterName { get; }

        #endregion
        #region method
        public bool AddShipment(Shipment shipment)
        {
            if (shipments != null)
            {
                for (int i = 0; i < 20; i++)
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
        public bool RemoveShipment(string trackingCode)
        {
            if (shipments != null)
            {
                for(int i = 0; i < 20; i++)
                {
                    if (shipments[i]!=null && shipments[i].TrackingCode == trackingCode)
                    {
                        shipments[i] = null;
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            if (shipments != null)
            {
                for(int i = 0; i < 20; i++)
                {
                    if (shipments[i] != null)
                        shipments[i].PrintShipment();
                }
            }
           
            
        }

        #endregion
    }
}
