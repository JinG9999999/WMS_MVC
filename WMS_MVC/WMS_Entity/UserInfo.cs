﻿using System;

namespace WMS_Entity
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserNickname { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public bool Sex { get; set; }
        public int DeptId { get; set; }
        public bool IsOK { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int RoleId { get; set; }

        public int IsLogin { get; set; }
        public int Isok { get; set; }
        public string Name { get; set; }
    }
}
