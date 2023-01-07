using MySchool.Services.ViewModels.Charters;

namespace MySchool.Services.ViewModels.Students;

public class StudnetFullViewModel
{
	public string Info { get; set; } = string.Empty;

	public bool Studying { get; set; } 

	public List<CharterShortViewModel> Charters { get; set; } = new();

}
