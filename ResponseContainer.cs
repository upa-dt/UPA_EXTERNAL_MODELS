
using Newtonsoft.Json;
using System.Collections;

public class ResponseContainer<T>
{
    /// <summary>
    /// Value Zero In Error Code means No Error
    /// </summary>
    [JsonProperty("errorCode")]
    public int ErrorCode { get; set; }
    [JsonProperty("errorMessage")]
    public string ErrorMessage { get; set; }
    [JsonProperty("resultLength")]
    public int resultLength
    {
        get
        {
            if (Result is IEnumerable<dynamic> and not null)
            {
                return (Result as IEnumerable<dynamic>).Count();
            }
            return 0;
        }
    }
    [JsonProperty("result")]
    public T Result { get; set; }
}

public class AsyncResponseContainer<T, Y>
{
    public ResponseContainer<T> Result { get; set; } = new ResponseContainer<T>();
    public List<Y> OutParameters { get; set; } = new List<Y>();
}