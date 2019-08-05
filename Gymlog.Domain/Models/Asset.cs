namespace Gymlog.Domain.Models
{
    public enum AssetTypeEnum
    {
        Image = 0,
        Video = 1
    }

    public class Asset
    {
        public int Id { get; set; }
        public AssetTypeEnum Type { get; set; }
        public string Url { get; set; }
    }
}
