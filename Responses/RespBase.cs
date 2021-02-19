namespace Walle.Components.Responses
{
    public abstract class RespBase
    {
        public bool IsOk { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
