using System;
using System.Collections.Generic;
using System.Text;

namespace Walle.Components.ResponsesV2
{
    public class RespListError : RespListModel
    {
        public RespListError(Exception ex)
        {
            this.Exception = ex;
            this.Message = "error occurd when resp a list of object.";
            this.Code = "0001";
        }
        public RespListError(Exception ex, string message)
        {
            this.Exception = ex;
            this.Message = message;
            this.Code = "0001";
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespListError CreateInstance(Exception ex)
        {
            return new RespListError(ex);
        }
        public static RespListError CreateInstance(Exception ex, string message)
        {
            return new RespListError(ex, message);
        }
    }

    public class RespListError<T> : RespListModel<T> where T : class, new()
    {
        public RespListError(Exception ex)
        {
            this.Exception = ex;
            this.Message = $"error occurd when resp a list of {nameof(T)}.";
            this.Code = "0001";
        }
        public RespListError(Exception ex, string message)
        {
            this.Exception = ex;
            this.Message = message;
            this.Code = "0001";
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespListError<T> CreateInstance(Exception ex)
        {
            return new RespListError<T>(ex);
        }
        public static RespListError<T> CreateInstance(Exception ex, string message)
        {
            return new RespListError<T>(ex, message);
        }
    }

    public class RespError : RespModel
    {
        public RespError(Exception ex)
        {
            this.Exception = ex;
            this.Message = "error occurd when resp a object.";
            this.Code = "0001";
        }
        public RespError(Exception ex, string message)
        {
            this.Exception = ex;
            this.Message = message;
            this.Code = "0001";
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespError CreateInstance(Exception ex)
        {
            return new RespError(ex);
        }
        public static RespError CreateInstance(Exception ex, string message)
        {
            return new RespError(ex, message);
        }
    }

    public class RespError<T> : RespModel<T> where T : class, new()
    {
        public RespError(Exception ex)
        {
            this.Exception = ex;
            this.Message = $"error occurd when resp a {nameof(T)}.";
            this.Code = "0001";
        }
        public RespError(Exception ex, string message)
        {
            this.Exception = ex;
            this.Message = message;
            this.Code = "0001";
        }
        public Exception Exception { get; set; } = new Exception();
        public static RespError<T> CreateInstance(Exception ex)
        {
            return new RespError<T>(ex);
        }
        public static RespError<T> CreateInstance(Exception ex, string message)
        {
            return new RespError<T>(ex, message);
        }
    }
}
