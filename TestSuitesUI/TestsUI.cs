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

        [Test]
        public void Tc01_TestUserAuthorization()
        {
            TestsExtensionMethods extenMethods = new TestsExtensionMethods();
            LoginElements loginElem = new LoginElements();
            steps.OpenPage("https://www.mantisbt.org/bugs/my_view_page.php");
            steps.ClickLoginButton();
            steps.AuthorizeUser(User.defaultName, User.defaultPassword);
            Assert.IsTrue(extenMethods.IsElementPresent(loginElem.UserNameIcon, TimeSpan.FromSeconds(1)));
        }

        [Test]
        public void Tc02_TestCreateTask()
        {
            steps.CreateReport();    
        }
    }
}