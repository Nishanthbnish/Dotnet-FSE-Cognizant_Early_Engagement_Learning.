using System;

namespace Singleton
{
    class DBConn
    {
        private static DBConn dbConn = new DBConn();

        private DBConn()
        {
        }

        public static DBConn GetInstance()
        {
            return dbConn;
        }
    }
}
