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

        public List<StudentEntity> OnGet(StudentBLL studentBLL)
        {
            List<StudentEntity> s = studentBLL.GetAllStudents();
			Students = s;
            return s;
        }
    }
}