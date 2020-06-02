﻿using System;

namespace Model
{
    public partial class Dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
