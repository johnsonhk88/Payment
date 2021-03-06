using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertSmartPromoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertSmartPromoResponse : AlipayObject
    {
        /// <summary>
        /// 智能营销分组ID
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 智能营销方案ID
        /// </summary>
        [JsonProperty("plan_id")]
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
