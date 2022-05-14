using System;
namespace Ex03.GarageLogic
{
    public class VehicleTicket
    {
        public enum eVehicleStatus
        {
            InProgress,
            Repaired,
            Paid
        }

        private readonly Vehicle m_Vehicle;
        private readonly string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private eVehicleStatus m_Status;

        public VehicleTicket(Vehicle i_VehicleToAdd, string i_OwnerName, string i_OwnerNumber)
        {
            this.m_Vehicle = i_VehicleToAdd;
            this.m_OwnerName = i_OwnerName;
            this.m_OwnerPhoneNumber = i_OwnerNumber;
            this.m_Status = eVehicleStatus.InProgress;
        }

        public Vehicle Vehicle
        {
            get { return this.m_Vehicle; }
        }

        public string Owner
        {
            get { return this.m_OwnerName; }
        }

        public string OwnerPhoneNumber
        {
            get { return this.m_OwnerPhoneNumber; }
        }

        public eVehicleStatus Status
        {
            get { return this.m_Status; }
            set { this.m_Status = value; }
        }

        public override string ToString()
        {
            return string.Format("Owner Name : {1} {0} Vehicle Status: {2} {0} Vehicle Information: {3} {0} ",
                Environment.NewLine, this.m_OwnerName, this.m_Status, this.m_Vehicle.ToString());
        }
    }
}

