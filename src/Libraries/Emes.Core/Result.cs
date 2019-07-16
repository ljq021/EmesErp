using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Emes.Core
{
    public enum ResultCode
    {
        Ok = 200,

        Forbidden = 403,
        NotFound = 404
    }
    public class Result
    {
        public int Code { get; set; } = 200;
        public bool IsSucceed { get; }

        public string Message { get; }

        protected Result(bool successd, string msg)
        {
            IsSucceed = successd;
            Message = msg;
        }

        public static Task<Result> Fail(string msg, int code)
        {
            return Task.FromResult(new Result(false, msg) { Code = code });
        }

        public static Task<Result> Fail(string msg)
        {
            return Task.FromResult(new Result(false, msg));
        }

        public static Task<Result> Ok()
        {
            return Task.FromResult(new Result(true, null));
        }

        public static Task<Result<TValue>> Ok<TValue>(TValue value)
        {
            return Task.FromResult(new Result<TValue>(value, true, null));
        }

        public static Task<Result<TValue>> Fail<TValue>(string error)
        {
            return Task.FromResult(new Result<TValue>(default(TValue), false, error));
        }

        public static Task<Result> NotFound()
        {
            return Task.FromResult(new Result(false, "数据记录不存在") { Code = (int)ResultCode.NotFound });
        }

        public static Task<Result<TValue>> NotFound<TValue>()
        {
            return Task.FromResult(new Result<TValue>(default(TValue), false, "数据记录不存在") { Code = (int)ResultCode.NotFound });
        }

        public static Task<Result> Forbidden()
        {
            return Task.FromResult(new Result(false, "无权限访问") { Code = (int)ResultCode.Forbidden });
        }

        public static Task<Result<TValue>> Forbidden<TValue>()
        {
            return Task.FromResult(new Result<TValue>(default(TValue), false, "无权限访问") { Code = (int)ResultCode.Forbidden });
        }
    }
}
