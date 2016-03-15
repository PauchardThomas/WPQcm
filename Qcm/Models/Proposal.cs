using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qcm.Models
{
   public class Proposal
    {
        #region Fields

        private int _id;
        private string _libelle;
        private bool _isAnswer;
        private Question _question;

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

        public bool isAnswer
        {
            get { return _isAnswer; }
            set { _isAnswer = value; }
        }

        public Question question
        {
            get { return _question; }
            set { _question = value; }
        }

        #endregion
    }
}
