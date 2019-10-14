using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak_1
{
    public class BaseRepository
    {
        public IEnumerable<T> Query<T>(string query, object parameters = null) where T: class
        {
            return Enumerable.Empty<T>();
        }
    }
}
