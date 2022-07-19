using System;
using System.Collections.Generic;

namespace PersonalBlog.Models
{
    public static class PostRepository
    {
        private static List<PostModel> posts = new List<PostModel>();

        public static IEnumerable<PostModel> Posts
        {
            get
            {
                return posts;
            }
        }

        public static void AddNewPost(PostModel postModel)
        {
            posts.Add(postModel);
        }

        public static void DeletePost(PostModel postModel)
        {
            posts.Remove(postModel);
        }
    }
}
