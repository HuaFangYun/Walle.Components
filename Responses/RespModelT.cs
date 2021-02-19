namespace Walle.Components.Responses
{
    public class RespModel<T> : RespBase where T : class, new()
    {
        public T Data { get; set; } = new T();
    }
}
