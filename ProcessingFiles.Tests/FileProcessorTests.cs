using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessingFiles01.Tests
{
    [TestClass]
    public class FileProcessorTests
    {
        [TestMethod]
        public void IsFileProcessorChoosedCorrectHtmlFormat()
        {
            string fileName = "file.html";
            string expected = ".html";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }
        [TestMethod]
        public void IsFileProcessorChoosedCorrectJsonFormat()
        {
            string fileName = "file.json";
            string expected = ".json";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }

        [TestMethod]
        public void IsFileProcessorChoosedCorrectCssFormat()
        {
            string fileName = "file.css";
            string expected = ".css";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }

        [TestMethod]

        public void IsFileProcessorChoosedFilesWithoutExpansion()
        {
            string fileName = "file";
            string expected = "without expansion";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.AreEqual(expected, fp.rezultFileFormat);
        }

        [TestMethod]
        public void EmptyStringFileProcessor()
        {
            string fileName = "";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }

        [TestMethod]
        public void StringWithOnlyPointFileProcessor()
        {
            string fileName = ".";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }

        [TestMethod]
        public void StringWithPointInTheLastFileProcessor()
        {
            string fileName = "file.";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }

        [TestMethod]
        public void StringWithOnlyExpansionFileProcessor()
        {
            string fileName = ".txt";

            FileProcessor fp = new FileProcessor();
            fp.ProcessFile(fileName);

            Assert.IsNull(fp.rezultFileFormat);
        }
    }
}
