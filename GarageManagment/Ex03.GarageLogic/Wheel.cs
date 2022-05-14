using System;
namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private readonly string m_ManufacturerName;
        float m_CurrentAirPressure;
        private readonly float  m_MaxAirPressure;

        public Wheel(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            this.m_ManufacturerName = i_ManufacturerName;
            this.m_CurrentAirPressure = i_CurrentAirPressure;
            this.m_MaxAirPressure = i_MaxAirPressure;
        }

        public float MaxAirPressure
        {
            get { return this.m_MaxAirPressure; }
        }

        public string ManufacturerName
        {
            get { return this.m_ManufacturerName; }
        } 

        public float CurrentAirPressure
        {
            get { return this.m_CurrentAirPressure; }
        }

        public void Inflate (float i_AmountOfAirToAdd)
        {
            this.m_CurrentAirPressure = i_AmountOfAirToAdd;
        }

        public Wheel ShalowClone ()
        {
            return this.MemberwiseClone() as Wheel;
        }

        public override string ToString()
        {
            return string.Format("Manufacturer name: {0} {2}Current air pressure: {1} {2}"
                , this.m_ManufacturerName, this.m_CurrentAirPressure, Environment.NewLine);
        }


    }
}
