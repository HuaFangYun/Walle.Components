using System.Collections.Generic;

namespace Walle.Components.Responses
{
    public class RespListModel<T> : RespBase where T : class, new()
    {
        public List<T> Data { get; set; } = new List<T>();
    }
}
