using ClasslistDb;
using System.Collections.Generic;
using System.Linq;

namespace Classlist.Services
{
    public class ClazzesService
    {
        private readonly ClasslistContext db;

        public ClazzesService(ClasslistContext db)
        {
            this.db = db;
        }

        public List<Clazz> GetClazzes()
        {
            return db.Clazzs.ToList();
        }
    }
}
