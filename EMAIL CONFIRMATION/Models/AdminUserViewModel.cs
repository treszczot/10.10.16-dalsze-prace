﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMAIL_CONFIRMATION.Models
{
    public class AdminUserViewModel
    {
        public string UserName { get; set; }
        public string RankName { get; set; }
        public string UserId { get; set; }
        public string UserFullName { get; set; }
        public string RankId { get; set; }
    }

    public class AdminEditViewModel
    {
        public string UserName { get; set; }
        public string RankName { get; set; }
        public string Email { get; set; }
    }
    public class AdminRoleViewModel
    {
        public string Role { get; set; }
        public string RoleId { get; set; }
        public string RoleValue { get; set; }
    }
}
