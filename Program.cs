namespace AssignmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            //Question1
            //a-struct:is a value type , the variables created from it is independent(holds data),modify by one of the doesn't affect the other after assignment(each has own place)
            //class:is a reference type , the variables created from it is dependent(holds reference),modify by one of the affect the other after assignment(same reference=>same object)
            //b-class is suitable for large applications than struct,class is long lived in memory which make it appropriate to complex data,class supports inheritance unlike struct
            //
            //Question2
            //a-Parent:Shipment
            //b-Child:ExpressShipment
            //c-inherited member:TrackingCode
            //D-maintainability and reusability:modify the inherited menbers in single unit(parent class)
            #endregion
            #region demonstrate inheritance relationships
            //first way
           // StandardShipment standardShipment = new StandardShipment("S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9));
           // standardShipment.Weight = 8; //property is visible by child

           // ExpressShipment expressShipment= new ExpressShipment(30,"S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9));
           // expressShipment.Weight = 8; //property is visible by child

           //InternationalShipment internationalShipment = new InternationalShipment("America",10,"S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9));
           // internationalShipment.Weight = 8; //property is visible by child

            //another way
            //Shipment s1 = new StandardShipment("S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9)); //approved (reference from parent to object from child)
            //Shipment s2 = new ExpressShipment(30,"S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9)); //approved (reference from parent to object from child)
            //Shipment s3 = new InternationalShipment("America",10,"S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9)); //approved (reference from parent to object from child)
            #endregion
        }
    }
}
