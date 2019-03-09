using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castlewindsor
{
    public class User
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// user asset 
        /// </summary>
        public List<UserAsset> UserAssetData { get; set; }
    }
}
