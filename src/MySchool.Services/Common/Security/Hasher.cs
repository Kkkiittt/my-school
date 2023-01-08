using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using MySchool.Services.Interfaces;

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
		var passwordInBytes = Encoding.UTF8.GetBytes(password);
		var hashInBytes = _engine.ComputeHash(passwordInBytes);
		var hashInString = Convert.ToBase64String(hashInBytes);
		return hashInString;
	}

	public bool Verify(string hash, string password, string salt)
	{
		var newHash = Hash(password, salt);
		return newHash == hash;
	}
}
