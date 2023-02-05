using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ipValidation;
public class Kata
{
    public static bool IsValidIp(string ipAddres)
    {
        string st1= @"^(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])$";
        return Regex.IsMatch(ipAddres, st1);
    }
}