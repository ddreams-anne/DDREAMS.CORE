using System;
using UnityEngine;

namespace DDREAMS.CORE
{
    public class Convert : MonoBehaviour
    {
        /// <summary>
        /// Returns the time as an HH:MM:ss string.
        /// </summary>
        /// <param name="seconds">The number of seconds as a float.</param>
        /// <returns>A string, in the HH:MM:ss format.</returns>
        public static string FloatToFullTimeString(float seconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);

            return string.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }

        /// <summary>
        /// Returns the time as an HH:MM:ss string, but will shorten it depending on the number of seconds
        /// </summary>
        /// <param name="seconds">The number of seconds as a float.</param>
        /// <returns>A string, in the ss, M:SS, MM:ss or HH:MM:ss format, depending on the number of seconds.</returns>
        public static string FloatToTimeString(float seconds)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);

            return seconds switch
            {
                < 60.0f and > 0.0f => string.Format("{00}", timeSpan.Seconds),
                >= 60.0f and < 600.0f => string.Format("{0:0}:{1:00}", timeSpan.Minutes, timeSpan.Seconds),
                >= 600.0f and < 3600.0f => string.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds),
                _ => string.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds),
            };
        }
    }
}
