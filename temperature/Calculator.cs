using System;

namespace temperature {
    public class TempCalculator {

        #region สูตรการแปลงอุณหภูมิ
        // °F = (1.8 × °C) + 32
        // °F = °K × 1.8 − 459.67
        // °C = °K - 273.15
        // °C = (°F - 32) x 5/9
        // °K = °C + 273.15          
        // °K = (°F + 459.67) / (1.8)           
        #endregion

        /// <summary>
        /// เปลี่ยนค่า องศา Fahrenheit ให้เป็น Celsius
        /// 
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public double ConvertFahrenheitToCelsius (double fahrenheit) {
            double C = (fahrenheit - 32) * 5/9;
            return C;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา Kelvin ให้เป็น Celsius
        ///  
        /// </summary>
        /// <param name="kelvin"></param>
        /// <returns></returns>
        public double ConvertKelvinToCelsius (double kelvin) {
            double C = kelvin - 273.15;
            return C;
        }

        /// <summary>
        /// เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit
        /// 
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double ConvertCelsiusToFahrenheit (double celsius) {
            double F = (1.8 * celsius) + 32;
            return F;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา Kelvin ให้เป็น Fahrenheit
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <returns></returns>
        public double ConvertKelvinToFahrenheit (double kelvin) {
            double F = kelvin * 1.8 - 459.67;
            return F;
        }
        /// <summary>
        /// เปลี่ยนค่า องศา Fahrenheit ให้เป็น Kelvin
        /// °K = (°F + 459.67) / (1.8)      
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public double ConvertFahrenheitToKelvin (double fahrenheit) {
            double K = (fahrenheit + 459.67) / (1.8);
            return K;  
        }
        /// <summary>
        /// เปลี่ยนค่า องศา celsius ให้เป็น Kelvin
        /// °K = °C + 273.15    
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double ConvertCelsiusToKelvin (double celsius) {
            double K = celsius + 273.15;
            return K; 
        }

    }
}