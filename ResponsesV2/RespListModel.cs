using System.Collections.Generic;

namespace Walle.Components.ResponsesV2
{
    public class RespListModel : RespBase
    {
        public List<dynamic> Data { get; set; } = new List<dynamic>();
    }
}
