namespace Walle.Components.ResponsesV2
{
    public abstract class RespBase
    {
        public string Code { get; set; } = "0000";
        public string Message { get; set; } = string.Empty;
    }
}
