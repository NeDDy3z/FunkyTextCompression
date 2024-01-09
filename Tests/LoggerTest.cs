using NUnit.Framework;
using alfadva.Log;

namespace Tests
{
    /// <summary>
    /// Tests for Logger class
    /// </summary>
    [TestFixture]
    public class LoggerTests
    {
        private string testLogFilePath;

        /// <summary>
        /// Setup method for LoggerTests
        /// </summary>
        [SetUp]
        public void Setup()
        {
            testLogFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString(), "Log.txt");
        }

        /// <summary>
        /// TearDown method for LoggerTests
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (File.Exists(testLogFilePath))
            {
                File.Delete(testLogFilePath);
            }
        }

        /// <summary>
        /// Test for WriteToLog method
        /// </summary>
        [Test]
        public void WriteToLog_ShouldAppendToLogFile()
        {
            var action = "Test action";

            Logger.WriteToLog(action);

            var logContent = File.ReadAllText(testLogFilePath);
            Assert.That(logContent, Does.Contain(DateTime.Now.ToString()));
            Assert.That(logContent, Does.Contain(action));
        }

        /// <summary>
        /// Test for WriteToLog method
        /// </summary>
        [Test]
        public void WriteToLog_InvalidFilePath_ShouldNotThrowException()
        {
            var invalidFilePath = "InvalidPath/Log.txt";
            var action = "Test action";

            Assert.DoesNotThrow(() => Logger.WriteToLog(action));
        }

        /// <summary>
        /// Test for WriteToLog method
        /// </summary>
        [Test]
        public void WriteToLog_ExceptionThrown_ShouldNotThrowException()
        {
            var invalidAction = null as string;

            Assert.DoesNotThrow(() => Logger.WriteToLog(invalidAction));
        }
    }
}