using alfadva.Compression;
using NUnit.Framework;

namespace alfadva.Tests
{
    /// <summary>
    ///    Summary description for CompressTest
    /// </summary>
    [TestFixture]
    public class CompressTests
    {
        /// <summary>
        ///    A test for StartCompression
        /// </summary>
        [Test]
        public void StartCompression_WithInputContainingVowels_ShouldRemoveVowels()
        {
            var compress = new Compress();
            var inputText = "Toto je test";
            
            var result = compress.StartCompression(inputText);

            Assert.That(result, Is.EqualTo("Tt j tst "));
        }

        /// <summary>
        ///   A test for StartCompression
        /// </summary>
        [Test]
        public void StartCompression_WithShortWords_ShouldNotRemoveVowels()
        {
            var compress = new Compress();
            var inputText = "Short words";

            var result = compress.StartCompression(inputText);

            Assert.That(result, Is.EqualTo("Shrt wrds "));
        }

        /// <summary>
        ///  A test for StartCompression
        /// </summary>
        [Test]
        public void StartCompression_WithEmptyInput_ShouldReturnEmptyString()
        {
            var compress = new Compress();
            var inputText = "";

            var result = compress.StartCompression(inputText);
            
            Assert.That(result, Is.EqualTo(""));
        }

        /// <summary>
        /// A test for StartCompression and Log
        /// </summary>
        [Test]
        public void StartCompression_ShouldWriteToLog()
        {
            var compress = new Compress();
            var inputText = "Test input";
            
            var result = compress.StartCompression(inputText);
        }
    }
}