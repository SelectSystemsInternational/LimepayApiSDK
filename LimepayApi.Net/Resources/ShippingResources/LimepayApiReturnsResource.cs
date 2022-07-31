using LimepayApi.Net.Models;
using System.Threading.Tasks;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiReturnsResource: LimepayApiAbstractResource
    {
        public LimepayApiReturnsResource(LimepayApi client) : base(client)
        {
            Resource = "returns";
            ListResource = "returns";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
            DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.ffffffzzz";
        }

        public async Task<Return[]> Get()
        {
            return await Get<Return[]>();
        }

        public async Task<Return> Get(int returnId)
        {
            return await Get<Return>(returnId);
        }
    }
}
