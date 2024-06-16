namespace ShowDoTrilhao.Core
{
    public class Token
    {
        public string? Hash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
