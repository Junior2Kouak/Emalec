using System.Net.NetworkInformation;

public class CVpnDetector
{
    public static bool IsVpnConnected()
    {
        NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        NetworkInterface[] array = allNetworkInterfaces;
        foreach (NetworkInterface networkInterface in array)
        {
            if (networkInterface.OperationalStatus == OperationalStatus.Up)
            {
                NetworkInterfaceType networkInterfaceType = networkInterface.NetworkInterfaceType;
                string text = networkInterface.Description.ToLower();
                string text2 = networkInterface.Name.ToLower();
                if ((networkInterfaceType == NetworkInterfaceType.Ppp || networkInterfaceType == NetworkInterfaceType.Tunnel) && !text.Contains("loopback") && !text.Contains("teredo") && !text.Contains("isatap"))
                {
                    return true;
                }

                if (text.Contains("sophos") || text2.Contains("sophos"))
                {
                    return true;
                }
            }
        }

        return false;
    }
}