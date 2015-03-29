using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.WebUI.Models
{
    public class PagingListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfoViewModel PagingInfo { get; set; }
    }
}