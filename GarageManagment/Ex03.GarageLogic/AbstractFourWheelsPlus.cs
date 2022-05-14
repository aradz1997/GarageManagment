using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class AbstractFourWheelsPlus : Vehicle
    {
        public enum eColors
        {
            White,
            Red,
            Blue,
            Green
        }

        public enum eNumOfDoors
        {
            Two,
            Three,
            Four,
            Five
        }

        private readonly eColors m_VehicleColor;
        private readonly eNumOfDoors m_NumOfDoors;

        public AbstractFourWheelsPlus(eColors i_VehicleColor, eNumOfDoors i_NumOfDoors,
            string i_ModelName, string i_LicenseNumber, float i_CurrentEnergyRemaining, List<Wheel> i_Wheels)
            : base(i_ModelName, i_LicenseNumber, i_CurrentEnergyRemaining, i_Wheels) 
        {
            this.m_VehicleColor = i_VehicleColor;
            this.m_NumOfDoors = i_NumOfDoors;
        }

        public override string ToString()
        {
            return string.Format("{1}{0}Vehicle color:{2}{0}Number of doors:{3}{0}",
                Environment.NewLine, base.ToString(), this.m_VehicleColor, this.m_NumOfDoors);
        }
    }
}
