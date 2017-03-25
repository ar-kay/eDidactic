using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eDidactic.Domain.Abstract;

namespace eDidactic.WebUI.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository repository;
        public int PageSize = 4;

        public CourseController(ICourseRepository courseRepository)
        {
            this.repository = courseRepository;
        }

        public ViewResult List(int page = 1)
        {
            return View(repository.Courses
                .OrderBy(p => p.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));
        }

    }
}