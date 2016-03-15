using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qcm.Models
{
    public class Qcm
    {

        #region Fields

        private int _id;
        private string _libelle;
        private DateTime _datePubli;
        private DateTime _dateFin;
        private int _nbPoints;
        private Category _category;
        private TimeSpan _duree;

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

        public DateTime datePubli
        {
            get { return _datePubli; }
            set { _datePubli = value; }
        }

        public DateTime dateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        public int nbPoints
        {
            get { return _nbPoints; }
            set { _nbPoints = value; }
        }

        public Category category
        {
            get { return _category; }
            set { _category = value; }
        }

        public TimeSpan duree
        {
            get { return _duree; }
            set { _duree = value; }
        }

        #endregion

    }
}
