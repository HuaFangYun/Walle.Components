using System.Collections.Generic;

namespace Walle.Components.ResponsesV2
{
    public class RespListModel<T> : RespBase where T : class, new()
    {
        public List<T> Data { get; set; } = new List<T>();
    }
}
