using CoreCodeCamp.Data;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

            var data = new List<Camp>
            {
                new Camp
                {
                    CampId = 1,
                    Name = "MyMockCamp",
                    Moniker = "MyMockMoniker",
                },
                new Camp
                {
                    CampId = 2,
                    Name = "MyMockCamp2",
                    Moniker = "MyMockMoniker2",
                }

            }.AsQueryable();

            var mockCamps = new Mock<DbSet<Camp>>();
            mockCamps.As<IQueryable<Camp>>().Setup(m => m.Provider).Returns(data.Provider);
            mockCamps.As<IQueryable<Camp>>().Setup(m => m.Expression).Returns(data.Expression);
            mockCamps.As<IQueryable<Camp>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockCamps.As<IQueryable<Camp>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            mockDbContext.Setup(c => c.Camps).Returns(mockCamps.Object);

            var campRepository = new CampRepository(mockDbContext.Object, mockLogger.Object);

            // act
            var result = await campRepository.GetAllCampsAsync();

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
