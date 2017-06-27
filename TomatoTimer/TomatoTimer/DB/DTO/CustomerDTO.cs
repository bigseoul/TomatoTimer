using Oledb.sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoTimer
{
    [Serializable]
    public class CustomerDTO : AResultSet
    {
        public CustomerDTO()
        {
            USER_ID = string.Empty; //uniqueKey
            NAME = string.Empty;
            NUM_COUPON = 0;

        }

        public string USER_ID { get; set; }
        public string NAME { get; set; }

        public long NUM_COUPON { get; set; }
    }
}
