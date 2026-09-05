using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP02
{
    internal struct DeliveryAddress
    {
        #region fields
        public string? city;
        public string? street;
        public int buildingNumber;


        #endregion
        #region Constructor
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.buildingNumber = buildingNumber;
        }

        #endregion
        #region Method
        public string GetFullAdress()
        {
            return $"{buildingNumber},{street},{city}";
        }
        #endregion
    }
}
