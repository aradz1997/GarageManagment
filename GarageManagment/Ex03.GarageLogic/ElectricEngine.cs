using System;
namespace Ex03.GarageLogic
{
    public class ElectricEngine
    {
        private float m_NumOfHoursLeftForBattery;
        private readonly float m_MaximumBatteryLifeInHours;

        public ElectricEngine(float i_NumOfHoursLeftForBattery, float i_MaximumBatteryLifeInHours)
        {
            this.m_NumOfHoursLeftForBattery = i_NumOfHoursLeftForBattery;
            this.m_MaximumBatteryLifeInHours = i_MaximumBatteryLifeInHours;
        }

        public float NumOfHoursLeftForBattery
        {
            get { return this.m_NumOfHoursLeftForBattery; }
        }

        public void Charge (float i_NumberOfHoursToAddToBattery)
        {
            this.m_NumOfHoursLeftForBattery = i_NumberOfHoursToAddToBattery;
        }

        public float MaximumBatteryLifeInhours
        {
            get { return this.m_MaximumBatteryLifeInHours; }
        }

        public override string ToString()
        {
            return string.Format("Number of hours left for battery: {1}{0} Maximum hours of life for battery:{2}{0}",
                Environment.NewLine, this.m_NumOfHoursLeftForBattery, this.m_MaximumBatteryLifeInHours);
        }
    }
}
