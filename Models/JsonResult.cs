namespace Help_Desk_Log_API.Models
{
    public class JsonResponse
    {
        public bool hasErrors { get; set; }
        public string msg { get; set; }
        public object data { get; set; }
        public int id { get; set; }
    }
}
