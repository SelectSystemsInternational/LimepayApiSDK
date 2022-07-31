﻿/* 
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

namespace LimepayApi.Net.Resources
{
    public abstract class LimepayApiAbstractResource
    {
        protected readonly LimepayApi Client;
        protected string HostUrl = "https://api.sandbox.limepay.com.au";
        protected string Authorization;
        protected bool CreateRequest = true;
        protected bool GetRequest = true;
        protected bool UpdateRequest = true;
        protected bool DeleteRequest = true;
        protected string SingleResource = string.Empty;
        protected string ListResource = string.Empty;
        protected string CreateResource = string.Empty;
        protected string UpdateResource = string.Empty;
        protected string Resource = string.Empty;
        protected string DateTimeFormat = "yyyy-MM-ddThh:mm:ss.fffZ";

        protected LimepayApiAbstractResource(LimepayApi client)
        {
            Client = client;
            Authorization = client.GetBasicAuth();
        }

        protected async Task<T> Create<T>(string localVarPath, string data)
        {
            if (CreateRequest)
                return await Client.Create<T>($"{Client.GetHostUrl()}{localVarPath}", data, SingleResource, DateTimeFormat);

            return default(T);
        }

        protected async Task<T> PayOrder<T>(string localVarPath, string objectId, string data)
        {
            if (CreateRequest)
                return await Client.Create<T>($"{Client.GetHostUrl()}{localVarPath}/{objectId}/pay", data, SingleResource, DateTimeFormat);

            return default(T);
        }

        protected async Task<T> CaptureTransaction<T>(string localVarPath, string objectId, string data)
        {
            if (CreateRequest)
                return await Client.Create<T>($"{Client.GetHostUrl()}{localVarPath}", data, SingleResource, DateTimeFormat);

            return default(T);
        }

        protected async Task<T> Get<T>(string localVarPath, string objectId = null, Dictionary<string, string> parameters = null)
        {
            if (GetRequest)
            {
                if (!string.IsNullOrEmpty(objectId))
                    return await Client.Get<T>($"{Client.GetHostUrl()}{localVarPath}/{objectId}", parameters, SingleResource, DateTimeFormat);

                return await Client.Get<T>($"{Client.GetHostUrl()}{Resource}", parameters, ListResource, DateTimeFormat);
            }

            return default(T);
        }

        protected async Task<T> Update<T>(string localVarPath, string objectId = null, string internalOrderId = null)
        {
            if (UpdateRequest)
            {
                return await Client.Update<T>($"{Client.GetHostUrl()}{localVarPath}/{objectId}", internalOrderId);
            }

            return default(T);
        }

        protected async Task<T> Delete<T>(string localVarPath, string objectId = null)
        {
            if (DeleteRequest)
            {
                if (!string.IsNullOrEmpty(objectId))
                    return await Client.Delete<T>($"{Client.GetHostUrl()}{localVarPath}/{objectId}");
            }

            return default(T);
        }

        protected async Task<T> VoidTransaction<T>(string localVarPath, string objectId)
        {
            if (CreateRequest)
                return await Client.Delete<T>($"{Client.GetHostUrl()}{localVarPath}/{objectId}/authorisation");

            return default(T);
        }

    }
}
