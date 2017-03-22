using System.Collections.Generic;
using eDidactic.Domain.Entities;

namespace eDidactic.Domain.Abstract
{
    public interface ICourseRepository
    {
        IEnumerable<Course> Courses { get; }
    }
}