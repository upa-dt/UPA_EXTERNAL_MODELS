using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.Configs
{
    public class LocalConfig
    {
        public string API_ROOT_URL { get; set; }
        public string API_KEY { get; set; }
        public string API_USER { get; set; }
        public string API_PASSWORD { get; set; }
        public string API_OTP_SECRET { get; set; }
        public string API_SECRET { get; set; }
        public string ORACLE_DB_CONNECTION { get; set; }

    }
}
