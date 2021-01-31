using System;

namespace vahicle 
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCompaire objCars = new CarCompaire();
            CarCompaire objCars2 = new CarCompaire();

            objCars.carName = "Hyundai Creta";
            objCars.fuelType = "Disel";
            objCars.Mileage = 15;
            objCars.onRoadPrice = 123456;
            objCars.PowerWindows = "Yes";
            objCars.SteeringType = "Power";
            objCars.MGf = 2011;
            objCars.CC = 1100;

            Console.WriteLine("\n" + objCars.carName);
            Console.WriteLine("\n" + objCars.fuelType);
            Console.WriteLine("\n" + objCars.Mileage);
            Console.WriteLine("\n" + objCars.onRoadPrice);
            Console.WriteLine("\n" + objCars.PowerWindows);
            Console.WriteLine("\n" + objCars.SteeringType);
            Console.WriteLine("\n" + objCars.MGf);
            Console.WriteLine("\n" + objCars.CC);
            Console.WriteLine("\n" + objCars.isExpired(objCars.MGf));

            objCars2.carName = "Hyundai Venue";
            objCars2.fuelType = "Disel";
            objCars2.Mileage = 19;
            objCars2.onRoadPrice = 123455;
            objCars2.PowerWindows = "Yes";
            objCars2.SteeringType = "Power";
            objCars2.MGf = 2019;
            objCars2.CC = 1200;

            Console.WriteLine("\n" + objCars2.carName);
            Console.WriteLine("\n" + objCars2.fuelType);
            Console.WriteLine("\n" + objCars2.Mileage);
            Console.WriteLine("\n" + objCars2.onRoadPrice);
            Console.WriteLine("\n" + objCars2.PowerWindows);
            Console.WriteLine("\n" + objCars2.SteeringType);
            Console.WriteLine("\n" + objCars2.MGf);
            Console.WriteLine("\n" + objCars2.CC);
            Console.WriteLine("\n" + objCars2.isExpired(objCars.MGf));

            if (objCars.Mileage <= objCars2.Mileage && objCars.onRoadPrice <= objCars2.onRoadPrice)
            {
                Console.WriteLine("You are choose Hyundai Creta is best");
            }
            else {
                Console.WriteLine("You are choose Hyundai Venue is best");
            }
        }
        class CarCompaire
        {
            internal int onRoadPrice { get; set; }
            internal string carName { get; set; }
            internal string fuelType { get; set; }
            internal int CC { get; set; }
            internal int Mileage { get; set; }
            internal string SteeringType { get; set; }
            internal String PowerWindows { get; set; }
            internal int MGf { get; set; }

            public bool isExpired(int year)
            {
                bool expire = false;

                if (year > 2015)
                {
                    expire = true;
                }
                else
                {
                    expire = false;
                }
                return expire;
            }

            
        }
        
          
        }
        }



