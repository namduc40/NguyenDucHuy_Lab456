using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace NguyenDucHuy_Lab456.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
            return isValid; //Để "HH:mm" thì chỉ nhập được từ 10-23h không nhập được từ 0-9h
        }
    }
}