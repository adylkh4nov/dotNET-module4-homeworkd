using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNET_module4_homeworkd;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Plane.CompanyName = "Panam Airlines";

            Plane[] planes = new Plane[5];
            planes[0] = new Plane("Boeing 747", 400, 560.5);
            planes[1] = new Plane("Airbus A320", 150, 530.2);
            planes[2] = new Plane("Boeing 777", 550, 590.0);
            planes[3] = new Plane("Embraer E190", 100, 490.8);
            planes[4] = new Plane();

            Console.WriteLine($"Total planes created: {Plane.TotalPlanes}");

            Console.WriteLine($"First plane model: {planes[0].GetModel()}");
            Console.WriteLine($"Is the first plane flying? {planes[0].IsFlying()}");
            planes[0].SetIsFlying(true);
            Console.WriteLine($"Is the first plane flying now? {planes[0].IsFlying()}");

            string newModel = "Boeing 737";
            int newPassengerCapacity = 180;
            double newMaxSpeed = 550.9;
            planes[1].UpdateDetails(ref newModel, ref newPassengerCapacity, ref newMaxSpeed);
            Console.WriteLine($"Updated details of the second plane: {planes[1].GetModel()}, {planes[1].GetPassengerCapacity()}, {planes[1].GetMaxSpeed()}");
        }
    }
}
