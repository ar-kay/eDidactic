using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eDidactic.Domain.Abstract;
using eDidactic.Domain.Concrete;
using eDidactic.WebUI.Models;

namespace eDidactic.WebUI.Controllers
{
    public class CourseController : Controller
    {
        private EFDbContext db = new EFDbContext();
        //private ICourseRepository repository;
        public int PageSize = 4;

       /* public CourseController(ICourseRepository courseRepository)
        {
            this.repository = courseRepository;
        }*/

        public ViewResult List(int page = 1)
        {
            CoursesListViewModel model = new CoursesListViewModel
            {
                Courses = db.Courses
                    .Where(a => a.IsArchive == 0)
                    .OrderBy(p => p.CourseId)
                    .Skip((page - 1)*PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = db.Courses.Count()
                }
            };
            return View(model);
        }

    }
}