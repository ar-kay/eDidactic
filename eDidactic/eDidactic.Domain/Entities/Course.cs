using System;
using Glimpse.Mvc.AlternateType;

namespace eDidactic.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsArchive { get; set; }
   
        
    }
}