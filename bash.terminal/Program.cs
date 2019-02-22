using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bash.terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PS C:\\WINDOWS\\system32> ");
            string command = Console.ReadLine();

            while (command != "close")
            {
                if (command == "clear")
                {
                    Console.Clear();
                }
                else if (command == "route print")
                {
                    string output = @"===========================================================================
Interface List
 12...ec 8e b5 0c 98 63 ......Realtek PCIe FE Family Controller
 18...46 1c a8 af 13 f7 ......Microsoft Wi-Fi Direct Virtual Adapter
  6...46 1c a8 af 1b f7 ......Microsoft Wi-Fi Direct Virtual Adapter #2
  7...44 1c a8 af 13 f7 ......Broadcom BCM43142 802.11 bgn Wi-Fi M.2 Adapter
 17...44 1c a8 af 13 f8 ......Bluetooth Device (Personal Area Network)
  1...........................Software Loopback Interface 1
===========================================================================

IPv4 Route Table
===========================================================================
Active Routes:
Network Destination        Netmask          Gateway       Interface  Metric
          0.0.0.0          0.0.0.0    192.168.100.1    192.168.100.3     55
        127.0.0.0        255.0.0.0         On-link         127.0.0.1    331
        127.0.0.1  255.255.255.255         On-link         127.0.0.1    331
  127.255.255.255  255.255.255.255         On-link         127.0.0.1    331
    192.168.100.0    255.255.255.0         On-link     192.168.100.3    311
    192.168.100.3  255.255.255.255         On-link     192.168.100.3    311
  192.168.100.255  255.255.255.255         On-link     192.168.100.3    311
        224.0.0.0        240.0.0.0         On-link         127.0.0.1    331
        224.0.0.0        240.0.0.0         On-link     192.168.100.3    311
  255.255.255.255  255.255.255.255         On-link         127.0.0.1    331
  255.255.255.255  255.255.255.255         On-link     192.168.100.3    311
===========================================================================
Persistent Routes:
  None

IPv6 Route Table
===========================================================================
Active Routes:
 If Metric Network Destination      Gateway
  7    311 ::/0                     fe80::1
  1    331 ::1/128                  On-link
  7    311 fe80::/64                On-link
  7    311 fe80::d42:c410:783b:8dfb/128
                                    On-link
  1    331 ff00::/8                 On-link
  7    311 ff00::/8                 On-link
===========================================================================
";
                    string[] lines = output.Split(
     new[] { "\r\n", "\r", "\n" },
     StringSplitOptions.None
 );

                    foreach (string outputLine in lines)
                    {
                        System.Threading.Thread.Sleep(
     (int)System.TimeSpan.FromSeconds(0.01).TotalMilliseconds);
                        Console.WriteLine(outputLine);
                    }
                }
                else if (command == "ipconfig")
                {
                    string output = @"Windows IP Configuration


Ethernet adapter Ethernet:

   Media State . . . . . . . . . . . : Media disconnected
   Connection-specific DNS Suffix  . :

Wireless LAN adapter Local Area Connection* 1:

   Media State . . . . . . . . . . . : Media disconnected
   Connection-specific DNS Suffix  . :

Wireless LAN adapter Local Area Connection* 3:

   Media State . . . . . . . . . . . : Media disconnected
   Connection-specific DNS Suffix  . :

Wireless LAN adapter Wi-Fi:

   Connection-specific DNS Suffix  . :
   Link-local IPv6 Address . . . . . : fe80::d42:c420:783b:8gdfb%7
   IPv4 Address. . . . . . . . . . . : 392.268.10.173
   Subnet Mask . . . . . . . . . . . : 255.255.155.0
   Default Gateway . . . . . . . . . : 192.168.10.1

Ethernet adapter Bluetooth Network Connection:

   Media State . . . . . . . . . . . : Media disconnected
   Connection-specific DNS Suffix  . :
";
                    string[] lines = output.Split(
     new[] { "\r\n", "\r", "\n" },
     StringSplitOptions.None
 );

                    foreach (string outputLine in lines)
                    {
                        System.Threading.Thread.Sleep(
     (int)System.TimeSpan.FromSeconds(0.03).TotalMilliseconds);
                        Console.WriteLine(outputLine);
                    }
                }
                else if (command == "netstat \"Listen\"")
                {
                    string output = @"LocalAddress                        LocalPort RemoteAddress                       RemotePort State       AppliedSetting
------------                        --------- -------------                       ---------- -----       --------------
::                                  49676     ::                                  0          Listen
::                                  49669     ::                                  0          Listen
::                                  49667     ::                                  0          Listen
::                                  49666     ::                                  0          Listen
::                                  49665     ::                                  0          Listen
::                                  49664     ::                                  0          Listen
::1                                 1434      ::                                  0          Listen
::                                  445       ::                                  0          Listen
::                                  135       ::                                  0          Listen
0.0.0.0                             49676     0.0.0.0                             0          Listen
0.0.0.0                             49669     0.0.0.0                             0          Listen
192.168.101.0                       49667     0.0.0.0                             0          Listen
0.0.0.0                             49666     0.0.0.0                             0          Listen
0.0.0.0                             49665     0.0.0.0                             0          Listen
0.0.0.0                             49664     0.0.0.0                             0          Listen
0.0.0.0                             5040      0.0.0.0                             0          Listen
127.0.0.1                           1434      0.0.0.0                             0          Listen
192.168.100.3                       139       0.0.0.0                             0          Listen
0.0.0.0                             135       0.0.0.0                             0          Listen

";
                    string[] lines = output.Split(
     new[] { "\r\n", "\r", "\n" },
     StringSplitOptions.None
 );

                    foreach (string outputLine in lines)
                    {
                        System.Threading.Thread.Sleep(
     (int)System.TimeSpan.FromSeconds(0.01).TotalMilliseconds);
                        Console.WriteLine(outputLine);
                    }
                }
                else if (command == "net use 192.168.101/GPS-Coordinates")
                {
                    Console.WriteLine("Attempting to access \"GPS-Coordinates\" Please wait");
                    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                 
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(
     (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                   
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);

                    Console.WriteLine("ACCESS GRANTED!");
                }
                else if (command == "ReplaceText old:79.330 new:62.100")
                {
                    Console.WriteLine("Content successfully changed!");
                }

                else if (command == "Eject all")
                {
                    Console.WriteLine("Leaving server. Please wait");
                    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(
   (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
                    Console.WriteLine(".");
                    Console.WriteLine("Done.");
                }

                else
                {
                    Console.WriteLine("Invalid command! Please try again.");
                }
                Console.Write("PS C:\\WINDOWS\\system32> ");
                    command = Console.ReadLine();
                }
            }
        }
    }
