using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_NN_Lib
{
    public class Calculations
    {
        /// <summary>
        /// Библиотека классов для возрата списка свободных временных интервалов
        /// </summary>
        /// <summary>
        /// Метод для возрата списка свободных временных интервалов
        /// </summary>
        /// <param name="startTimes"></param>
        /// <param name="durations"></param>
        /// <param name="beginWorkingTime"></param>
        /// <param name="endWorkingTime"></param>
        /// <param name="consultationTime"></param>
        /// <returns></returns>
        public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            string[] arr = {"f"};
            return arr;
        }

      
    }
}
