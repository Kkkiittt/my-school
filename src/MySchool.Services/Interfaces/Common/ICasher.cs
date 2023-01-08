namespace MySchool.Services.Interfaces.Common;

public interface ICasher
{
	public void Place(long key, int value, double seconds);
	public int? Get(long key);
}
