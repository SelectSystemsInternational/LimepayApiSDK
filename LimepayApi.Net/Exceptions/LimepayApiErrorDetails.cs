﻿/* 
 * Limepay API
 *
 * Initial build 2022-07-23
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://selectsystems.com.au
 */

using System.Runtime.Serialization;

namespace LimepayApi.Net.Exceptions
{
    [DataContract]
    public class LimepayApiErrorDetails
    {
        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = false)]
        public string Code { get; set; }

        [DataMember(Name = "request", EmitDefaultValue = false, IsRequired = false)]
        public string Request { get; set; }
    }
}
