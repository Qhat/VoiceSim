using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DALContext>
    {
        protected override void Seed(DALContext context)
        { }
    }
}