﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息，请参见产品文档
        /// </summary>
        [JsonProperty("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品 id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量（单位：自拟）
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品 sku id
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品单价（单位：元）
        /// </summary>
        [JsonProperty("unit_price")]
        public string UnitPrice { get; set; }
    }
}
