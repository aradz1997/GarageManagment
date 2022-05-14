using System;
using System.Collections.Generic;
using static Ex03.GarageLogic.GasEngine;

namespace Ex03.GarageLogic
{
    public class RegularCar : AbstractFourWheelsPlus
    {
        private GasEngine m_Engine;

        public RegularCar(eGasType i_GasType, float i_CurrentGasAmount, float i_MaxGasPossible, eColors i_VehicleColor, eNumOfDoors i_NumOfDoors,
            string i_ModelName, string i_LicenseNumber, float i_CurrentEnergyRemaining, List<Wheel> i_Wheels)
            : base(i_VehicleColor, i_NumOfDoors, i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_Wheels)
        {
            m_Engine = new GasEngine(i_GasType, i_CurrentGasAmount, i_MaxGasPossible);
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
