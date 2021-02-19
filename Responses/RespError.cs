using System;
using System.Collections.Generic;
using System.Text;

namespace Walle.Components.Responses
{
    public class RespListError : RespListModel
    {
        public RespListError(Exception ex)
        {
            this.Exception = ex;
            this.Message = "error occurd when resp a list of object.";
            this.IsOk = false;
        }
        public Exception Exception { get; set; } = new Exception();

        public static RespListError CreateInstance(Exception ex)
        {
            return new RespListError(ex);
        }
    }

    public class RespListError<T> : RespListModel<T> where T : class, new()
    {
        public RespListError(Exception ex)
        {
            this.Exception = ex;
            this.Message = $"error occurd when resp a list of {nameof(T)}.";
            this.IsOk = false;
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespListError<T> CreateInstance(Exception ex)
        {
            return new RespListError<T>(ex);
        }
    }

    public class RespError : RespModel
    {
        public RespError(Exception ex)
        {
            this.Exception = ex;
            this.Message = "error occurd when resp a object.";
            this.IsOk = false;
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespError CreateInstance(Exception ex)
        {
            return new RespError(ex);
        }
    }

    public class RespError<T> : RespModel<T> where T : class, new()
    {
        public RespError(Exception ex)
        {
            this.Exception = ex;
            this.Message = $"error occurd when resp a {nameof(T)}.";
            this.IsOk = false;
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespError<T> CreateInstance(Exception ex)
        {
            return new RespError<T>(ex);
        }
    }
}
