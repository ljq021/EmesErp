namespace Emes.Core
{
    public class Result<TValue> : Result
    {
        public TValue Data { get; set; }

        public object ExtendData { get; set; }

        protected internal Result(TValue value, bool success, string error)
            : base(success, error)
        {
            Data = value;
        }
    }
}
