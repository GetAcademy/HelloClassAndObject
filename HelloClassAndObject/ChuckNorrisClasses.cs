namespace HelloClassAndObject
{

    public class SearchResult
    {
        public int total { get; set; }
        public Result[] result { get; set; }
    }

    public class Result
    {
        public object[] categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }

}
