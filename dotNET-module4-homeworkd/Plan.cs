using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module4_homeworkd
{
    using System;

    public partial class Plane
    {
        private string model;
        private int passengerCapacity;
        private double maxSpeed;
        private bool isFlying;
        private static int totalPlanes;
        private static string companyName;

        public Plane()
        {
            model = "Unknown";
            passengerCapacity = 0;
            maxSpeed = 0.0;
            isFlying = false;
            totalPlanes++;
        }

        public Plane(string model, int passengerCapacity, double maxSpeed)
        {
            this.model = model;
            this.passengerCapacity = passengerCapacity;
            this.maxSpeed = maxSpeed;
            isFlying = false;
            totalPlanes++;
        }

        public string GetModel()
        {
            return model;
        }

        public int GetPassengerCapacity()
        {
            return passengerCapacity;
        }

        public double GetMaxSpeed()
        {
            return maxSpeed;
        }

        public bool IsFlying()
        {
            return isFlying;
        }

        public void SetIsFlying(bool flying)
        {
            isFlying = flying;
        }

        public void UpdateDetails(ref string newModel, ref int newPassengerCapacity, ref double newMaxSpeed)
        {
            model = newModel;
            passengerCapacity = newPassengerCapacity;
            maxSpeed = newMaxSpeed;
        }

        public static int TotalPlanes
        {
            get { return totalPlanes; }
        }

        public static string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        static Plane()
        {
            companyName = "Без названия";
            totalPlanes = 0;
        }

        partial void AdditionalMethod();
    }

}
