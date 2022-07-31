using System.Threading.Tasks;
using LimepayApi.Net.Models;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiUsersResource : LimepayApiAbstractResource
    {
        public LimepayApiUsersResource(LimepayApi client) : base(client)
        {
            Resource = "user";
            ListResource = "user";
            SingleResource = "user";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<User> Get()
        {
            return await Get<User>();
        }
    }
}
