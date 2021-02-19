using System.Collections.Generic;

namespace Walle.Components.Responses
{
    public class RespListModel : RespBase
    {
        public List<dynamic> Data { get; set; } = new List<dynamic>();
    }
}
