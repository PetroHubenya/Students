using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CommonLayer;
using BusinessLogicLayer;
using System.Runtime.InteropServices;
using DataAccessLayer;

namespace PresentationLayer.Pages
{
    public class IndexModel : PageModel
    {
        public List<StudentEntity> Students { get; set; }

        public void OnGet(StudentBLL studentBLL)
        {
            Students = studentBLL.GetStudentBelow3();
        }
    }
}