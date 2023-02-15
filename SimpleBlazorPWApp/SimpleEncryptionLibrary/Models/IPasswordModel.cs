namespace SimpleEncryptionLibrary.Models
{
    public interface IPasswordModel
    {
        string KeyPhrase { get; set; }
        int Pin { get; set; }
        string SeedPhrase { get; set; }
        string SiteName { get; set; }
    }
}