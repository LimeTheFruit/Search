using NUnit.Framework;

namespace TestChamber
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
    public class TestSort // Julia
    {
        public List<Word> sut;
        public Sorting myTestEngine;


        [Test]
        public void ifListGetSorted()
        {
            sut = new List<Word>();
            myTestEngine = new Sorting();
            sut.Add(new Word("Hulda", "TextFile"));
            sut.Add(new Word("Maja", "TextFile"));
            sut = myTestEngine.sortAllWords(sut);
            if (sut[0].word == "Hulda")
            {
                Assert.Pass();
            }
        }
        [Test]
        public void ifListGetSortedMoreWords()
        {
            sut = new List<Word>();
            myTestEngine = new Sorting();
            sut.Add(new Word("Hulda", "TextFile"));
            sut.Add(new Word("Maja", "TextFile"));
            sut.Add(new Word("Sten", "TextFile"));
            sut.Add(new Word("Brygga", "TextFile"));
            sut.Add(new Word("Kanna", "TextFile"));
            sut.Add(new Word("Lama", "TextFile"));

            sut = myTestEngine.sortAllWords(sut);
            if (sut[0].word == "Brygga")
            {
                Assert.Pass();
            }
        }
        [Test]
        public void ifListGetSortedWithSimilarWords()
        {
            sut = new List<Word>();
            myTestEngine = new Sorting();

            sut.Add(new Word("Anna", "TextFile"));
            sut.Add(new Word("Annas", "TextFile"));

            sut = myTestEngine.sortAllWords(sut);
            if (sut[1].word == "Annas")
            {
                Assert.Pass();
            }
        }
    }

}