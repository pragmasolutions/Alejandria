using System;
using System.Data.Entity;
using Alejandria.Entities;

namespace Alejandria.Data.Repository
{
    /// <summary>
    /// The EF-dependent, base repository for data access
    /// </summary>
    public class EFBaseRepository
    {
        public EFBaseRepository()
        {
            CreateDbContext();
        }

        public EFBaseRepository(DbContext dbContext)
        {
            if (dbContext == null) 
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            AlejandriaDbContext = dbContext as AlejandriaDbContext;
            if (AlejandriaDbContext != null)
                AlejandriaDbContext.Database.CommandTimeout = 1000;
        }

        protected void CreateDbContext()
        {
            DbContext = new AlejandriaDbContext();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            AlejandriaDbContext = DbContext as AlejandriaDbContext;
            if (AlejandriaDbContext != null)
                AlejandriaDbContext.Database.CommandTimeout = 1000;
        }
        
        protected DbContext DbContext { get; set; }

        public AlejandriaDbContext AlejandriaDbContext { get; set; }
    }
}
