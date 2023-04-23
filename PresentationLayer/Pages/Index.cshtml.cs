using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CommonLayer;
using BusinessLogicLayer;
using System.Runtime.InteropServices;

namespace PresentationLayer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<StudentEntity> Students { get; set; }

        public void OnGet(StudentBLL studentBLL)
        {
            Students = studentBLL.GetStudentBelow3();
        }
    }
}