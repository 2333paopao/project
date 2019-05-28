using System;

namespace Project
{
    /// <summary>
    /// Interception attribute for methods where responses are cached
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class CachedAttribute : System.Attribute
    {
        private static readonly TimeSpan defaultLifespan = TimeSpan.FromMinutes(60);

        /// <summary>
        /// Lifespan of the response in the cache
        /// </summary>
        public TimeSpan Lifespan
        {
            get
            {
                var lifespan = new TimeSpan(Days, Hours, Minutes, Seconds);

                if (lifespan.Equals(TimeSpan.Zero))
                {
                    return defaultLifespan;
                }

                return lifespan;
            }
        }

        /// <summary>
        /// Whether caching is enabled
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// Days the element to be cached should live in the cache
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// Hours the element to be cached should live in the cache
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// Minutes the element to be cached should live in the cache
        /// </summary>
        public int Minutes { get; set; }

        /// <summary>
        /// Seconds the items should live in the cache
        /// </summary>
        public int Seconds { get; set; }
    }
}
