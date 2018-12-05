using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;

namespace CommLikes
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]

    public class MainActivity : ListActivity
    {
        public static List<Post> posts;
        public static List<Comment> comments;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            if (posts == null) TestPosts();

            ListAdapter = new PostAdapter(this, posts);

            FindViewById<Button>(Resource.Id.addPost).Click += addPostButton;
        }

        private void addPostButton(object sender, EventArgs e)
        {
            EditText editText = FindViewById<EditText>(Resource.Id.content);
            posts.Add(new Post
            {
                Name = "User",
                Message = editText.Text,
                Likes = 0,
                Date = DateTimeOffset.Now,
                Comments = new List<Comment>()
            });
            editText.Text = "";
            ListAdapter = new PostAdapter(this, posts);
        }

        public void TestPosts()
        {
            posts = new List<Post>();
            comments = new List<Comment>();

            Comment Comment = new Comment
            {
                Name = "Keegi",
                Message = "ELU ON ILUS",
                Likes = 2
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Anon",
                Message = "Pane like mulle!",
                Likes = 228
            };
            comments.Add(Comment);

            Post post = new Post
            {
                Name = "Penguin",
                Message = "Keri edasi...",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1541056855),
                Comments = comments
            };
            posts.Add(post);

            comments = new List<Comment>();

            Comment = new Comment
            {
                Name = "Juurikas",
                Message = "hmmm",
                Likes = 3
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Keegi2",
                Message = "OK",
                Likes = 5
            };
            comments.Add(Comment);

         

            post = new Post
            {
                Name = "Tort",
                Message = "Kena ju",
                Likes = 99,
                Date = DateTimeOffset.FromUnixTimeSeconds(1500056855),
                Comments = comments,
                Pic = Resource.Drawable.light
            };
            posts.Add(post);

            comments = new List<Comment>();

         
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Katse1",
                Message = "Test1",
                Likes = 20
            };
            comments.Add(Comment);

            Comment = new Comment
            {
                Name = "Katse2",
                Message = "Test2",
                Likes = 30
            };
            comments.Add(Comment);

            post = new Post
            {
                Name = "JAAN",
                Message = "Katse!!!",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1305056855),
                Comments = comments
            };
            posts.Add(post);

            comments = new List<Comment>();

            Comment = new Comment
            {
                Name = "Hommik",
                Message = "wow",
                Likes = 10
            };
            comments.Add(Comment);


            post = new Post
            {
                Name = "katse",
                Message = "Jah",
                Likes = 0,
                Date = DateTimeOffset.FromUnixTimeSeconds(1205056005),
                Comments = comments,
                Pic = Resource.Drawable.flower
            };
            posts.Add(post);
        }
    }
}