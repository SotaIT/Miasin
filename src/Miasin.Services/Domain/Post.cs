using System;

namespace Miasin.Services.Domain
{
    /// <summary>
    /// A Post created by a User
    /// </summary>
    public class Post: BaseEntity<long>
    {
        /// <summary>
        /// Author nickname
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Created
        /// </summary>
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Publish datetime. Can be set to a later date so that the Post is published at that datetime.
        /// </summary>
        public DateTimeOffset? Published { get; set; }

        /// <summary>
        /// Modified datetime. Should not be set to a value smaller than Published.
        /// </summary>
        public DateTimeOffset? Modified { get; set; }
    }
}