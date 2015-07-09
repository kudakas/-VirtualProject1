using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using WindowsFormsApplication1;


    class dbconnect : DbContext
    {
        public DbSet<sample> abc { get; set; }

    }
