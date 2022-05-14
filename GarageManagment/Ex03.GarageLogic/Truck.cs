using System;
using System.Collections.Generic;
using System.Linq;
using static Ex03.GarageLogic.GasEngine;

namespace Ex03.GarageLogic
{
    public class Truck : AbstractFourWheelsPlus
    {
        private GasEngine m_Engine;
        private bool m_CanTransportColdContents;

        public Truck(eGasType i_GasType, float i_CurrentGasAmount, float i_MaxGasPossible, eColors i_VehicleColor, eNumOfDoors i_NumOfDoors,
            string i_ModelName, string i_LicenseNumber, float i_CurrentEnergyRemaining, List<Wheel> i_Wheels, bool i_CanTransportColdContents)
            : base(i_VehicleColor, i_NumOfDoors, i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_Wheels)
        {
            m_Engine = new GasEngine(i_GasType, i_CurrentGasAmount, i_MaxGasPossible);
            this.m_CanTransportColdContents = i_CanTransportColdContents;
        }

        public GasEngine Engine
        {
            get { return this.m_Engine; }
        }
        public override string ToString()
        {
            string canTransportColdContent;
            if (this.m_CanTransportColdContents)
            {
                canTransportColdContent = "yes";
            }
            else
            {
                canTransportColdContent = "no";
            }

            return string.Format("{0}{1} The car can transport cold contents: {2}{3}",
                base.ToString(), this.m_Engine.ToString(), canTransportColdContent, Environment.NewLine);
        }
    }
}
