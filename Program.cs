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
            #region Test Program
            //1-create DeliveryCenter
            //2 read CenterName
            Console.Write("Enter CenterName: ");
            string centerName = Console.ReadLine();
            DeliveryCenter deliveryCenter = new DeliveryCenter(centerName);

            //3,4,5,6 create shipments and read
            StandardShipment standardShipment = new StandardShipment("S01", "PC", 10, 80, new DeliveryAddress("Cairo", "Nasser", 9));

            ExpressShipment expressShipment= new ExpressShipment(30,"S02", "Tv", 8, 80, new DeliveryAddress("Cairo", "Orabi", 8));
           
            InternationalShipment internationalShipment = new InternationalShipment("America",10,"S03", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Maadi", 7));

            //7-add shipments
            Console.WriteLine("\n");
            bool addStandardShipment= deliveryCenter.AddShipment(standardShipment);
            if(addStandardShipment==true)
                Console.WriteLine("StandardShipment added sucessfully");

           bool addExpressShipment= deliveryCenter.AddShipment(expressShipment);
            if (addExpressShipment == true)
                Console.WriteLine("ExpressShipment added sucessfully");

           bool addInternationalShipment= deliveryCenter.AddShipment(internationalShipment);
            if (addInternationalShipment == true)
                Console.WriteLine("InternationalShipment added sucessfully");


            //8-print All Shipments
            Console.WriteLine("\n");
            Console.WriteLine("print shipments");
            deliveryCenter.PrintAllShipments();

            //9-search using trackingCode
            Console.WriteLine("\n");
            Console.Write("Enter TrackingCode to search: ");
            string trackingCode = Console.ReadLine();
           
            
                Shipment shipment = deliveryCenter[trackingCode];
            Console.WriteLine("\nretrieving shipment........");
            if (shipment != null)
                    shipment.PrintShipment();
            else
                Console.WriteLine("\nshipment not found");

            //10-remove shipment
            Console.WriteLine("\n");
            Console.Write("Enter TrackingCode to remove:");
            bool removeShipment =deliveryCenter.RemoveShipment(Console.ReadLine());
            if (removeShipment == true)
                Console.WriteLine("\nShipment removed sucessfully");

            //11-print remaining shipments
            Console.WriteLine("\nprint remaining shipments");
            deliveryCenter.PrintAllShipments();

            #endregion
        }
    }
}
