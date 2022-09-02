﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement_2.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [Display(Name="Default Number of Days")]
        public int DefaultDays { get; set; }    
    }
}
