using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoTimer
{
    class SharedPreference : BindableBase
    {
        #region singleton

        private SharedPreference()
        {
        }

        private static SharedPreference m_Instance = null;
        public static SharedPreference Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new SharedPreference();
                    m_Instance.DBM = new DBManager();
                    m_Instance.DBM.Init();

                }
                return m_Instance;
            }
            set
            {
                m_Instance = value;
            }
        }

        #endregion

        #region property
        /// <summary>
        /// 로컬 데이터베이스 객체
        /// </summary>
        public DBManager DBM { get; set; }
       

        #endregion property

        #region method 


        #endregion

    }
}
