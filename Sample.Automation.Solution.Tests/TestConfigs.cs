using Logging.Utilities.Logging;
using Parsing.Utilities.Parsers;
using System;

namespace Sample.Automation.Solution.Tests
{
    class TestConfigs
    {
        //Application Settings
        public static string Url;
        public static string Browser;

        //Automation Configs
        public static string AutomationDirectory;

        //Files
        public static string TestDataFile;

        //Logs
        public static string LogDirectory;

        //Maximum number of retries if the test failed
        public const int MaxNumberOfRetries = 1;
        public static bool IsTestConfigsInitialized = false;

        //Reporting Directory
        public static string ReportingDirectory;

        //Email to send report to
        public static string Email;

        public static void SetCurrentContextPath(string nameOfTestingDirectory)
        {
            
            AutomationDirectory = AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory;

            //AutomationDirectory = currentPath;
        }

        /// <summary>
        /// Read the configurations of the application under test
        /// </summary>
        public void ReadApplicationConfigs()
        {
        }//end method ReadApplicationConfigs

        /// <summary>
        /// Read the provided test configurations
        /// </summary>
        public static void ReadConfigs(string pathOfAutomationConfigs)
        {
            
            //Load the Automation Configs
            TextDataParser.LoadConfigurationValues(pathOfAutomationConfigs);

            Url = TextDataParser.GetValue("Url");
            Browser = TextDataParser.GetValue("Browser");
            TestDataFile = AutomationDirectory + TextDataParser.GetValue("TestDataFile");
            LogDirectory = AutomationDirectory + TextDataParser.GetValue("LoggingDirectory");
            ReportingDirectory = AutomationDirectory + TextDataParser.GetValue("ReportingDirectory");
            Email = TextDataParser.GetValue("Email");

        }//end method ReadConfigs


        /// <summary>
        /// Initialize the test configurations
        /// </summary>
        public static void Init()
        {
            if (!IsTestConfigsInitialized)
            {
                string configurationFile = AutomationDirectory + "\\automation.conf";
                //Read the automated app configs
                ReadConfigs(configurationFile);

                AutomatedLogger.Init(LogDirectory);

                //Initialize your configs: messages, test data, logger, ...
                ExcelDataParser.Init(TestConfigs.TestDataFile);

                IsTestConfigsInitialized = true;

            }//endif

        }//end method


        /// <summary>
        /// Check if you are testing remotely or on a localhost
        /// </summary>
        /// <returns></returns>
        public static bool IsRemoteTesting()
        {
            bool isRemote = !Url.Contains("localhost");
            return isRemote;
        }
    }
}
