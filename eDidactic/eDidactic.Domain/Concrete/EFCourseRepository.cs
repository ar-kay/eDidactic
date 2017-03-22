using System.Collections.Generic;
using eDidactic.Domain.Abstract;
using eDidactic.Domain.Entities;

namespace eDidactic.Domain.Concrete
{
    public class EFCourseRepository : ICourseRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Course> Courses
        {
            get { return context.Courses; }
        }
    }
}