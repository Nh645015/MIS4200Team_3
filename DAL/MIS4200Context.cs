using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // this is needed to access the DbContext object
using MIS4200Team3.Models; // This is needed to access the models

namespace MIS4200Team3.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, MIS4200Team3.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public System.Data.Entity.DbSet<MIS4200Team3.Models.Profile> Profiles { get; set; }

        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}