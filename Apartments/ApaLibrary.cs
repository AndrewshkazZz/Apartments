using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments
{
    //Статический класс для
    public static class ApaLibrary
    {
        //листы для добавления в них объектов, из которых будет строиться страница отдельной квартиры
        public static List<Image> imglist = new List<Image>();
        public static List<String> desclist = new List<String>();
        public static List<String> nammlist = new List<String>();
        //лист для сохранения информации о текущем пользователе
        public static List<String> userinfo = new List<String>();
        public static double rate; //переменная для функции считывания средней оценки квартиры
        public static int mngcheck; //переменная для проверки условий для функций навигации по интерфейсу
    }
}
