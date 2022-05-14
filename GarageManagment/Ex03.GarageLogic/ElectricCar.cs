using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class ElectricCar : AbstractFourWheelsPlus
    {
        private ElectricEngine m_Engine;

        public ElectricCar(float i_CurrentBatteryLife, float i_MaxBatteryLife, eColors i_VehicleColor, eNumOfDoors i_NumOfDoors,
            string i_ModelName, string i_LicenseNumber, float i_CurrentEnergyRemaining, List<Wheel> i_Wheels)
            : base(i_VehicleColor ,i_NumOfDoors ,i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_Wheels)
        {
            m_Engine = new ElectricEngine(i_CurrentBatteryLife, i_MaxBatteryLife);
        }
        public ElectricEngine Engine
        {
            get { return this.m_Engine; }
        }

        public override string ToString()
        {
            return string.Format("{1} {0} Electric Engine {0} Engine Information: {0} {2}"
                , Environment.NewLine, base.ToString(), this.m_Engine.ToString());
        }
    }
}
