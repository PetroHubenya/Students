using BusinessLogicLayer;
using CommonLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationLayer.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<StudentEntity> Students { get; set; }

        public void OnGet(StudentBLL studentBLL)
        {
            Students = studentBLL.GetAllStudents();
        }
    }
}
