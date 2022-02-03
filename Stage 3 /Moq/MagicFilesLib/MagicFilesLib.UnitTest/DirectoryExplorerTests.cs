using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MagicFilesLib.UnitTest
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _directoryExplorer;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            _directoryExplorer = new Mock<IDirectoryExplorer>();
            _directoryExplorer.Setup(x => x.GetFiles(It.IsAny<string>())).Returns(() => new List<string> { _file1, _file2 });
        }

        [Test]
        [TestCase("abc")]
        [TestCase("xyz")]
        public void GetFiles_WhenCalled_ReturnListOfFiles(string input)
        {
            var files = _directoryExplorer.Object.GetFiles(input);

            Assert.IsNotNull(files);
            Assert.IsTrue(files.Count == 2);
            Assert.That(files, Contains.Item(_file1));
        }
    }
}
