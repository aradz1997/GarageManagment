using System;
using System.Collections.Generic;
using static Ex03.GarageLogic.GasEngine;

namespace Ex03.GarageLogic
{
    public class RegularMotorcycle : AbstractMotorcycle
    {
        private GasEngine m_Engine;

        public RegularMotorcycle(eGasType i_GasType, float i_CurrentGasAmount, float i_MaxGasAmount, string i_ModelName,
            string i_LicenseNumber, float i_CurrentEnergyRemaining, eLicenseType i_LicenseType, int i_EnergyCapacity, List<Wheel> i_Wheels)
            : base(i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_LicenseType, i_EnergyCapacity, i_Wheels)
        {
            m_Engine = new GasEngine(i_GasType, i_CurrentGasAmount, i_MaxGasAmount);
        }

        public GasEngine Engine
        {
            get { return this.m_Engine; }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", base.ToString(), this.m_Engine.ToString());
        }
    }
}
