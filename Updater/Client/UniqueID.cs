using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace ClientUpdater
{
    class UniqueID
    {
        public int CPUID;
        public int MBID;

        public int UNID;

        public UniqueID(){}

        public int GetCPUID()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            

            foreach (ManagementObject mo in moc)
            {
                CPUID = mo.Properties["processorID"].Value.GetHashCode();
                break;
            }
            return CPUID;
        }

        public int GetBoardID()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
           
            foreach (ManagementObject mo in moc)
            {
                MBID = mo["SerialNumber"].GetHashCode();
            }
            return MBID;
        }

        public int GenerateUniqueID()
        {
            UNID = GetCPUID() + GetBoardID();
            return UNID;
        }
    }
}
