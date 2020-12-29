using System;
using System.Text;
using Whois.NET;

namespace Whois
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.lacnic.net/2472/2/lacnic/request-bulk-whois-access
            // https://afrinic.net/support/general-queries/how-can-i-request-for-bulk-whois-data
            // https://www.ripe.net/manage-ips-and-asns/db/nrtm-mirroring
            // https://www.arin.net/reference/research/bulkwhois/
            // https://www.apnic.net/manage-ip/using-whois/bulk-access/


            var domain = "targa.co.it";
            var response = WhoisClient.Query(domain, encoding: Encoding.UTF8);
            Console.WriteLine(response);
        }
    }
}
