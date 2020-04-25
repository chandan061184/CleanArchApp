using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanArch.MVC.Pages
{
    public class CourseModel : PageModel
    {
        private ICourseService _courseService;
        public CourseViewModel Course { get; set; }
        public CourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public void OnGet()
        {
            Course = _courseService.GetAllCourses(); 
        }
    }
}