﻿using System.ComponentModel.DataAnnotations;

namespace FSE.ProjectManagementPortal.DataContract
{
    public class UserModel
    {
        
        public string Employee_ID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string Last_Name { get; set; }
        public int User_ID { get; set; }
        public int? Project_ID { get; set; }
        public int? Task_ID { get; set; }
        public bool IsActive { get; set; }
        
    }
}
