﻿using MarsQA_1.Helpers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;


namespace MArsQASpecflow.SpecflowPages.Utils
{
    [Binding]
    public class Hooks1 : Driver
    {
        //For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        //private static ExtentTest featureName;
        //private static ExtentTest scenario;
        // private static ExtentReports extent;
        public static string ReportPath;
        public static string ReportXMLPath;
        //private static ExtentHtmlReporter htmlReporter;

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        #endregion


        [BeforeScenario]
        [Obsolete]
        public void Setup()
        {
           //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Credentials");
            //call the SignIn class
           MarsQA_1.Pages.SignIn.SigninStep();

           //Console.WriteLine("BeforeScenario");
            //scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }



        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ReportXMLPath);

            //string reportPath = ConstantHelpers.ReportsPath;
            //htmlReporter = new ExtentHtmlReporter(reportPath);
            //extent = new ExtentReports();
            // extent.AttachReporter(htmlReporter);
            //extent.AddTestRunnerLogs(reportPath + "Extent Config.xml");
        }

        /*[BeforeFeature]
        [Obsolete]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("BeforeFeature");
        }*/


       /* [AfterStep]
        [Obsolete]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }
        }*/

        /*[AfterTestRun]
        public static void AfterTestRun()
        {

            //kill the browser
            //Flush report once test completes
            extent.Flush();
            //kill the browser
        }*/

        [AfterScenario]
        public void TearDown()
        {

            Thread.Sleep(5000);
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                String img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
                test.Log(LogStatus.Error, "Image example: " + test.AddScreenCapture(img));
            }
            else
            {
                String img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
                test.Log(LogStatus.Pass, "Image example: " + test.AddScreenCapture(img));
            }
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)       
            driver.Close();
        }




    }
}
