using Newtonsoft.Json;


namespace Company.Function
{
    public class Counter
    {

        [JsonProperty(PropertyName="id")]

        public string Id {get; set;}
        [JsonProperty(PropertyName = "counter")]
        public int Count {get;set;}
    }
}