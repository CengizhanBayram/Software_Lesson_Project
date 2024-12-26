using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    public static class GlobalSettings
    {
        public static string ConnectionString { get; set; } = "Server=localhost;Database=swe_real_estate;Uid=root;Pwd=123456;";
        public static string DestinationPath { get; set; } = @"C:\Users\furka\source\repos\Software_Lesson_Project\RealEstateApp\RealEstateApp\Photos\";
        public static string ResourcePath { get; set; } = @"C:\Users\furka\source\repos\Software_Lesson_Project\RealEstateApp\RealEstateApp\Resources\";
        public static int? UserID { get; set; } = null;
        public static string[] iller { get; set; } = new string[]
        {
            "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya",
            "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
            "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne",
            "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
            "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş",
            "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli",
            "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin",
            "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize",
            "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ",
            "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"
        };
        public static string[] roomNumber { get; set; } = new string[]
         {
            "1+0", "1+1", "2+1", "2+2", "3+1", "3+2", "4+1", "4+2", "5+1",
            "1+0 Dubleks", "1+1 Dubleks", "2+1 Dubleks", "3+1 Dubleks", "4+1 Dubleks",
            "2+0", "3+0", "4+0", "1+1 Penthouse", "2+2 Penthouse", "3+2 Penthouse",
            "3+1 Villa", "4+1 Villa", "5+2", "5+3", "6+1", "6+2", "7+1", "8+2", "9+1",
            "9+2", "10+1"
         };
        public static string[] floorNumbers { get; set; } = new string[]
        {
            "Ground Floor", "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th",
            "10th", "11th", "12th", "13th", "14th", "15th", "16th", "17th", "18th", "19th",
            "20th", "Penthouse", "Attic", "Basement", "Mezzanine", "Upper Floor"
        };
    }
}
