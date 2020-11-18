﻿using System.Collections.Generic;

namespace ServerSideBlazorApp.Models
{
    public class PageRequestModel : PageModel 
    {
        public PageRequestModel() 
        {
        }

        public PageRequestModel(int offset, int limit) : base(offset, limit)
        {
        }

        public PageRequestModel(int offset, int limit, string searchPhrase = null) : base(offset, limit, searchPhrase)
        {
        }

        public PageRequestModel(int offset, int limit, string searchPhrase = null, Sort sort = null) : base(offset, limit, searchPhrase, sort)
        {
        }

        public PageRequestModel(int offset, int limit, string searchPhrase = null, IEnumerable<Sort> sorting = null) : base(offset, limit, searchPhrase, sorting)
        {
        }
    }
}
