using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Data;
using WinFormsApp.EFModels;
using WinFormsApp.Presenter;

namespace WinFormsApp.Test
{
    [TestFixture]
    public class Tests
    {
        private Mock<WinFormsAppContext> _mockContext;
        private Mock<DbSet<User>> _mockSet;
        private SamplePresenter _presenter;

        [SetUp]
        public void Setup()
        {
            _mockContext = new Mock<WinFormsAppContext>();
            _mockSet = new Mock<DbSet<User>>();
            _presenter = new SamplePresenter(_mockContext.Object);

            _mockContext.Setup(m => m.Users).Returns(_mockSet.Object);
        }

        [Test]
        public void GetColors_ReturnsColorList_WhenCalled()
        {
            var data = new List<Color>
                {
                    new Color { ColorId = 1, ColorName = "Red" },
                    new Color { ColorId = 2, ColorName = "Blue" },
                    new Color { ColorId = 3, ColorName = "Green" }
                }.AsQueryable();

            var mockSet = new Mock<DbSet<Color>>();
            mockSet.As<IQueryable<Color>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Color>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Color>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Color>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            _mockContext.Setup(c => c.Colors).Returns(mockSet.Object);

            var result = _presenter.GetColors();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count); // checking if count matches
            Assert.AreEqual("Red", result[0].ColorName); // checking if color name matches
        }

        [Test]
        public void GetUsers_ReturnsUserList_WhenCalled()
        {
            var colors = new List<Color>
                {
                    new Color { ColorId = 1, ColorName = "Red" }
                }.AsQueryable();

            var users = new List<User>
                {
                    new User { UserId = 1, UserName = "John Doe", Email = "john@example.com", BirthDay = DateOnly.MinValue, ColorId = 1, Married = true, Deleted = false },
                    new User { UserId = 2, UserName = "Jane Doe", Email = "jane@example.com", BirthDay = DateOnly.MinValue, ColorId = 1, Married = false, Deleted = false }
                }.AsQueryable();

            var mockColorSet = new Mock<DbSet<Color>>();
            mockColorSet.As<IQueryable<Color>>().Setup(m => m.Provider).Returns(colors.Provider);
            mockColorSet.As<IQueryable<Color>>().Setup(m => m.Expression).Returns(colors.Expression);
            mockColorSet.As<IQueryable<Color>>().Setup(m => m.ElementType).Returns(colors.ElementType);
            mockColorSet.As<IQueryable<Color>>().Setup(m => m.GetEnumerator()).Returns(colors.GetEnumerator());

            var mockUserSet = new Mock<DbSet<User>>();
            mockUserSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(users.Provider);
            mockUserSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(users.Expression);
            mockUserSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(users.ElementType);
            mockUserSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());

            _mockContext.Setup(c => c.Colors).Returns(mockColorSet.Object);
            _mockContext.Setup(c => c.Users).Returns(mockUserSet.Object);

            var result = _presenter.GetUsers();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count); // checking if user count matched
            Assert.AreEqual("John Doe", result[0].Name); // checking if the name matches
            Assert.AreEqual("Red", result[0].Color); // checking if color matches
        }

        [Test]
        public void InsertUser_AddsUserToContextAndSavesChanges()
        {
            var user = new User
            {
                UserId = 0,
                UserName = "Test User",
                Email = "test@example.com",
                BirthDay = DateOnly.MinValue,
                ColorId = 1,
                Married = true
            };

            _presenter.InsertUser(user);

            _mockSet.Verify(m => m.Add(It.Is<User>(u => u == user)), Times.Once); // checking if user was added
            _mockContext.Verify(m => m.SaveChanges(), Times.Once); // checking if SaveChanges was called
        }

        [Test]
        public void DeleteUser_WhenUserExists_SetsDeletedToTrueAndSavesChanges()
        {
            var userId = 1;
            var user = new User
            {
                UserId = userId,
                UserName = "Test User",
                Email = "test@example.com",
                BirthDay = DateOnly.MinValue,
                ColorId = 1,
                Married = true,
                Deleted = false
            };
            _mockSet.Setup(m => m.Find(It.Is<long>(id => id == userId))).Returns(user);

            _mockContext.Setup(c => c.Users).Returns(_mockSet.Object);

            _presenter.DeleteUser(userId);

            Assert.IsTrue(user.Deleted); // checking if the user's 'Deleted' property is set to true
            _mockContext.Verify(m => m.SaveChanges(), Times.Once); // checking if SaveChanges was called
        }
    }
}