using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DBInstance
    {
        protected static DBInstance _obj;
        private DBInstance()
        {

        }
        public static DBInstance GetDBInstance()
        {
            if (_obj == null)
            {
                _obj = new DBInstance();
            }
            return _obj;
        }
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
