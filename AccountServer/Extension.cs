using AccountServer.DB;
using System;

namespace AccountServer
{
    public static class Extensions
    {
        public static bool SaveChangesEx(this AccountDbContext db)
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
