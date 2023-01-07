using My_School.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.ViewModels.Students
{
	public class StudentRegisterViewModel : BaseEntity
	{
		public int Pin { get; set; }
	}
}
