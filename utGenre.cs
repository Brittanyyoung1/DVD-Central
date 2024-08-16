using CG.DVDCentral.BL.Models;

namespace CG.DVDCentral.BL.Test
{
    [TestClass]
    public class utGenre
    {
        [TestMethod]
        public void LoadTest()
        { 
            Assert.AreEqual(4, GenreManager.Load().Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            int id = 0;
            Genre genre = new Genre()
            {
                Description = "Test"
            };

            int results = GenreManager.Insert(genre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int id = 0;
            Genre genre = GenreManager.LoadById(3);
            genre.Description = "UpdateTest";
            int results = GenreManager.Update(genre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int results = GenreManager.Delete(3, true);
            Assert.AreEqual(1, results);
        }
    }
}