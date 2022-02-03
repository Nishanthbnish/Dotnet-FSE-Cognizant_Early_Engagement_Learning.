using Moq;
using NUnit.Framework;
using System;

namespace PlayersManagerLib.UnitTest
{
    [TestFixture]
    public class PlayerManagerTests
    {
        private Mock<IPlayerMapper> _playerMapper;

        [OneTimeSetUp]
        public void Inint()
        {
            _playerMapper = new Mock<IPlayerMapper>();          
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void RegisterNewPlayer_NameIsNullOrWhiteSpace_ReturnException(string name)
        {
            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(name, _playerMapper.Object));
        }

        [Test]
        [TestCase("abc")]
        public void RegisterNewPlayer_PlayerExistInDb_ReturnException(string name)
        {
            _playerMapper.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(name, _playerMapper.Object));
        }
        
        [Test]
        [TestCase("abc")]
        public void RegisterNewPlayer_AddNewPlayer_ReturnPlayer(string name)
        {
            _playerMapper.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
            _playerMapper.Setup(x => x.AddNewPlayerIntoDb(It.IsAny<string>()));

            var result = Player.RegisterNewPlayer(name, _playerMapper.Object);

            Assert.That(result, Is.TypeOf<Player>());
            Assert.That(result.Country, Is.EqualTo("India").IgnoreCase);
        }
    }
}
