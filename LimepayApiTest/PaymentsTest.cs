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
    public class LimepayApiPaymentsTest
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
        /// Test GetOrderTest
        /// </summary>
        [Test]
        public async Task GetTransactionTest()
        {

            var result = await _client.Payments.Get("tran_YuI2HRk7OA_Jfm1m");

            Assert.IsInstanceOf<PaymentResponse>(result, "instance is OrderCreateResponse");
        }

        /// <summary>
        /// Test GetTransactionByOrderIdTest
        /// </summary>
        [Test]
        public async Task GetTransactionByMerchantOrderIdTest()
        {

            var result = await _client.Payments.Get("ordr_YuI1jxk7OA_Jfm1k");

            Assert.IsInstanceOf<PaymentResponse>(result, "instance is OrderCreateResponse");
        }

        /// <summary>
        /// Test CaptureTransactionTest
        /// </summary>
        [Test]
        public async Task CaptureTransactionTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var orderPaymentRequest = _limepayCommon.CreateOrderAutorisationRequest("ptkn_YuJ0PJe2pkXPnm2P");

            var authorizeOrder = await _client.Orders.AuthorizeOrder(merchantOrder.MerchantOrderId, orderPaymentRequest); // ordr_YuJt5Hd3Jm8I4M-G

            Assert.IsInstanceOf<TransactionResponse>(authorizeOrder, "instance is TransactionResponse");

            var captureAmount = new CreateCaptureRequest(1000);

            var captureTransactionResult = await _client.Payments.CaptureTransaction(authorizeOrder.TransactionId, captureAmount);

            Assert.IsInstanceOf<PaymentResponse>(captureTransactionResult, "instance is PaymentResponse");
        }

        /// <summary>
        /// Test CaptureTransactionTest
        /// </summary>
        [Test]
        public async Task VoidTransactionTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var orderPaymentRequest = _limepayCommon.CreateOrderAutorisationRequest("ptkn_YuJ1EXd3Jm8I4M_G");

            var authorizeOrder = await _client.Orders.AuthorizeOrder(merchantOrder.MerchantOrderId, orderPaymentRequest); // ordr_YuJt5Hd3Jm8I4M-G

            Assert.IsInstanceOf<TransactionResponse>(authorizeOrder, "instance is TransactionResponse");

            var voidResult = await _client.Payments.VoidTransaction(authorizeOrder.TransactionId);

            Assert.IsInstanceOf<PaymentResponse>(voidResult, "instance is PaymentResponse");
        }

    }

}


