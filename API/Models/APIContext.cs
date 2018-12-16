﻿using System.Data.Entity;

namespace API.Models
{
    public class APIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public APIContext() : base("name=APIContext")
        {
        }

        public System.Data.Entity.DbSet<API.Entities.Game> Games { get; set; }
    }
}
