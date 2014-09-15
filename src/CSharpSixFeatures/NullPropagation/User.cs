using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSixFeatures.NullPropagation
{
    public class User(string name, string email)
    {
        public string Name { get; } = name;
        public string Email { get; } = email;

        public List<Post> Posts { get; set; }

        public int? GetComments(int postId)
        {
            return Posts?.FirstOrDefault(x => x.Id == postId)?.Comments?.Count();
        }
    }

    public class Post
    {
        public List<Comment> Comments { get; set; }
        public int Id { get; set; }
    }

    public class Comment
    {
        public string Text { get; set; }
    }
}