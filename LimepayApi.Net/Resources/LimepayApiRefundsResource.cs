/* 
 * Limepay API
 *
 * Initial build 2022-07-23
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://selectsystems.com.au
 */

using System.Collections.Generic;
using System.Threading.Tasks;

using LimepayApi.Net.Helpers;
using LimepayApi.Net.Models;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiRefundsResource : LimepayApiAbstractResource
    {
        public LimepayApiRefundsResource(LimepayApi client) : base(client)
        {

        }

        public async Task<PaymentResponse> Get(string transactionId)
        {
            var parameters = new Dictionary<string, string>();

            return await Get<PaymentResponse>("/transactions", transactionId, parameters);
        }

        public async Task<StatusResponse> Update(string merchantOrderId, UpdateOrder internalOrderId)
        {
            return await Update<StatusResponse>("/orders", merchantOrderId, JsonHelper.Serialize(internalOrderId));
        }

        public async Task<StatusResponse> Delete(string merchantOrderId)
        {
            return await Delete<StatusResponse>("/orders", merchantOrderId);
        }

        public async Task<RefundResponse> RefundTransaction(CreateRefundRequest createRefundRequest)
        {
            var parameters = new Dictionary<string, string>();

            return await RefundTransaction<RefundResponse>("/refunds", JsonHelper.Serialize(createRefundRequest));
        }

    }
}
