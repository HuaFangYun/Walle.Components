namespace Walle.Components.ResponsesV2
{
    public class RespModel<T> : RespBase where T : class, new()
    {
        public T Data { get; set; } = new T();
    }
}
