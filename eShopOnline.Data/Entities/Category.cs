using eShopOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public int SortOrder { get; set; }
        public bool isShowOnHome { get; set; }
        public int ParentID { get; set; }
        public Status Status { get; set; }
    }
}
