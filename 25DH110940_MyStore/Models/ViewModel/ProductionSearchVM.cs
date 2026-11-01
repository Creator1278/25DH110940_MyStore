using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _25DH110940_MyStore.Models.ViewModel
{
    public class ProductionSearchVM
    {
        // tieu chi search theo ten mo ta sp hoac loai sp
        public string SearchTerm { get; set; }
        //cac tieu chi search theo gia sp
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        //Thu tu sap xep
        public string SortOrder { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;

        //danh sach sp thoa dk tim kiem
        public PagedList.IPagedList<Product> Products { get; set; }

    }
}