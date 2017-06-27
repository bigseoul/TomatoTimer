using Oledb.sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoTimer
{
    public class CustomerQuery : AQueryBase<CustomerDTO>
    {
        public override void DELETE(CustomerDTO dto)
        {
            throw new NotImplementedException();
        }

        public override void INSERT(CustomerDTO dto)
        {
            throw new NotImplementedException();
        }

        public override void SaveOrUpdate(CustomerDTO dto)
        {
            throw new NotImplementedException();
        }

        public override List<CustomerDTO> SELECT(object conditions)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDTO> SELECTALL()
        {
            var query = new ARetrieveQuery<CustomerDTO>(SharedPreference.Instance.DBM.Conn)
            {
                Query = string.Format(@"SELECT * FROM T_CUSTOMER")
            };
            var e = query.DoQuery();
            if (e != null) return new List<CustomerDTO>();
            return query.ResultSet;
        }

        public override void UPDATE(CustomerDTO dto)
        {
            //UPDATE T_CUSTOMER SET NUM_COUPON = '12' WHERE USER_ID ='ID1'
            var query = new OperateQueryHandler(SharedPreference.Instance.DBM.Conn)
            {
                Query = $@"UPDATE T_CUSTOMER SET NUM_COUPON = '{dto.NUM_COUPON}' WHERE USER_ID ='{dto.USER_ID}'"
            };
            var e = query.DoQuery();
        }
    }
}
