using System; 

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO       

          


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            
            var carOne = new Car();
            carOne.Make = "Ferrari";
            carOne.Model = "Italia";
            carOne.Year = 2022;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");
            
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            
            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Lamborghini",
                Model = "Huracan",
                Year = 2022, IsDriveable = true,
            };
            
            carTwo.MakeEngineNoise("Roar");
            carTwo.MakeHonkNoise("Beep");
            
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            carLotOne.ParkingLot.Add(carTwo);
            
            var carThree = new Car("Strudebaker", "Champion", 1991, true);
            
            carThree.MakeHonkNoise("Vroom Vroom");
            carThree.MakeHonkNoise("Beep Beep");
            
            Console.WriteLine($"Cars created: {CarLot._numberOfCars}");
            
            carLotOne.ParkingLot.Add(carThree);
            



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotOne.CheckCars();
        }
    }
}
