﻿using LimepayApi.Net.Helpers;
using LimepayApi.Net.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LimepayApi.Net.Resources
{
    public class LimepayApiReturnPortalResource
    {
        private readonly LimepayApi _client;
        private readonly string _hostUrl = "https://panel.sendcloud.sc/api/v2/";
        private readonly string _dateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public LimepayApiReturnPortalResource(LimepayApi client)
        {
            _client = client;
        }

        public async Task<Portal> GetPortalSettings(string domain, string language = null)
        {
            var parameters = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(language))
                parameters.Add("language", language);

            string url = $"{_hostUrl}brand/{domain}/return-portal/";
            return await _client.Get<Portal>(url, parameters, "portal", _dateTimeFormat);
        }

        public async Task<ServicePoint[]> GetServicePoints(string accessToken, string country, string latitude = null, string longitude = null, string radius = null, string pageSize = null, string[] carriers = null)
        {
            var parameters = new Dictionary<string, string>
            {
                { "access_token", accessToken },
                { "country", country }
            };
            if (!string.IsNullOrWhiteSpace(latitude))
                parameters.Add("latitude", latitude);
            if (!string.IsNullOrWhiteSpace(longitude))
                parameters.Add("longitude", longitude);
            if (!string.IsNullOrWhiteSpace(radius))
                parameters.Add("radius", radius);
            if (!string.IsNullOrWhiteSpace(pageSize))
                parameters.Add("pageSize", pageSize);
            if (carriers != null && carriers.Length > 0)
                parameters.Add("carrier", string.Join(",", carriers));

            string url = "https://servicepoints.sendcloud.sc/api/v2/service-points/";
            return await _client.Get<ServicePoint[]>(url, parameters, "", _dateTimeFormat);
        }

        public async Task<OutgoingParcel> GetOutgoingParcel(string domain, string postalCode, string identifier)
        {
            var parameters = new Dictionary<string, string>
            {
                { "postal_code", postalCode },
                { "identifier", identifier }
            };

            string url = $"{_hostUrl}brand/{domain}/return-portal/outgoing/";
            return await _client.Get<OutgoingParcel>(url, parameters, "", _dateTimeFormat);
        }

        public async Task<ReturnParcelResponse> CreateReturnParcel(string domain, string accessToken, ReturnParcel returnParcel)
        {
            string url = $"{_hostUrl}brand/{domain}/return-portal/incoming/";
            string authorization = $"Bearer {accessToken}";
            string data = JsonHelper.Serialize(returnParcel, "");
            return await _client.Create<ReturnParcelResponse>(url, data, "", _dateTimeFormat);
        }

        public async Task<string> GetLabelPolling(string url)
        {
            return await _client.Get<string>(url, null, "", _dateTimeFormat);
        }

        public async Task<byte[]> GetLabelDownload(string url)
        {
            return await _client.Download(url);
        }
    }
}