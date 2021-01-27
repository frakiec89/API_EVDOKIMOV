using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_EVDOKIMOV.Model
{
    public class InApiRequist
    {
        private UInt64 _phone;
        public ulong phone
        {
            get => _phone;
            set
            {
                if (value.ToString().Length == 11)
                {
                    _phone = value;
                }
                else
                {
                    throw new ArgumentException("НЕ 11 цифр");
                }
            }
        }

        public string password { get; set; }
    }

    public class RegistrRequest_: InApiRequist
    {
        private UInt64 _phone;
        public string first_name { get; set; }
        public string surname{ get; set; }
    }


   
}
