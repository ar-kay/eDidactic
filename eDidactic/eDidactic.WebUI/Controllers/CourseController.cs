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

        public CourseController(ICourseRepository courseRepository)
        {
            this.repository = courseRepository;
        }

        public ViewResult List()
        {
            return View(repository.Courses);
        }

    }
}