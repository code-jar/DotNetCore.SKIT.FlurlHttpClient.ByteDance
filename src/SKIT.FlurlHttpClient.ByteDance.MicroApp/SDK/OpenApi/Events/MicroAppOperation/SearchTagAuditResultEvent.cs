namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.SEARCH_TAG_AUDIT_RESULT 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/alias-search-tag </para>
    /// </summary>
    public class SearchTagAuditResultEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置搜索标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("search_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("search_tag")]
                [System.Xml.Serialization.XmlElement("search_tag")]
                public string SearchTag { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventContent")]
        [System.Text.Json.Serialization.JsonPropertyName("EventContent")]
        [System.Xml.Serialization.XmlElement("EventContent")]
        public Types.EventContent EventContent { get; set; } = default!;
    }
}
