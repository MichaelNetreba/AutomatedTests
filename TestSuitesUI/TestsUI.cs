using AutomatedTests.CommonTestEntities;
using AutomatedTests.CommonTestObjects;
using AutomatedTests.Entities;
using AutomatedTests.PageObjects;
using NUnit.Framework;
using System;

namespace AutomatedTests
{
    public class TestsUI : CommonTestClass
    {
        TestsExtensionMethods extenMethods;

        [Test]
        public void Tc01_TestUserAuthorization()
        {
            extenMethods = new TestsExtensionMethods();
            LoginElements loginElem = new LoginElements();
            steps.OpenPage("https://www.mantisbt.org/bugs/my_view_page.php");
            steps.ClickLoginButton();
            steps.AuthorizeUser(User.defaultName, User.defaultPassword);
            Assert.IsTrue(extenMethods.IsElementPresent(loginElem.UserNameIcon, TimeSpan.FromSeconds(1)));
        }

        [Test]
        public void Tc02_TestCreateTask()
        {
            TaskCreationElements creatElem = new TaskCreationElements();
            steps.CreateTask();
            Assert.IsTrue(extenMethods.IsElementPresent(creatElem.ReportID, TimeSpan.FromSeconds(5)));
        }
    }
}