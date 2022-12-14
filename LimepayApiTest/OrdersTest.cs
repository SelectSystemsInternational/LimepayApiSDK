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
    public class LimepayApiOrdersTest
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
        /// Create a Test Order Request
        /// </summary>
        public CreateOrderRequest CreateRequest(string phone = "+61 0000000000", string orderType = null)
        {
            var phoneNumber = new PhoneNumber("string", true);

            var billingAddress = new OrderAddress("Line1", "Line2", "Country", "City", "9999", "State");
            var billing = new OrderBilling(billingAddress, "Name", "Phone");

            var shippingAddress = new OrderAddress("Line1", "Line2", "Country", "City", "9999", "State");
            var shipping = new OrderShipping(1, shippingAddress, "Carrier", "Name", "Phone", "TrackingNumber");

            var item1 = new OrderItem(123, "AUD", "Decription1", "SKU1", 1, "https://yourdomain.com.au/images/thumbs/0000062_obey-propaganda-hat.jpeg");
            var item2 = new OrderItem(123, "AUD", "Decription1", "SKU1", 1, "https://yourdomain.com.au/images/thumbs/0000064_ray-ban-aviator-sunglasses.jpeg");

            var items = new List<OrderItem>();
            items.Add(item1);
            items.Add(item2);

            string phoneNo = phone;
            var amount = new Money(1500, "AUD");

            var discount = new Discount(0);

            var metadata = new Metadata("version", "v4.4");

            var createOrderRequest = new CreateOrderRequest("Order123", amount, "youremail@domain.com", phoneNo, "Order Description",
                items, discount, shipping, billing, metadata, orderType);

            return createOrderRequest;
        }

        /// <summary>
        /// Create a Test Order Request
        /// </summary>
        public OrderPayment CreateOrderPaymentRequest(string paymentToken)
        {
            var cardStatement = new CardStatement("JohnDoe", "City");

            // Only used for 3DS
            // var paymentActionRequired = new PaymentActionRequired("11111", "https://yourdomain.com.au/");

            //var orderPayment = new OrderPayment(paymentToken, true, "https://yourdomain.com.au/", 
            //    true, true, cardStatement, null);

            var orderPayment = new OrderPayment(paymentToken, false, "https://yourdomain.com.au/",
                false, false, cardStatement, null);

            return orderPayment;
        }

        /// <summary>
        /// Create a Test Order Request
        /// </summary>
        public OrderPayment CreateOrderAuthorisationRequest(string paymentToken)
        {
            var cardStatement = new CardStatement("JohnDoe", "City");

            // Only used for 3DS
            // var paymentActionRequired = new PaymentActionRequired("11111", "https://yourdomain.com.au/");

            //var orderPayment = new OrderPayment(paymentToken, true, "https://yourdomain.com.au/", 
            //    true, true, cardStatement, null);

            var orderPayment = new OrderPayment(paymentToken, false, "https://yourdomain.com.au/",
                true, false, cardStatement, null);

            return orderPayment;
        }

        /// <summary>
        /// Test CreateOrderTest
        /// </summary>
        [Test]
        public async Task CreateOrderTest()
        {

            var createOrderRequest = _limepayCommon.CreateRequest();

            var result = await _client.Orders.Create(createOrderRequest);

            Assert.IsInstanceOf<OrderCreateResponse>(result, "instance is OrderCreateResponse");

        }

        /// <summary>
        /// Test CreateOrderInvoiceTest
        /// </summary>
        [Test]
        public async Task CreateOrderInvoiceTest()
        {

            var createOrderInvoiceRequest = new CreateOrderInvoiceRequest();
            createOrderInvoiceRequest.SendSms = true;
            createOrderInvoiceRequest.SendEmail = true;
            createOrderInvoiceRequest.OrderRequest = CreateRequest("+61 0417157088", "online");
            var result = await _client.Orders.CreateInvoice(createOrderInvoiceRequest);

            Assert.IsInstanceOf<OrderCreateResponse>(result, "instance is CreateOrderInvoiceRequest");

            while (true)
            {
                var resppnse = await _client.Orders.Get(result.MerchantOrder.MerchantOrderId);
            }
        }

        /// <summary>
        /// Test GetOrderTest
        /// </summary>
        [Test]
        public async Task GetOrderTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var result = await _client.Orders.Get("ordr_YtxFJ3gADUDUkRz0");

            Assert.IsInstanceOf<OrderCreateResponse>(result, "instance is OrderCreateResponse");
        }

        /// <summary>
        /// Test DeleteOrderTest
        /// </summary>
        [Test]
        public async Task UpdateOrderTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var updateOrder = new UpdateOrder("Test_01");

            var result = await _client.Orders.Update(merchantOrder.MerchantOrderId, updateOrder);

            var newOrder = await _client.Orders.Get(merchantOrder.MerchantOrderId);

            Assert.IsInstanceOf<StatusResponse>(result, "instance is StatusResponse");
        }

        /// <summary>
        /// Test PayOrderTest
        /// </summary>
        [Test]
        public async Task PayOrderTest()
        {
            // Typical Return Value
            // { 
            //  "transactionId": "tran_xxx",
            //  "transactionStatus":"paid",
            //  "amount":1500,
            //  "currency":"AUD",
            //  "type":"paycard"
            // }

            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var orderPaymentRequest = _limepayCommon.CreateOrderPaymentRequest("ptkn_XXXXX"); // Insert paymentToken from Website Transaction

            var transactionResult = await _client.Orders.PayOrder(merchantOrder.MerchantOrderId, orderPaymentRequest);

            Assert.IsInstanceOf<TransactionResponse>(transactionResult, "instance is TransactionResponse");

            var updateOrder = new UpdateOrder("Test_01");

        }


        /// <summary>
        /// Test PayOrderTest
        /// </summary>
        [Test]
        public async Task PayAndUpdateOrderTest() 
        {
            // Typical Return Value
            // { 
            //  "transactionId": "tran_xxx",
            //  "transactionStatus":"paid",
            //  "amount":1500,
            //  "currency":"AUD",
            //  "type":"paycard"
            // }

            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var orderPaymentRequest = _limepayCommon.CreateOrderPaymentRequest("ptkn_XXXXX"); // Insert paymentToken from Website Transaction

            var transactionResult = await _client.Orders.PayOrder(merchantOrder.MerchantOrderId, orderPaymentRequest);

            Assert.IsInstanceOf<TransactionResponse>(transactionResult, "instance is TransactionResponse");

            var updateOrder = new UpdateOrder("Test_01");

            var result = await _client.Orders.Update(merchantOrder.MerchantOrderId, updateOrder);

            Assert.IsInstanceOf<StatusResponse>(transactionResult, "instance is StatusResponse");

        }

        /// <summary>
        /// Test PayOrderTest
        /// </summary>
        [Test]
        public async Task Pay3DSOrderTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var orderPaymentRequest = _limepayCommon.Create3DSOrderPaymentRequest("ptkn_XXXXX"); // Insert paymentToken from Website Transaction

            //{ "paymentToken":"ptkn_xxx",
            //  "paymentActionRequired":
            //      { "threeDSAuthorisationId":"pay_xxx",
            //      "redirectURL":"https://sandbox.lime.page/MjJL0UtVqra"
            //      }
            //}

            var paymentActionResponse = await _client.Orders.Pay3DSOrder(merchantOrder.MerchantOrderId, orderPaymentRequest);

            Assert.IsInstanceOf<PaymentActionResponse>(paymentActionResponse, "instance is PaymentActionResponse");
        }

        /// <summary>
        /// Test DeleteOrderTest
        /// </summary>
        [Test]
        public async Task CancelOrderTest()
        {
            var createOrderRequest = _limepayCommon.CreateRequest();

            var merchantOrder = await _client.Orders.Create(createOrderRequest);

            var result = await _client.Orders.Cancel(merchantOrder.MerchantOrderId);

            Assert.IsInstanceOf<StatusResponse>(result, "instance is StatusResponse");
        }
    }
}


