using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using System.Diagnostics;
using TestStack.White;
using NUnit.Framework;
using System.Threading;
using TestStack.White.Factory;

namespace FlaUItest.demo
{
    [TestClass]
    public class UnitTest1
    {
          public Application app;

        [TestInitialize]
        public void before()
        {
            string apppath = @"D:/Users/farhanShaikh/Desktop/Telerik OutlookInspiredApp for WPF.appref-ms";
            var prc = new ProcessStartInfo(apppath);
            app = Application.Launch(prc);
            Thread.Sleep(10000);
        }


        [TestMethod]
        public void InvokeApplication()
        {
            string apppath = @"D:/Users/farhanShaikh/Desktop/Telerik OutlookInspiredApp for WPF.appref-ms";
            var prc = new ProcessStartInfo(apppath);
            app = Application.Launch(prc);
            Thread.Sleep(80000);
            //Getting the window object a
            Window Tele = (Window)app.GetWindow("C:/Users/shaik/Desktop/Telerik OutlookInspiredApp for WPF.appref-ms");



            //Getting the controls
            //By Automation id
            Button btnemail = Tele.Get<Button>(SearchCriteria.ByAutomationId("Row_5"));
            Button btnemail2 = Tele.Get<Button>(SearchCriteria.ByAutomationId("Row_9"));
            Button btnsearch = Tele.Get<Button>(SearchCriteria.ByAutomationId("SearchWatermarkTextBox"));


            //Performing Clicks 
            btnemail.Click();
            btnsearch.Click();
            btnemail2.Click();

            Label txtResult = Tele.Get<Label>(SearchCriteria.ByAutomationId("158"));
            //Assert will check if the expected equals Actual
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("20", txtResult.Name);

        }
    }
}
