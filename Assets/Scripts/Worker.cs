using System;

namespace DefaultNamespace
{
    public class Worker
    {
        #region Properties
        //Свойства
        
        public string name;
        public int age;
        public string location;
        public DateTime startDate;
        public string department;

        #endregion

        #region Methods

        //Методы

        public int GetVacationDays()
        {
            //любые вычисления
            return 6;
        }

        #endregion

    }
}