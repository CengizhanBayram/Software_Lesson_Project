using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    public static class GlobalSettings
    {
        public static string ConnectionString { get; set; } = "Server=localhost;Database=real_estate;Uid=root;Pwd=123456;";
        public static string DestinationPath { get; set; } = @"C:\Users\furka\source\repos\Software_Lesson_Project\RealEstateApp\RealEstateApp\Photos\";
        public static string ResourcePath { get; set; } = @"C:\Users\furka\source\repos\Software_Lesson_Project\RealEstateApp\RealEstateApp\Resources\";
        public static int? UserID { get; set; } = null; 
    }
}
