using CoreCodeCamp.Data;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace CoreCodeCamp.Test
{
    public class GetAllCampsByEventDate_Should
    {
        [Fact]
        public void ReturnArrayOfCamps()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void BeInDescendingOrder()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void IncludeTalks_If_IncludeTalksTrue()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void IncludeSpeakers_If_TalksIncluded()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void NotIncludeTalks_If_IncludeTalksFalse()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

    }

    public class GetAllCampsAsync_Should
    {
        [Fact]
        public async void ReturnArrayOfCamps()
        {
            // arrange
            var mockDbContext = new Mock<CampContext>();
            var mockLogger = new Mock<ILogger<CampRepository>>();

            // Create mock repository
            var mockRepository = new CampRepository(mockDbContext.Object, mockLogger.Object);

            // act
            var result = await mockRepository.GetAllCampsAsync();

            // assert 
            Assert.Equal(typeof(Camp[]), result.GetType());
        }

        [Fact]
        public void BeInDescendingOrder()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void IncludeTalks_If_IncludeTalksTrue()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert

        }

        [Fact]
        public void IncludeSpeakers_If_TalksIncluded()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void NotIncludeTalks_If_IncludeTalksFalse()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert
        }

    }

    public class GetCampAsync_Should
    {
        [Fact]
        public void ReturnSingleCamp()
        {
            throw new NotImplementedException();
            // arrange
            // create fake repository

            // act
            // Get camps from repository

            // assert 
            // Verify that it returns an array of objects.

        }

        [Fact]
        public void ReturnCampWithMatchingMoniker()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void IncludeTalks_If_IncludeTalksTrue()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert

        }

        [Fact]
        public void IncludeSpeakers_If_TalksIncluded()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert 
        }

        [Fact]
        public void NotIncludeTalks_If_IncludeTalksFalse()
        {
            throw new NotImplementedException();
            // arrange
            // act
            // assert
        }

    }
}
