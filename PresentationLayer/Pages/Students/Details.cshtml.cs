using BusinessLogicLayer;
using CommonLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationLayer.Pages.Students
{
    public class DetailsModel : PageModel
    {
		public StudentEntity Student { get; set; }

		public void OnGet(StudentBLL studentBLL, int id)
		{
			Student = studentBLL.GetStudentById(id);
		}
	}
}
