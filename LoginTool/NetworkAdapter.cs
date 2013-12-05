using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace LoginTool
{
    sealed class NetworkAdapter
    {
        public delegate void DisplayEventHandler(string s);
        public DisplayEventHandler ShowMessage;

        private static readonly NetworkAdapter instance = new NetworkAdapter();
        public static NetworkAdapter GetInstance()
        {
            return instance;
        }

        private string _macaddress;
        private string[] _ipaddress, _subnetmask, _defaultipgateway, _dnsserver;

        public string MACAddress { get { return _macaddress; } }
        public string[] IPAddress { get { return _ipaddress; } }
        public string[] SubnetMask { get { return _subnetmask; } }
        public string[] DefaultIPGateway { get { return _defaultipgateway; } }
        public string[] DNSServer { get { return _dnsserver; } }

        private NetworkAdapter() { }

        public void GetNetworkAdapter()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"] || "e1express" != (string)mo["ServiceName"])
                    continue;

                _macaddress = (string)mo["MACAddress"];

                _ipaddress = (string[])mo["IPAddress"];
                _subnetmask = (string[])mo["IPSubnet"];
                _defaultipgateway = (string[])mo["DefaultIPGateway"];
                _dnsserver = (string[])mo["DNSServerSearchOrder"];
                break;
            }
        }

        public void SetNetworkAdapter( string ipaddress, 
									   string subnetmask, 
									   string defaultgateway, 
                                       string dnsserver1,
									   string dnsserver2)
        {
            ShowMessage("Setting network configuration...");
            ShowMessage("ip:" + ipaddress);
            ShowMessage("mask:" + subnetmask);
            ShowMessage("gateway:" + defaultgateway);
            ShowMessage("dns_server1:" + dnsserver1);
            ShowMessage("dns_server2:" + dnsserver2);
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"] || "e1express" != (string)mo["ServiceName"])
                    continue;
                try
                {

                    inPar = mo.GetMethodParameters("EnableStatic");
                    inPar["IPAddress"] = new string[] { ipaddress };
                    inPar["SubnetMask"] = new string[] { subnetmask };
                    outPar = mo.InvokeMethod("EnableStatic", inPar, null);

                    inPar = mo.GetMethodParameters("SetGateways");
                    inPar["DefaultIPGateway"] = new string[] { defaultgateway };
                    outPar = mo.InvokeMethod("SetGateways", inPar, null);

                    inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                    inPar["DNSServerSearchOrder"] = new string[] { dnsserver1, dnsserver2 };
                    outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                }
                catch (Exception)
                {
                    throw;
                }
                break;
            }
            ShowMessage("Finished!");
        }
    }
}
