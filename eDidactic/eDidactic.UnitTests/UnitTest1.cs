using System;
using System.Collections.Generic;
using System.Linq;
using eDidactic.Domain.Abstract;
using eDidactic.Domain.Entities;
using eDidactic.WebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace eDidactic.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Pageinate()
        {
            //przygotowanie
            Mock<ICourseRepository> mock = new Mock<ICourseRepository>();
            mock.Setup(m => m.Courses).Returns(new Course[]
            {
                new Course {Id = 1, Name = "C1"},
                new Course {Id = 2, Name = "C2"},
                new Course {Id = 3, Name = "C3"},
                new Course {Id = 4, Name = "C4"},
                new Course {Id = 5, Name = "C5"},
                new Course {Id = 6, Name = "C6"},
                new Course {Id = 7, Name = "C7"},
                new Course {Id = 8, Name = "C8"}
            });

            CourseController controller = new CourseController(mock.Object);
            controller.PageSize = 3;

            //dzialanie
            IEnumerable<Course> result = (IEnumerable<Course>) controller.List(2).Model;

            //asercje
            Course[] cArray = result.ToArray();
            Assert.IsTrue(cArray.Length==2);
            Assert.AreEqual(cArray[0].Name, "P4");
            Assert.AreEqual(cArray[2].Name, "P5");

        }
    }
}
