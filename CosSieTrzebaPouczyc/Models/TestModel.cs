using System.Text.Json.Serialization;

namespace CosSieTrzebaPouczyc.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TestEnum TestEnum { get; set; }
        public override string ToString()
        {
            return $"Dlugosc: {Id}, KolorSkory: {TestEnum}";
        }
    }
}
