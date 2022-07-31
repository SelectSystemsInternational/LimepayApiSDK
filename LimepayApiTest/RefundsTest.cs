/* 
 * Limepay API
 *
 * Initial build 2022-07-23
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://selectsystems.com.au
 */

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using NUnit.Framework;

using LimepayApi.Net.Models;

namespace LimepayApi.Test
{
    /// <summary>
    ///  Class for testing AuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LimepayApiRefundsTest
    {

        private LimepayApi.Net.LimepayApi _client;
        public LimepayApi.Common.LimepayCommon _limepayCommon = new Common.LimepayCommon();


        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            _client = new LimepayApi.Net.LimepayApi("https://api.sandbox.limepay.com.au",
                "your_sandbox_pk", "your_sandbox_sk"); // Enter your sandbox keys
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LimepayApi.Net.LimepayApi Client
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthorizationApi
            var instance = new LimepayApi.Net.LimepayApi("https://api.sandbox.limepay.com.au",
                "your_sandbox_pk", "your_sandbox_sk"); // Enter your sandbox keys

            Assert.IsInstanceOf<LimepayApi.Net.LimepayApi>(instance, "instance is a LimepayApi.Net.LimepayApi Client");
        }

        /// <summary>
        /// Test RefundOrderTest
        /// </summary>
        [Test]
        public async Task CaptureTransactionTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var orderPaymentRequest = _limepayCommon.CreateOrderPaymentRequest("ptkn_xxx");

            var result = await _client.Orders.PayOrder(merchantOrder.MerchantOrderId, orderPaymentRequest);

            Assert.IsInstanceOf<TransactionResponse>(result, "instance is TransactionResponse");

            var refund = new Money(500, "AUD");

            var createRefundRequest = new CreateRefundRequest("tran_", refund); // Ener your transaction ID

            var captureTransactionResult = await _client.Refunds.RefundTransaction(createRefundRequest);

            Assert.IsInstanceOf<RefundResponse>(captureTransactionResult, "instance is RefundResponse");
        }
    }
}


