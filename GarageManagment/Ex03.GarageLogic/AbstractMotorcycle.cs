using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class AbstractMotorcycle : Vehicle
    {
        public enum eLicenseType
        {
            A,
            A1,
            B1,
            BB
        }

        private readonly eLicenseType m_LicenseType;
        private int m_EnergyCapacity;

        public AbstractMotorcycle(string i_ModelName, string i_LicenseNumber, float i_CurrentEnergyRemaining,
            eLicenseType i_LicenseType, int i_EnergyCapacity, List<Wheel> i_Wheels) : base(i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_Wheels)
        {
            this.m_LicenseType = i_LicenseType;
            this.m_EnergyCapacity = i_EnergyCapacity;
        }

        public override string ToString()
        {
            return string.Format("{1}{0}License Type: {2}{0}Energy capacity:{3}{0}"
                , Environment.NewLine, base.ToString(), this.m_LicenseType, this.m_EnergyCapacity);
        }
    }
}
