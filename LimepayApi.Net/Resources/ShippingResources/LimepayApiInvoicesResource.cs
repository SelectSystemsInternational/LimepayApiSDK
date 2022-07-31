using System.Threading.Tasks;
using LimepayApi.Net.Models;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiInvoicesResource : LimepayApiAbstractResource
    {
        public LimepayApiInvoicesResource(LimepayApi client) : base(client)
        {
            Resource = "user/invoices";
            ListResource = "invoices";
            SingleResource = "invoice";
            CreateRequest = false;
            UpdateRequest = false;
            DateTimeFormat = "dd-MM-yyyy HH:mm:ss";
        }

        public async Task<Invoice<string>[]> Get()
        {
            return await Get<Invoice<string>[]>();
        }

        public async Task<Invoice<InvoiceItem[]>> Get(int invoiceId)
        {
            return await Get<Invoice<InvoiceItem[]>>(invoiceId);
        }
    }
}
