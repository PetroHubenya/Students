using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CommonLayer;
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

        public void OnGet()
        {
            List<StudentEntity> students = new()
            {
                new StudentEntity()
                {
                    Id = 1,
                    Name = "Name1",
                    Email = "name1@gmail.com",
                    Age = 20
                },

                new StudentEntity()
                {
                    Id = 2,
                    Name = "Name2",
                    Email = "name2@gmail.com",
                    Age = 20
                },

                new StudentEntity()
                {
                    Id = 3,
                    Name = "Name3",
                    Email = "name3@gmail.com",
                    Age = 20
                }
            };

            Students = students;


        }
    }
}