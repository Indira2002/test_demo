using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToursApp
{
    public partial class DailyReceptions
    {
        public static string Check(DailyReception _currentDailyReception)
        {
            
            if (string.IsNullOrWhiteSpace(_currentDailyReception.CouponNum))
            {
                return "Укажите номер талона.";
            }
            if (string.IsNullOrWhiteSpace(_currentDailyReception.Data))
            {
                return "Укажите дату.";
            }
            if (string.IsNullOrWhiteSpace(_currentDailyReception.Cost))
            {
                return "Укажите сумму.";           
            }
            if (_currentDailyReception.Diagno == null)
            {
                return "Укажите диагноз.";     
            }
            if (_currentDailyReception.Doctor1 == null)
            {
               return "Выберите доктора.";   
            }
            if (_currentDailyReception.Patient1 == null)
            {
                return "Выберите пациента.";
            }
            return "";          
        }
    }
}
