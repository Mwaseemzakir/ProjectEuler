using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Core.IO
{
    public static class UrlReader
    {
        public static async Task<string> ReadUrl(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(url);
                return result;
            }
        }
    }
}
