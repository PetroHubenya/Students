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
        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */


        /*
        public List<StudentEntity> Students { get; set; }

        public void OnGet(StudentBLL studentBLL)
        {
            Students = studentBLL.GetStudentBelow3();
        }
        */

        private readonly StudentBLL _studentBLL;

        public IndexModel(StudentBLL studentBLL)
        {
            _studentBLL = studentBLL;
        }

        public List<StudentEntity> Students { get; set; }

        public void OnGet()
        {
            Students = _studentBLL.GetStudentBelow3();
        }
    }
}