using System;
using System.Collections.Generic;
using System.Text;
using static Ex03.GarageLogic.GasEngine;
using static Ex03.GarageLogic.VehicleTicket;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private readonly Dictionary<string, VehicleTicket> m_LicenseNumberToVehicleTicketDict;

        public Garage()
        {
            this.m_LicenseNumberToVehicleTicketDict = new Dictionary<string, VehicleTicket>();
        }


        // the function returns true if the vehicle is already in the garage
        // if not - it inserts it
        public bool Add (VehicleTicket i_VehicleToAdd)
        {
            bool isInTheGarage = isVehicleInTheGarage(i_VehicleToAdd);

            if (isInTheGarage)
            {
                this.m_LicenseNumberToVehicleTicketDict[i_VehicleToAdd.Vehicle.LicenseNumber].Status
                    = eVehicleStatus.InProgress;
            }
            else
            {
                this.m_LicenseNumberToVehicleTicketDict.Add(i_VehicleToAdd.Vehicle.LicenseNumber, i_VehicleToAdd);
            }

            return isInTheGarage;
        }

        private bool isVehicleInTheGarage (VehicleTicket i_VehicleToCheck)
        {
            bool isInTheGarage = false;
            if (this.m_LicenseNumberToVehicleTicketDict.ContainsKey(i_VehicleToCheck.Vehicle.LicenseNumber))
            {
                isInTheGarage = true;
            }
            return isInTheGarage;
        }

        public List<string> GetLicenseNumberOfAllVehicles ()
        {
            List<string> licenseNumbers = new List<string>();

            foreach (KeyValuePair<string, VehicleTicket> currentVehicleTicket in this.m_LicenseNumberToVehicleTicketDict)
            {
                    licenseNumbers.Add(currentVehicleTicket.Key);
            }
            return licenseNumbers;
        }

        public List<String> GetLicenseOfAllVehiclesWithSpecificStatus (eVehicleStatus i_StatusOfVehicle)
        {
            List<string> licenseNumbers = new List<string>();

            foreach (KeyValuePair<string,VehicleTicket> currentVehicleTicket in this.m_LicenseNumberToVehicleTicketDict)
            {
                if (currentVehicleTicket.Value.Status.Equals(i_StatusOfVehicle))
                {
                    licenseNumbers.Add(currentVehicleTicket.Key);
                }
            }
            return licenseNumbers;
        }

        public void ChangeVehicleStatus (string i_LicenseNumber, eVehicleStatus i_NewStatus)
        {
            this.m_LicenseNumberToVehicleTicketDict[i_LicenseNumber].Status = i_NewStatus;
        }

        public void InflateAirInAllWheelsOfCar (string i_LicenseNumber)
        {
           foreach(Wheel wheelToInflate in this.m_LicenseNumberToVehicleTicketDict[i_LicenseNumber].Vehicle.Wheels)
            {
                wheelToInflate.Inflate(wheelToInflate.MaxAirPressure);
            }
        }

        //NTC
        public void AddFuelToVehicle (string i_LicenseNumber, eGasType i_GasType, float i_AmountToAdd)
        {
            //this.m_LicenseNumberToVehicleTicketDict[i_LicenseNumber].Vehicle.
        }

        // NTC
        public void ChargeElectricVehicle (string i_LicenseNumber, float i_AmountOfMinutesToAdd)
        {

        }

        // NTC
        public void GetAllInformationOfVehicle (string i_LicenseNumber)
        {
            //VehicleTicket currentVehicleTicket = this.m_LicenseNumberToVehicleTicketDict[i_LicenseNumber];

            //StringBuilder vehicleInformation = new StringBuilder();

            //vehicleInformation.Append(currentVehicleTicket.ToString());

            //return vehicleInformation.ToString();
        }
    }
}
