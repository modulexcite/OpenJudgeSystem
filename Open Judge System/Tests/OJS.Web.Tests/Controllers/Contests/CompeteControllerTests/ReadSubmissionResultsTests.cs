﻿namespace OJS.Web.Tests.Controllers.Contests.CompeteControllerTests
{
    using System.Net;
    using System.Web;

    using Kendo.Mvc.UI;

    using NUnit.Framework;

    using OJS.Data.Models;

    [TestFixture]
    public class ReadSubmissionResultsTests : CompeteControllerBaseTestsClass
    {
        [Test]
        public void ReadSubmissionResultsWhenUserNotRegisteredForContestShouldThrowException()
        {
            var contest = this.CreateAndSaveContest("contest", this.ActiveContestNoPasswordOptions, this.ActiveContestNoPasswordOptions);

            var problem = new Problem();
            contest.Problems.Add(problem);

            var submissionType = new SubmissionType();
            contest.SubmissionTypes.Add(submissionType);

            this.EmptyOjsData.SaveChanges();

            try
            {
                var result = this.CompeteController.ReadSubmissionResults(new DataSourceRequest(), problem.Id, this.IsCompete);
                Assert.Fail("Expected an exception when user is not registered for exam, but tries to access his results");
            }
            catch (HttpException ex)
            {
                Assert.AreEqual((int)HttpStatusCode.Unauthorized, ex.GetHttpCode());
            }
        }
    }
}
