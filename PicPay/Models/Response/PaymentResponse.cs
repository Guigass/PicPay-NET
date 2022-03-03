using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace PicPay.Models
{
    public class PaymentResponse
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
        [JsonProperty("referenceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReferenceId { get; set; }
        [JsonProperty("paymentUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PaymentUrl { get; set; }
        [JsonProperty("errors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Error> Errors { get; set; }
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }
        [JsonProperty("qrcode", NullValueHandling = NullValueHandling.Ignore)]
        public Qrcode Qrcode { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
    }

    public partial class Qrcode
    {
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty("base64", NullValueHandling = NullValueHandling.Ignore)]
        public string Base64 { get; set; }
    }
}