using Apartments.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Объяснение сокращений на примере LClientProfName1: 1) L (lable - сокращение сути элемента формы), 
    2) Client (интерфейс, в котором элемент распогается), 3) дальше краткое описание назначения элемента, 
    4) цыфры в конце у смежных элементов схожего назначения
    F - Form, B - Button, P - Panel, PB - PictureBox, TB - TextBox (для DatePicker'a я для простоты тоже использовал TB) и т.д.
*/
namespace Apartments
{
    public partial class FClientAuto : Form
    {
        public FClientAuto()
        {
            InitializeComponent();
        }
        //Кнопка для создания нового аккаунта
        private void BClientNewAcc_Click(object sender, EventArgs e)
        {
            PClientAuto.Visible = false;
            PClientReg.Visible = true;
        }
        //Кнопка отмены создания нового аккаунта
        private void BClientOldAcc_Click(object sender, EventArgs e)
        {
            PClientAuto.Visible = true;
            PClientReg.Visible = false;
            LCientRegSuc.Visible = false;
            LCientRegEr.Visible = false;
        }
        //Кнопка попытки создания нового аккаунта
        public void BClientRegNewAcc_Click(object sender, EventArgs e)
        {
            //Переменные для вывода ошибок
            string mess = "Такой пользователь уже существует";
            string mess2 = "В полях не должно быть пробелов";
            //Переменная для пути файлов, Application.StartupPath возвращает путь к папке debug, из которой происходит запуск программы
            string path = Application.StartupPath + @"\Список клиентов.txt";
            //Отдельная переменная для конвертации значения элемента DataTimePicker в строковое представление укороченой записи данных
            string date = TBClientRegDate.Value.ToShortDateString();
            string userinfo = TBClientRegName.Text + " " + TBCientRegSName.Text + " " + TBCientRegMName.Text + " " +
                              date + " " + TBClientRegNumb.Text + " " +
                              TBClientRegLog.Text + " " + TBClientRegPass.Text;
            //Проверка для избежания дальнейшего нарушения индексов элементов
            if (TBClientRegName.Text.Contains(" ") || TBCientRegSName.Text.Contains(" ") || TBCientRegMName.Text.Contains(" ") || TBClientRegNumb.Text.Contains(" ") || TBClientRegPass.Text.Contains(" ") || TBClientRegLog.Text.Contains(" "))
            {
                TBClientRegName.Text = null;
                TBCientRegSName.Text = null;
                TBCientRegMName.Text = null;
                TBClientRegNumb.Text = null;
                LCientRegEr.Text = mess2;
                LCientRegEr.Visible = true;
            }
            else
            {
                try
                {
                    using (FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (StreamReader sr = new StreamReader(fs1))
                        {
                            //Переменная для предовращения повторного создания пользователя
                            bool res = false;
                            //Начало построчного считывания строк из файла, находящегося по пути переменной path
                            string str = sr.ReadLine();
                            while (str != null)
                            {
                                //Проверка, есть ли уже такой пользователь
                                if (str == userinfo)
                                {
                                    res = true;
                                    break;
                                }
                                else
                                {
                                    str = sr.ReadLine();
                                }
                            }
                            //Если пользователь существует - вывести сообщение, если нет то...
                            if (res == true)
                            {
                                LCientRegEr.Text = mess;
                                LCientRegEr.Visible = true;
                            }
                            else
                            {
                                using (StreamWriter sw = new StreamWriter(fs1))
                                {
                                    //...записать его в новую строку и вывести сообщение об успешном добавлении
                                    sw.AutoFlush = true;
                                    sw.WriteLine(userinfo);
                                    LCientRegSuc.Visible = true;
                                }
                            }
                        }
                    }
                }
                //Обработка непредвиденных ошибок
                catch(Exception)
                {
                    LCientRegEr.Text = "Ошибка";
                    LCientRegEr.Visible = true;
                }
            }
        }
        //Проверка при аутентификации пользователя
        void BClientLogIn_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Список клиентов.txt";
            string mess = "Данные неверны";
            using (FileStream fs1 = new FileStream(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs1);
                string str = sr.ReadLine();
                while (str != null)
                {
                    //Полученная строка из файла с добавленными пользователями развивается пробелами на массив
                    string[] split = str.Split(' ');
                    //Проверяетются элементы, в индексы которых при регистрации пользвателся добавились логин и пароль
                    //Если пользователь ввел все верно, происходит вход интерфейс клиента и... 
                    if (split[5] == TBClientAutoLog.Text && split[6] == TBClientAutoPass.Text)
                    {
                        //...его данные добавляются в статический класс ApaLibrary для дальнейшего использования
                        foreach (string s in split)
                        {
                            ApaLibrary.userinfo.Add(s);
                        }
                        FClientMain fcm = new FClientMain();
                        this.Hide();
                        sr.Close();
                        fcm.Show();
                        break;
                    }
                    //Если данные неверны, выводится сообщение
                    else
                    {
                        check.Text = mess;
                        str = sr.ReadLine();
                    }
                }
            }
        }
        //Обработка события изменения сообщения об ошибках для функции скрытия его со временем
        async private void LCientRegEr_VisibleChanged(object sender, EventArgs e)
        {
            if (LCientRegEr.Visible == true)
            {
                await Task.Delay(3000);
                LCientRegEr.Visible = false;
            }
        }
    }
}
