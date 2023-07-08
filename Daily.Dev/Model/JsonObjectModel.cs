using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daily.Dev.Model
{
    
    public class JsonObjectModel
    {
        public string type_of { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string readable_publish_date { get; set; }
        public string slug { get; set; }
        public string path { get; set; }
        public string url { get; set; }
        public int comments_count { get; set; }
        public int public_reactions_count { get; set; }
        public int? collection_id { get; set; }
        public DateTime published_timestamp { get; set; }
        public int positive_reactions_count { get; set; }
        public string cover_image { get; set; }
        public string social_image { get; set; }
        public string canonical_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? edited_at { get; set; }
        public DateTime? crossposted_at { get; set; }
        public DateTime published_at { get; set; }
        public DateTime last_comment_at { get; set; }
        public int reading_time_minutes { get; set; }
        public List<string> tag_list { get; set; }
        public string tags { get; set; }
        public User user { get; set; }
        public Organization organization { get; set; }
        public FlareTag flare_tag { get; set; }

        public class User
        {
            public string name { get; set; }
            public string username { get; set; }
            public string twitter_username { get; set; }
            public string github_username { get; set; }
            public int user_id { get; set; }
            public string website_url { get; set; }
            public string profile_image { get; set; }
            public string profile_image_90 { get; set; }
        }

        public class Organization
        {
            public string name { get; set; }
            public string username { get; set; }
            public string slug { get; set; }
            public string profile_image { get; set; }
            public string profile_image_90 { get; set; }
        }

        public class FlareTag
        {
            public string name { get; set; }
            public string bg_color_hex { get; set; }
            public string text_color_hex { get; set; }
        }
    }

}
