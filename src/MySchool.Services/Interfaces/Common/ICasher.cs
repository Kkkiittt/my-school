namespace MySchool.Services.Interfaces.Common;

public interface ICasher
{
	public void Place(string key, int value, double seconds);
	public int? Get(string key);
}
