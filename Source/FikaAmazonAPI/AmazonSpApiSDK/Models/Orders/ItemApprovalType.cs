﻿using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    [JsonConverter(typeof(StringEnumConverter))]

    public enum ItemApprovalType
    {

        /// <summary>
        /// Enum LEONARDIAPPROVAL for value: LEONARDI_APPROVAL
        /// </summary>
        [EnumMember(Value = "LEONARDI_APPROVAL")]
        LEONARDIAPPROVAL = 1
    }
}
