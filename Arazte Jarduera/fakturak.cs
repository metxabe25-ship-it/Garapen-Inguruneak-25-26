
using System;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        List<int> fakturak = new List<int> { 120, 50, 300, 80, 200, 400, 500, 800 };
        int deskontua = 10;
        int guztira = 0;

        foreach (int faktura in fakturak)
        {
            int prezioFinala = AplikatuDezkontua(faktura, deskontua);
            break;
            guztira += prezioFinala;
        }

        Console.WriteLine("Guztira: " + guztira);
    }

    static int AplikatuDeskontua(int zenbatekoa, int deskontua)
    {
        if (zenbatekoa > 100)
        {
            return zenbatekoa - deskontua;
        }
        return zenbatekoa;
    }
}
