using System.Web;
using WebDeveloper.API.Controllers;
using Xunit;
using FluentAssertions;
using System.Collections;
using WebDeveloper.Model;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Repository;
using System;

namespace UnitTestProject1.controller
{
    public class PersonControllerTest
    {

        private PersonController controller;
        public PersonControllerTest()
        {
            controller = new PersonController(new BaseRepository<Person>());
        }

        [Fact(DisplayName = "ListActionWithEmptyParameters")]
        public void ListActionWithEmptyParameters()
        {
            //var result = controller.List(null, null) as PartialViewResult;
            //var result = controller.List(null, null) as IAsyncResult;
            //result.ViewName.Should().Be("_List");
            //result.ViewName.Should().Be("_List");
            //result.name

            //var modelCount = (IEnumerable<Person>)result.Model;
            //modelCount.Count().Should().Be(15);
        }


        [Fact(DisplayName = "ListActionWithEmptyParameters2")]
        public void ListActionWithEmptyParameters2()
        {
            //var result = controller.List(15, null) as PartialViewResult;
            //result.ViewName.Should().Be("_List");

            //var modelCount = (IEnumerable<Person>)result.Model;
            //modelCount.Count().Should().Be(15);
        }

        [Fact(DisplayName = "ListActionWithEmptyParameters3")]
        public void ListActionWithEmptyParameters3()
        {
            //var result = controller.List(null, 14) as PartialViewResult;
            //result.ViewName.Should().Be("_List");

            //var modelCount = (IEnumerable<Person>)result.Model;
            //modelCount.Count().Should().Be(15);
        }

        [Fact(DisplayName = "CreateActionWithParameters")]
        public void CreateActionWithParameters()
        {
            var person = new Person();
            person.PersonType = "SC";
            person.FirstName = "Miguel";
            person.LastName = "Serna";
            person.rowguid = Guid.NewGuid();
            try
            {
                var result = controller.Create(person);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }

        }

        [Fact(DisplayName = "CreateActionWithParameters2")]
        public void CreateActionWithParameters2()
        {
            var person = new Person();
            person.PersonType = null;
            person.FirstName = "Lamda";
            person.LastName = "Fire";
            person.rowguid = Guid.NewGuid();
            try
            {
                var result = controller.Create(person);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }

        }

        [Fact(DisplayName = "CreateActionWithParameters3")]
        public void CreateActionWithParameters3()
        {
            var person = new Person();
            person.PersonType = null;
            person.FirstName = null;
            person.LastName = "Fire";
            person.rowguid = Guid.NewGuid();
            try
            {
                var result = controller.Create(person);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }

        }

        [Fact(DisplayName = "CreateActionWithParameters4")]
        public void CreateActionWithParameters4()
        {
            var person = new Person();
            person.PersonType = null;
            person.FirstName = null;
            person.LastName = null;
            person.rowguid = Guid.NewGuid();
            try
            {
                var result = controller.Create(person);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }

        }

        [Fact(DisplayName = "DeleteActionWithEmptyParameters")]
        public void DeleteActionWithEmptyParameters()
        {
            var person = new Person();
            person.PersonType = "SC";
            person.FirstName = "Claudia";
            person.LastName = "Pereda";
            person.rowguid = Guid.NewGuid();
            try
            {
                controller.Delete(person);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }
        }

        [Fact(DisplayName = "DeleteActionWithEmptyParameters2")]
        public void DeleteActionWithEmptyParameters2()
        {
            var person = new Person();
            person.PersonType = "SC";
            person.FirstName = "Claudia";
            person.LastName = "Pereda";
            person.rowguid = Guid.NewGuid();
            try
            {
                controller.Delete(null);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }
        }

        [Fact(DisplayName = "DeleteActionWithEmptyParameters3")]
        public void DeleteActionWithEmptyParameters3()
        {
            var person = new Person();
            person.PersonType =null;
            person.FirstName = null;
            person.LastName = null;
            person.rowguid = Guid.NewGuid();
            try
            {
                controller.Delete(null);
            }
            catch (Exception exception)
            {
                exception.Source.Should().Be("EntityFramework");
            }
        }
    }
}
