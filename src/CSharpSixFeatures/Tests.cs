using Xunit;
using System.Collections.Generic;

namespace CSharpSixFeatures
{

    public class Tests
    {
	    [Fact]
        public void PrimaryConstructorSetsFields()
        {
            var user = new PrimaryConstructor.User("anders", "anders.slinde@domain.com");

            Assert.Same("anders", user.Name);
            Assert.Same("anders.slinde@domain.com", user.Email);
        }

        [Fact]
        public void AutoPropertyInitializersSetsProperties()
        {
            var user = new AutoPropertyInitializers.User("anders", "anders.slinde@domain.com");

            Assert.Equal("anders", user.Name);
            Assert.Equal("anders.slinde@domain.com", user.Email);
        }

        [Fact]
        public void NumberParserReturnsInt()
        {
            var parser = new Numberparser();

            var number = parser.ParseString("2");

            Assert.Equal(2, number);
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
            var user = new NullPropagation.User("anders", "email");

            var comments = user.GetComments(2);

            Assert.Null(comments);
        }

        [Fact]
        public void GetCommentsReturnsNullWhenCommentsIsEmpty()
        {
            var user = new NullPropagation.User("anders", "email");
            user.Posts = new List<NullPropagation.Post> { new NullPropagation.Post { Id = 2 } };

            var comments = user.GetComments(2);
            Assert.Null(comments);
        }

        [Fact]
        public void GetCommentsReturnsNullWhenPostHasOneComment()
        {
            var user = new NullPropagation.User("anders", "email");
            user.Posts = new List<NullPropagation.Post> { new NullPropagation.Post { Id = 2 } };

            var comments = user.GetComments(2);
            Assert.Null(comments);
        }

        [Fact]
        public void GetCommentsReturnsOneWhenPostHasOneComment()
        {
            var user = new NullPropagation.User("anders", "email");
            user.Posts = new List<NullPropagation.Post>{
                new NullPropagation.Post { Id = 2,
                Comments =
                new List<NullPropagation.Comment> { new NullPropagation.Comment() }}};

            var comments = user.GetComments(2);
            Assert.Equal(1, comments.Value);
        }
    }
}