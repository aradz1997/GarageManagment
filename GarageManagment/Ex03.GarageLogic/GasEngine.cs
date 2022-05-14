using System;
namespace Ex03.GarageLogic
{
    public class GasEngine
    {
        public enum eGasType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }

        private readonly eGasType m_GasType;
        private float m_CurrentGasAmount;
        private readonly float m_MaxGasPossible;

        public GasEngine(eGasType i_GasType, float i_CurrentGasAmount, float i_MaxGasPossible)
        {
            this.m_GasType = i_GasType;
            this.m_CurrentGasAmount = i_CurrentGasAmount;
            this.m_MaxGasPossible = i_MaxGasPossible;
        }

        public eGasType GasType
        {
            get { return this.m_GasType; }
        }

        public float MaxGasPossible
        {
            get { return this.m_MaxGasPossible; }
        }

        public float CurrentGasAmount
        {
            get { return this.m_CurrentGasAmount; }
        }

        // Talk about diff names for set and get 
        public float Refuel 
        {
            set { this.m_CurrentGasAmount = value; }
        }

        public override string ToString()
        {
            return string.Format("Gas Type: {1}{0}Current gas amount:{2}{0}Max gas amount possible{3}{0}",
                Environment.NewLine, this.m_GasType, this.m_CurrentGasAmount, this.m_MaxGasPossible);
        }
    }
}
