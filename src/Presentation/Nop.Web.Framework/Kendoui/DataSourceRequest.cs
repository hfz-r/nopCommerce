﻿namespace Nop.Web.Framework.Kendoui
{
    public class DataSourceRequest
    {
        public DataSourceRequest()
        {
            this.Page = 1;
            this.PageSize = 10;
        }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
