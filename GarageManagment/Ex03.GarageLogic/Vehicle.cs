using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {

        private readonly string m_ModelName;
        private readonly string m_LicenseNumber;
        private float m_PrecentageRemainingEnergy;
        private List<Wheel> m_Wheels;

        public Vehicle(string i_ModelName, string i_LicenseNumber, float i_CurrentEnergyRemaining, List<Wheel> i_Wheels)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_PrecentageRemainingEnergy = i_CurrentEnergyRemaining;
            this.m_Wheels = i_Wheels;
        }

        public string ModelName
        {
            get { return this.m_ModelName; }
        }

        public string LicenseNumber
        {
            get { return this.m_LicenseNumber; }
        }

        public float RemainingEnergy
        {
            get { return this.m_PrecentageRemainingEnergy; }
            set { this.m_PrecentageRemainingEnergy = value; }
        }

        public List<Wheel> Wheels
        {
            get { return this.m_Wheels; }
        }

        public override string ToString()
        {
            string listOfWheels = this.listOfAllWheelsAsString();
            return string.Format("Model name: {0} {3}License Number: {1} {3}Wheels Information: {2} {3}",
                this.m_ModelName, this.m_LicenseNumber, listOfWheels.ToString(), Environment.NewLine);
        }

        public string listOfAllWheelsAsString()
        {
            StringBuilder wheelsInformation = new StringBuilder();
            foreach (Wheel wheel in this.m_Wheels)
            {
                wheelsInformation.Append(wheel.ToString());
                wheelsInformation.Append(Environment.NewLine);
            }
            return wheelsInformation.ToString();
        }
    }
}
