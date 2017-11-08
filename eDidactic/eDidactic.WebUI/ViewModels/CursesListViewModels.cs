using System.Collections.Generic;
using eDidactic.Domain.Entities;

namespace eDidactic.WebUI.Models
{
    public class CoursesListViewModels
    {
        public IEnumerable<Course> Courses { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}