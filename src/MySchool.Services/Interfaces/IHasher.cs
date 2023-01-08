namespace MySchool.Services.Interfaces;

public interface IHasher
{
	public string Hash(string password, string salt);
	public bool Verify(string hash, string password, string salt);
}
