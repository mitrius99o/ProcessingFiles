using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessingFiles02.Tests
{
    [TestClass]
    public class FileProcessorTests
    {
        [TestMethod]
        public void IsFileProcessorChoosedCorrectHtmlFormat()
        { 
            File checkFile = new File("file.html");
            string expextedFileFormat = ".html";

            checkFile.ExecuteFileProcessor();

            Assert.AreEqual(expextedFileFormat, checkFile.CurrFileProcessor.rezultFileFormat);

        }

        [TestMethod]
        public void IsFileProcessorChoosedCorrectJsonFormat()
        {
            File checkFile = new File("file.json");
            string expextedFileFormat = ".json";

            checkFile.ExecuteFileProcessor();

            Assert.AreEqual(expextedFileFormat, checkFile.CurrFileProcessor.rezultFileFormat);

        }

        [TestMethod]
        public void IsFileProcessorChoosedCorrectCssFormat()
        {
            File checkFile = new File("file.css");
            string expextedFileFormat = ".css";

            checkFile.ExecuteFileProcessor();

            Assert.AreEqual(expextedFileFormat, checkFile.CurrFileProcessor.rezultFileFormat);

        }

        [TestMethod]
        public void IsFileProcessorChoosedFilesWithoutExpansion()
        {
            File checkFile = new File("file");
            string expextedFileFormat = "without expansion";

            checkFile.ExecuteFileProcessor();

            Assert.AreEqual(expextedFileFormat, checkFile.CurrFileProcessor.rezultFileFormat);
        }

        [TestMethod]
        public void EmptyStringFileProcessor()
        {
            File checkFile = new File("");

            Assert.IsNull(checkFile.CurrFileProcessor);
        }

        [TestMethod]
        public void StringWithOnlyPointFileProcessor()
        {
            File checkFile = new File(".");

            Assert.IsNull(checkFile.CurrFileProcessor);
        }
        [TestMethod]
        public void StringWithPointInTheLastFileProcessor()
        {
            File checkFile = new File("file.");

            Assert.IsNull(checkFile.CurrFileProcessor);
        }
        [TestMethod]
        public void StringWithOnlyExpansionFileProcessor()
        {
            File checkFile = new File(".html");

            Assert.IsNull(checkFile.CurrFileProcessor);
        }

    }
}
