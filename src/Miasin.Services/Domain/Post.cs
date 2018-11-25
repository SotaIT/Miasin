using System;

namespace Miasin.Services.Domain
{
    public class Post: Services.Domain.BaseEntity<long>
    {
        /// <summary>
        /// Author nickname
        /// </summary>
        public string AuthorId { get; set; }

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
        /// Publish datetime. 
        /// Can be set to a later date so that the Post is published at that datetime
        /// </summary>
        public DateTimeOffset? Published { get; set; }

        /// <summary>
        /// Modified datetime. Should not be set a value, smaller than Published
        /// </summary>
        public DateTimeOffset? Modified { get; set; }
    }
}