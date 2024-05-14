namespace Freelancer.Backend.Infrastructure.Configurations
{
    public class StorageOptions
    {
        public const string ConfigKey = "StorageConfiguration";
        public required string UserPhotoStoragePath { get; set; }
        public required string JobPhotoStoragePath { get; set; }
    }
}
