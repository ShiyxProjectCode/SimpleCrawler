﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UrlQueue.cs" company="pzcast">
//   (C) 2015 pzcast. All rights reserved.
// </copyright>
// <summary>
//   The url queue.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Crawler.Sample
{
    /// <summary>
    /// The url queue.
    /// </summary>
    public class UrlQueue : SecurityQueue<UrlInfo>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Prevents a default instance of the <see cref="UrlQueue"/> class from being created.
        /// </summary>
        private UrlQueue()
        {
        }

        #endregion Constructors and Destructors

        #region Public Properties

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static UrlQueue Instance
        {
            get
            {
                return Nested.Inner;
            }
        }

        #endregion Public Properties

        /// <summary>
        /// The nested.
        /// </summary>
        private static class Nested
        {
            #region Static Fields

            /// <summary>
            /// The inner.
            /// </summary>
            internal static readonly UrlQueue Inner = new UrlQueue();

            #endregion Static Fields
        }
    }
}