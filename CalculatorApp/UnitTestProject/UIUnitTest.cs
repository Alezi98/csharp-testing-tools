using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using System.IO;
using TestStack.White.UIItems;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;

namespace UnitTestProject
{
    [TestClass]
    public class UIUnitTest
    {
        [TestMethod]
        public void MyFirstUITest()
        {
            var applicationPath = Path.Combine("C:/Users/fabio/Desktop/testing-tools/CalculatorApp/CalculatorApp/bin/Debug", "UserApp.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow(SearchCriteria.ByText("UserView"), InitializeOption.NoCache);

            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("nameTextbox");
            TextBox textBox = (TextBox)window.Get(searchCriteria);
            textBox.Text = "Anil";
         //   var button = window.Get<Button>(SearchCriteria.ByAutomationId("createUserButton"));
         //   button.Click();

            window.Close();
            application.Close();
        }
    }
}
