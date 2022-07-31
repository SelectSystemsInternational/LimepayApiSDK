using LimepayApi.Net.Models;
using System.Threading.Tasks;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiBrandsResource: LimepayApiAbstractResource
    {
        public LimepayApiBrandsResource(LimepayApi client) : base(client)
        {
            Resource = "brands";
            ListResource = "brands";
            SingleResource = "";
            CreateRequest = false;
            UpdateRequest = false;
        }

        public async Task<Brand[]> Get()
        {
            return await Get<Brand[]>();
        }

        public async Task<Brand> Get(int brandId)
        {
            return await Get<Brand>(brandId);
        }
    }
}
