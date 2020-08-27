using CoreCodeCamp.Data;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void ReturnArrayOfCamps()
        {
            // arrange
            var campContextMock = new Mock<CampContext>();


            // act
            // Get camps from repository

            // assert 
            // Verify that it returns an array of objects.

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
