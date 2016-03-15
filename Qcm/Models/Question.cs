using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qcm.Models
{
   public class Question
    {


        #region Fields

        private int _id;
        private string _libelle;
        private int _points;
        private Qcm _qcm;

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

        public int points
        {
            get { return _points; }
            set { _points = value; }
        }

        public Qcm qcm
        {
            get { return _qcm; }
            set { _qcm = value; }
        }

        #endregion

    }
}
