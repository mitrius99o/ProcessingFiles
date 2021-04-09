using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessingFiles01.Tests
{
    [TestClass]
    public class FileProcessorTests
    {
        private FileProcessor fp;
        [TestInitialize]
        public void TestInitialize()
        {
            fp = new FileProcessor();
        }
        [TestMethod]
        public void IsFileProcessorChoosedCorrectHtmlFormat()
        {
            string fileName = "file.html";
            string expected = ".html";

            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }
        [TestMethod]
        public void IsFileProcessorChoosedCorrectJsonFormat()
        {
            string fileName = "file.json";
            string expected = ".json";

            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }

        [TestMethod]
        public void IsFileProcessorChoosedCorrectCssFormat()
        {
            string fileName = "file.css";
            string expected = ".css";

            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }

        [TestMethod]

        public void IsFileProcessorChoosedFilesWithoutExpansion()
        {
            string fileName = "file";
            string expected = "without expansion";

            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }

        [TestMethod]
        public void EmptyStringFileProcessor()
        {
            string fileName = "";

            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }

        [TestMethod]
        public void StringWithOnlyPointFileProcessor()
        {
            string fileName = ".";

            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }

        [TestMethod]
        public void StringWithPointInTheLastFileProcessor()
        {
            string fileName = "file.";

            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }

        [TestMethod]
        public void StringWithOnlyExpansionFileProcessor()
        {
            string fileName = ".txt";

            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }
    }
}
