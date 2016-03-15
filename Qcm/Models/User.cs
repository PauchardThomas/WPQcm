using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qcm.Models
{
   public class User
    {
        #region Fields

        private int _id;
        private string _username;
        private string _password;

        #endregion

        #region Properties

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion
    }
}
