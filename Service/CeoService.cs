using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    public class CeoService
    {
        private readonly BaseRepository _repository;

        public CeoService(BaseRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CustomModel> QueryCustomStuff(string customName)
        {
            const string query =@"SELECT A lot of custom stuff
                                  FROM [Table1] 
                                       JOIN [Table2] 
                                       JOIN [Table3]
                                  WHERE CustomName = @CustomName";

            return _repository.Query<CustomModel>(query, new
            {
                CustomName = customName
            });
        }
    }
}
