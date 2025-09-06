using Newtonsoft.Json;

namespace ResponseServices
{
    public class Response
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public Response(int status, string message = null)
        {
            Status = status;
            Message = message ?? string.Empty;
        }
    }

    /// <summary>
    /// kiểu dữ liệu trả về  có status, thông báo và dữ liệu kiểu T trả về
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T> : Response
    {
        public T[] Data { get; set; }
        public int TotalRecord => Data != null ? Data.Length : 0;

        [JsonConstructor]
        public Response(
            int status, string message = null, T[] data = default)
            : base(status, message)
        {
            Data = data;
        }
    }

}
