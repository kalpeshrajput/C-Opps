using System;

namespace MobileComparision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                setMobileDetails();
            }
        }
                                        
        static void setMobileDetails()
        {
            Mobile objMobile = new Mobile();
           /* Console.WriteLine("Enter Mobile name");
            objMobile.MobileName = Console.ReadLine();

            Console.WriteLine("Enter Mobile diplay Screen");
            objMobile.diplayScreen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile processor");
            objMobile.processor = Console.ReadLine();

            Console.WriteLine("Enter Mobile front Camera");
            objMobile.frontCamera = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile rear Camera");
            objMobile.rearCamera = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Mobile RAM ");
            objMobile.RAM = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Mobile storage ");
            objMobile.storage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile Expandable storage ");
            objMobile.Expandablestorage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile  BatteryCapacity ");
            objMobile.BatteryCapacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile OS");
            objMobile.OS = Console.ReadLine();

            Console.WriteLine("Enter Mobile Screensize");
            objMobile.Screensize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile resolution");
            objMobile.resolution = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile number Of Sim");
            objMobile.numberOfSim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile fourG_LTE");
            objMobile.fourG_LTE = Console.ReadLine();

            */
            Console.WriteLine("Enter Mobile MGFYear");
            objMobile.MGFYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile warranty Year");
            objMobile.warrantyYear = Convert.ToInt32(Console.ReadLine());

            objMobile.result = objMobile.MGFYear + objMobile.warrantyYear;

            

            printMobileDetails(objMobile);

        }

        
        static void printMobileDetails(Mobile objMobile)
        {
            Console.WriteLine("You are Entered details");
            Console.WriteLine(objMobile.MobileName);
            Console.WriteLine(objMobile.diplayScreen);
            Console.WriteLine(objMobile.processor);
            Console.WriteLine(objMobile.frontCamera);
            Console.WriteLine(objMobile.rearCamera);
            Console.WriteLine(objMobile.RAM);
            Console.WriteLine(objMobile.storage);
            Console.WriteLine(objMobile.Expandablestorage);
            Console.WriteLine(objMobile.BatteryCapacity);
            Console.WriteLine(objMobile.OS);
            Console.WriteLine(objMobile.Screensize);
            Console.WriteLine(objMobile.resolution);
            Console.WriteLine(objMobile.numberOfSim);
            Console.WriteLine(objMobile.fourG_LTE);
            Console.WriteLine(objMobile.MGFYear);
            Console.WriteLine(objMobile.warrantyYear);
            objMobile.checkWarranty(objMobile.MGFYear, objMobile.warrantyYear);
        }

    }
    public class Mobile {
        internal string MobileName { get; set; }
        internal int diplayScreen { get; set; }
        internal string processor { get; set; }
        internal int frontCamera { get; set; }
        internal int rearCamera { get; set; }
        internal int RAM { get; set; }
        internal int storage { get; set; }
        internal int Expandablestorage { get; set; }
        internal int BatteryCapacity { get; set; }
        internal string OS { get; set; }
        internal int Screensize { get; set; }
        internal int resolution { get; set; }
        internal int numberOfSim { get; set; }
        internal string fourG_LTE { get; set; }
        internal int MGFYear { get; set; }
        internal int warrantyYear { get; set; }
        internal int result { get; set; }

        public void checkWarranty(int MGFYear, int warrantyYear)
        {
            int isUnderWarranty = MGFYear + warrantyYear;

            if (isUnderWarranty <= 2018)
            {
                Console.WriteLine("Your mobile is in warranty");
               
            }
            else
            {
                Console.WriteLine("Your mobile is not warrenty");
                
            }
           
        }
    }
} 
    


