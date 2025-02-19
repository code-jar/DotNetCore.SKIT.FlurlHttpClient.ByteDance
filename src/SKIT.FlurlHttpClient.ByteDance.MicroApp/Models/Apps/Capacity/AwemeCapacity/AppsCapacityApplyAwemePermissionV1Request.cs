namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/apply_aweme_permission 接口的请求。</para>
    /// </summary>
    public class AppsCapacityApplyAwemePermissionV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置权限 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permission_key")]
        [System.Text.Json.Serialization.JsonPropertyName("permission_key")]
        public string PermissionKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预期使用场景描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_desc")]
        public string SceneDescription { get; set; } = string.Empty;
    }
}
