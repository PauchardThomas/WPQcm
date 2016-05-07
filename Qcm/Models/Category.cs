using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qcm.Models
{
    public class Category
    {

        #region Fields

        private int _id;
        private string _libelle;
        #endregion

        #region Properties

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        #endregion

        #region Constructors

        public Category(int id = 0 , string libelle = null)
        {
            _id = id;
            _libelle = libelle;
        }

        #endregion

        public override string ToString()
        {
            return libelle;
        }




    }
}
