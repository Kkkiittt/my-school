using System.Security.Cryptography;
using System.Text;

using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Common.Security;

public class Hasher : IHasher
{
	private readonly SHA256 _engine;

	public Hasher()
	{
		_engine = SHA256.Create();
	}

	public string Hash(string password, string salt)
	{
		password += salt;
		byte[] passwordInBytes = Encoding.UTF8.GetBytes(password);
		byte[] hashInBytes = _engine.ComputeHash(passwordInBytes);
		string hashInString = Convert.ToBase64String(hashInBytes);
		return hashInString;
	}

	public bool Verify(string hash, string password, string salt)
	{
		string newHash = Hash(password, salt);
		return newHash == hash;
	}
}
