namespace MikuBlazor
{
    public class ApiReturn
    {
        public string? name { get; set; }
        public string? codename { get; set; }
        public string? introduction { get; set; }
        public string? version { get; set; }
        public string? image { get; set; }
        public static List<ApiReturn> ConvertJsonToList(string JsonString)
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<ApiReturn>>(JsonString) ?? new List<ApiReturn>();
        }
    }
}

