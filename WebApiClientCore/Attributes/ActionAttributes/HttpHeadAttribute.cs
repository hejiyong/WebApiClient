﻿using System.Net.Http;

namespace WebApiClientCore.Attributes
{
    /// <summary>
    /// 表示Head请求
    /// </summary>
    public class HttpHeadAttribute : HttpMethodAttribute
    {
        /// <summary>
        /// Head请求
        /// </summary>
        public HttpHeadAttribute()
            : base(HttpMethod.Head)
        {
        }

        /// <summary>
        /// Head请求
        /// </summary>
        /// <param name="path">请求绝对或相对路径</param>
        public HttpHeadAttribute(string? path)
            : base(HttpMethod.Head, path)
        {
        }
    }
}
