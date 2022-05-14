using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : AbstractMotorcycle
    {
        ElectricEngine m_Engine;

        public ElectricMotorcycle(float i_CurrentBatteryLife, float i_MaxBatteryLife, string i_ModelName,
            string i_LicenseNumber, float i_CurrentEnergyRemaining,eLicenseType i_LicenseType, int i_EnergyCapacity, List<Wheel> i_Wheels)
            : base(i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_LicenseType, i_EnergyCapacity, i_Wheels)
        {
            this.m_Engine = new ElectricEngine(i_CurrentBatteryLife, i_MaxBatteryLife);
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
