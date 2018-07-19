using FileParsingChain;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace FileParsingChainTests
{
    [TestFixture]
    public class FileParserTests
    {
        [Test]
        public void WhenFileExtensionIsTxt_ExpectTextFileToBeAParser()
        {
            //Arrange
            var fileName = "Check.txt";

            var text = new TextFile();
            var json = new JsonFile();
            var csv = new CsvFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(fileName);

            //Assert
            var expected = "File Parsed with Text Parser";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void WhenFileExtensionIsCsv_ExpectCSVFileToBeAParser()
        {
            //Arrange
            var fileName = "Check.csv";

            var text = new TextFile();
            var json = new JsonFile();
            var csv = new CsvFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(fileName);

            //Assert
            var expected = "File Parsed with Csv Parser";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void WhenFileExtensionIsJson_ExpectJSONFileToBeAParser()
        {
            //Arrange
            var fileName = "Check.json";

            var text = new TextFile();
            var json = new JsonFile();
            var csv = new CsvFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(fileName);

            //Assert
            var expected = "File Parsed with Json Parser";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void WhenFileExtensionIsXml_ExpectXmlFileToBeAParser()
        {
            //Arrange
            var fileName = "Check.xml";

            var text = new TextFile();
            var json = new JsonFile();
            var csv = new CsvFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(fileName);

            //Assert
            var expected = "File Parsed with XML Parser";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void WhenFileExtensionIsInvalid_ExpectOnlyProvidesXmlTxtCsvAndJsonFiles()
        {
            //Arrange
            var fileName = "Check.cs";

            var text = new TextFile();
            var json = new JsonFile();
            var csv = new CsvFile();
            var xml = new XmlFile();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(fileName);

            //Assert
            var expected = "Only provides xml,txt,csv and json files";
            Assert.AreEqual(expected, fakeoutput.ToString());
        }
    }
}
