using alfadva.FileManagement;
using NUnit.Framework;

namespace alfadva.Tests
{
    /// <summary>
    /// Test for FileManager class
    /// </summary>
    [TestFixture]
    public class FileManagerTest
    {
        private string testFilePath;
        private const string testContent = "Testovací obsah";

        /// <summary>
        /// Create a temporary test file for each test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            File.WriteAllText(testFilePath, testContent);
        }

        /// <summary>
        /// Clean up the temporary test file after each test
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        /// <summary>
        /// Test for Read method
        /// </summary>
        [Test]
        public void Read_ValidPath_ShouldReturnFileContent()
        {
            var content = FileManager.Read(testFilePath);
            Assert.That(content, Is.EqualTo(testContent));
        }

        /// <summary>
        /// Test for Read method
        /// </summary>
        [Test]
        public void Read_InvalidPath_ShouldReturnNull()
        {
            var content = FileManager.Read("InvalidPath");


            Assert.That(content, Is.Null);
        }
        
        /// <summary>
        /// Test for Read method
        /// </summary>
        [Test]
        public void Read_ExceptionThrown_ShouldReturnNull()
        {
            var invalidPath = "InvalidPath";
            
            var content = FileManager.Read(invalidPath);
            
            Assert.That(content, Is.Null);
        }

        /// <summary>
        /// Test for Write method
        /// </summary>
        [Test]
        public void Write_ValidPath_ShouldWriteToFile()
        {
            var newContent = "Nový ";
            
            FileManager.Write(testFilePath, newContent);
            
            var contentAfterWrite = File.ReadAllText(testFilePath);
            Assert.That(contentAfterWrite, Is.EqualTo(newContent));
        }

        /// <summary>
        /// Test for Write method
        /// </summary>
        [Test]
        public void Write_InvalidPath_ShouldNotThrowException()
        {
            var invalidPath = "InvalidPath";
            
            Assert.DoesNotThrow(() => FileManager.Write(invalidPath, "Test content"));
        }
    }
}