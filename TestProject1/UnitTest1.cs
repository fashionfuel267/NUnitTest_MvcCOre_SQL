using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private  AppDbContext _context;
        [SetUp]
        public void Setup()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer("Server=DESKTOP-PNALNN3\\SQLEXPRESS;Database=EfCore5WebApp;Trusted_Connection = True; MultipleActiveResultSets = true;Trust server certificate=true;")
            .Options);
        }
        [Test]
        public void GetAllPersons()
        {
            //Arrange & Act
            IEnumerable<Person> persons = _context.Persons.ToList();
            //assert
            Assert.AreEqual(5, persons.Count());
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TearDown]
        public void TearDown() {
            _context.Dispose();
        }
    }
}