using System.Threading.Tasks;
using LimepayApi.Net.Models;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiSenderAddressResource : LimepayApiAbstractResource
    {
        public LimepayApiSenderAddressResource(LimepayApi client) : base(client)
        {
            Resource = "user/addresses/sender";
            ListResource = "sender_addresses";
            SingleResource = "sender_address";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<SenderAddress[]> Get()
        {
            return await Get<SenderAddress[]>();
        }

        public async Task<SenderAddress> Get(int senderAddressId)
        {
            return await Get<SenderAddress>(senderAddressId);
        }
    }
}
