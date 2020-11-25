using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Service
{
    public class Config
    {
        public static string ConnectionString { get; set; }
        public static string ImageFolderPath { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
    }
}
