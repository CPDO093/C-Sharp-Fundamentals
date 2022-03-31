using _06_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            StreamingContent content = new StreamingContent();


            content.Title = "Toy Stroy";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.G,true)]
        [DataRow(MaturityRating.TV_PG,true)]
        [DataRow(MaturityRating.R,false)]
        [DataRow(MaturityRating.TV_MA,false)]

        public void SetMaturityRating_ShouldGetCorrectFamilyFriendliness(MaturityRating rating, bool expectedFamilyFriendly)
        {
            // triple A paradigm a short hand for test setup


            //arrange => set the stage
            StreamingContent content = new StreamingContent("some title", "some description", 5, rating, GenreType.Horror);


            //act=> execute any code you need
            bool actual = content.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;


            // assert=> call your assertions
            Assert.AreEqual(expected, actual);


        }
    }
}
