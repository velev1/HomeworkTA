using System;

class ParseURL
{
    static void Main()
    {
        string addres = Console.ReadLine();

        string protocol = addres.Substring(0, addres.IndexOf(@"://"));

        int start = protocol.Length + 3;

        string server = addres.Substring(start, addres.IndexOf(@"/", start) - start);

        string resresource = addres.Substring(start + server.Length);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resresource);
    }
}

