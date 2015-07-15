using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using WindowsFormsApplication1;
using WindowsFormsApplication1.ServiceReferences;

namespace WindowsFormsApplication1.ServiceReferences
{
    class CallEntityService : DbContext
    {
        public DbSet<ProjectMstEntity> ProjectMstEntities { get; set; }
        public DbSet<UserMstEntity> UserMstEntities { get; set; }
        public DbSet<WordDicEntity> WordDicEntities { get; set; }
        public DbSet<WordShinseiEntity> WordShinseiEntities { get; set; }

    }
}