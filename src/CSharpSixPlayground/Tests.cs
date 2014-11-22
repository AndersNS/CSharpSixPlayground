using Xunit;
using System.Collections.Generic;
using CSharpSixPlayground.ExpressionBodiedMembers;

namespace CSharpSixFeatures
{

    public class Tests
    {
        [Fact]
        public void AutoPropertyInitializersSetsProperties()
        {
            var user = new AutoPropertyInitializers.User();

            Assert.Equal("anders", user.Name);
            Assert.Equal("anders.slinde@domain.com", user.Email);
        }

        [Fact]
        public void FilteredMethodReturnsOhNoes()
        {
            var filtering = new ExceptionFilteringClass();
            var result = filtering.DoSomething();
            Assert.Equal("oh noes", result);
        }

        [Fact]
        public void GetCommentsReturnsNullWhenPostIsNull()
        {
            var user = new NullPropagation.User();

            var comments = user.GetComments(2);

            Assert.Null(comments);
        }

        [Fact]
        public void GetCommentsReturnsNullWhenCommentsIsEmpty()
        {
            var user = new NullPropagation.User();
            user.Posts = new List<NullPropagation.Post> { new NullPropagation.Post { Id = 2 } };

            var comments = user.GetComments(2);
            Assert.Null(comments);
        }

        [Fact]
        public void GetCommentsReturnsNullWhenPostHasOneComment()
        {
            var user = new NullPropagation.User();
            user.Posts = new List<NullPropagation.Post> { new NullPropagation.Post { Id = 2 } };

            var comments = user.GetComments(2);
            Assert.Null(comments);
        }

        [Fact]
        public void GetCommentsReturnsOneWhenPostHasOneComment()
        {
            var user = new NullPropagation.User();
            user.Posts = new List<NullPropagation.Post>{
                new NullPropagation.Post { Id = 2,
                Comments =
                new List<NullPropagation.Comment> { new NullPropagation.Comment() }}};

            var comments = user.GetComments(2);
            Assert.Equal(1, comments.Value);
        }

        [Fact]
        public void SizeShouldBeTheSumOfXAndY()
        {
            var numberProp = new NumberProps();
            Assert.Equal(15, numberProp.Size);
        }
    }
}