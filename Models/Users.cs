﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task
{
    using System;
    using System.Collections.Generic;

    public partial class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public Nullable<System.DateTime> SignupDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsBlocked { get; set; }
        public Nullable<System.DateTime> BlockedDate { get; set; }
    }
}
