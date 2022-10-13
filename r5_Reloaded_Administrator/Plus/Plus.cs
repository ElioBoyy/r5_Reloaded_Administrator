using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace r5_Reloaded_Administrator.Plus
{
    public class Plus
    {
        public static Int64 sizeCalcul(string path)
        {
            WebClient client = new WebClient();
            client.OpenRead(path);
            Int64 bytes_total = Convert.ToInt64(client.ResponseHeaders["Content-Length"]) / 1000000;
            return bytes_total;
        }
    }
}
