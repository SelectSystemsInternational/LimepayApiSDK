using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiParcelDocumentsResource : LimepayApiAbstractResource
    {
        public LimepayApiParcelDocumentsResource(LimepayApi client) : base(client)
        {
        }

        public async Task<byte[]> Download(int parcelId, string type, string format = null, string dpi = null)
        {
            var parameters = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(format))
                parameters.Add("format", format);
            if (!string.IsNullOrWhiteSpace(dpi))
                parameters.Add("dpi", dpi);

            Uri uri = Client.GetUrl($"{HostUrl}/parcels/{parcelId}/documents/{type}", parameters);
            return await Client.Download(uri.ToString());
        }
    }
}