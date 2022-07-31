using System.Threading.Tasks;
using LimepayApi.Net.Models;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiParcelStatusResource : LimepayApiAbstractResource
    {
        public LimepayApiParcelStatusResource(LimepayApi client) : base(client)
        {
            Resource = "parcels/statuses";
            ListResource = "";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<Status[]> Get()
        {
            return await Get<Status[]>();
        }
    }
}
