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
    public partial class FClientMain : Form
    {
        public FClientMain()
        {
            InitializeComponent();
            //Добавление фио и даты рождения вошедшего клиента на форму в профиль
            LClientProfName1.Text = ApaLibrary.userinfo[0] + " " + ApaLibrary.userinfo[1] + " " + ApaLibrary.userinfo[2];
            LClientProfDate1.Text = ApaLibrary.userinfo[3];
            //Обработка события клика на звездочки для оценки с помощью лямбда выражения с дальнейшим подсчетом средней оценки
            int cnt = 0;
            PBStar1.Click += (sender, e) => { ApaLibrary.rate += 1; cnt++; LClientApRate1.Text = Convert.ToString(Math.Round(ApaLibrary.rate / cnt, 2)); };
            PBStar2.Click += (sender, e) => { ApaLibrary.rate += 2; cnt++; LClientApRate1.Text = Convert.ToString(Math.Round(ApaLibrary.rate / cnt, 2)); };
            PBStar3.Click += (sender, e) => { ApaLibrary.rate += 3; cnt++; LClientApRate1.Text = Convert.ToString(Math.Round(ApaLibrary.rate / cnt, 2)); };
            PBStar4.Click += (sender, e) => { ApaLibrary.rate += 4; cnt++; LClientApRate1.Text = Convert.ToString(Math.Round(ApaLibrary.rate / cnt, 2)); };
            PBStar5.Click += (sender, e) => { ApaLibrary.rate += 5; cnt++; LClientApRate1.Text = Convert.ToString(Math.Round(ApaLibrary.rate / cnt, 2)); };
            //Изменение данных на форме в профиле при их изменении
            BClientChngName.Click += (sender, e) => { LClientProfName1.Text = ApaLibrary.userinfo[0] + " " + ApaLibrary.userinfo[1] + " " + ApaLibrary.userinfo[2]; };
            BClientChngDate.Click += (sender, e) => { LClientProfDate1.Text = ApaLibrary.userinfo[3]; };
        }
        //Навигация между функциями интерфеса
        private void BClientMain_Click(object sender, EventArgs e)
        {
            PClientMainApsCtrl.Visible = true;
            if (PClientMainProf.Visible == true)
            {
                PClientMainProf.Visible = false;
            }
            PClientMainAps.Visible = true; BClientPrev.Visible = true; BClientNext.Visible = true;
        }
        private void BClientProf_Click(object sender, EventArgs e)
        {
            PClientMainApsCtrl.Visible = false;
            if (PClientMainAps.Visible == true)
            {
                PClientMainAps.Visible = false;
            }
            PClientMainProf.Visible = true; BClientPrev.Visible = false; BClientNext.Visible = false;
        }
        //Кнопки, в которых будет логика изменения информации на странице текущей квартиры, беря информацию из файла или бд,
        //в которые информация о квартирах будет добавляться усилиями менеджера.
        private void BClientPrev_Click(object sender, EventArgs e)
        {}
        private void BClientNext_Click(object sender, EventArgs e)
        {}
        //Кнопка возврата к форме аутентификации
        private void BClientExt_Click(object sender, EventArgs e)
        {
            FClientAuto fca = new FClientAuto();
            this.Hide();
            fca.Show();
        }
        //Обработка события наведения курсора на звездочки для оценки
        private void PBStar1_MouseMove(object sender, MouseEventArgs e)
        {PBStar1.BackColor = Color.Khaki;}
        private void PBStar2_MouseMove(object sender, MouseEventArgs e)
        {PBStar2.BackColor = Color.Khaki; PBStar1.BackColor = Color.Khaki;}
        private void PBStar3_MouseMove(object sender, MouseEventArgs e)
        {PBStar3.BackColor = Color.Khaki; PBStar2.BackColor = Color.Khaki; PBStar1.BackColor = Color.Khaki;}
        private void PBStar4_MouseMove(object sender, MouseEventArgs e)
        {PBStar4.BackColor = Color.Khaki; PBStar3.BackColor = Color.Khaki; PBStar2.BackColor = Color.Khaki; PBStar1.BackColor = Color.Khaki;}
        private void PBStar5_MouseMove(object sender, MouseEventArgs e)
        {PBStar5.BackColor = Color.Khaki; PBStar4.BackColor = Color.Khaki; PBStar3.BackColor = Color.Khaki;PBStar2.BackColor = Color.Khaki;
         PBStar1.BackColor = Color.Khaki;
        }//Обработка события убирания курсора со звездочек для оценки
        private void PBStar1_MouseLeave(object sender, EventArgs e)
        {PBStar1.BackColor = Color.Transparent;}
        private void PBStar2_MouseLeave(object sender, EventArgs e)
        {PBStar2.BackColor = Color.Transparent; PBStar1.BackColor = Color.Transparent;}
        private void PBStar3_MouseLeave(object sender, EventArgs e)
        {PBStar3.BackColor = Color.Transparent; PBStar2.BackColor = Color.Transparent; PBStar1.BackColor = Color.Transparent;}
        private void PBStar4_MouseLeave(object sender, EventArgs e)
        {PBStar4.BackColor = Color.Transparent; PBStar3.BackColor = Color.Transparent; PBStar2.BackColor = Color.Transparent;
         PBStar1.BackColor = Color.Transparent;}
        private void PBStar5_MouseLeave(object sender, EventArgs e)
        {PBStar5.BackColor = Color.Transparent; PBStar4.BackColor = Color.Transparent; PBStar3.BackColor = Color.Transparent;
         PBStar2.BackColor = Color.Transparent; PBStar1.BackColor = Color.Transparent;}
        //Функция изменения фио пользователя
        void BClientChngName_Click(object sender, EventArgs e)
        {
            if (TBClientChngName.Visible == false)
            { TBClientChngName.Visible = true; }
            else
            {
                //Проверка правильности введенного фио и выведение сообщения при ошибке
                if (TBClientChngName.Text.Split(' ').Length < 3 || TBClientChngName.Text.Split(' ').Length > 3)
                {
                    LCientRegEr.Visible = true;
                    //await Task.Delay(3000);
                    //LCientRegEr.Visible = false;
                }
                else
                {
                    //Путь к файлу со списком клиентов
                    string path = Application.StartupPath + @"\Список клиентов.txt";
                    //Путь к файлу, в котором будут изменены данные кокретного пользователя, и который перезапишет оригинальный список
                    string path1 = Application.StartupPath + @"\Rewrite.txt";
                    //Счетчики для нахождения конкретной строки
                    int i = 1;
                    int i1 = 1;
                    //Функция нахождения строки, в которой находятся данные текущего пользователя
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string str = sr.ReadLine();
                            while (str != null)
                            {
                                string[] split = str.Split(' ');
                                if (split[0] == ApaLibrary.userinfo[0] && split[1] == ApaLibrary.userinfo[1] && split[2] == ApaLibrary.userinfo[2] 
                                    && split[3] == ApaLibrary.userinfo[3] && split[4] == ApaLibrary.userinfo[4] && split[5] == ApaLibrary.userinfo[5] 
                                    && split[6] == ApaLibrary.userinfo[6])
                                {
                                    split[0] = TBClientChngName.Text.Split(' ')[0];
                                    split[1] = TBClientChngName.Text.Split(' ')[1];
                                    split[2] = TBClientChngName.Text.Split(' ')[2];
                                    ApaLibrary.userinfo[0] = split[0]; ApaLibrary.userinfo[1] = split[1]; ApaLibrary.userinfo[2] = split[2];
                                    break;
                                }
                                else
                                {
                                    i1++;
                                    str = sr.ReadLine();
                                }
                            }
                        }
                    }
                    //Функция записи нового списка с измененными данными в буферный файл и перезапись старого списка новым
                    using (FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate))
                    using (StreamReader sr1 = new StreamReader(fs1))
                    using (StreamWriter sw = new StreamWriter(path1))
                    {
                        string line = sr1.ReadLine();
                        while (line != null)
                        {
                            //Если текущая строка та, в которой находятся данные текущего пользователя - перезаписать его данные
                            if (i1 == i)
                            {
                                sw.AutoFlush = true;
                                sw.WriteLine(ApaLibrary.userinfo[0] + " " + ApaLibrary.userinfo[1] + " " + ApaLibrary.userinfo[2] + " " +
                                    ApaLibrary.userinfo[3] + " " + ApaLibrary.userinfo[4] + " " + ApaLibrary.userinfo[5] + " " + ApaLibrary.userinfo[6]);
                            }
                            //Если нет, записать данные как были
                            else
                            {
                                sw.AutoFlush = true;
                                sw.WriteLine(line);
                            }
                            i++;
                            line = sr1.ReadLine();
                        }
                    }
                    //Пеперапись старого списка новым
                    File.Delete(path);
                    File.Move(path1, path);
                    File.Create(path1).Close();
                }
            }
        }
        //Тот же самый алгоритм, только для перезаписи даты рождения
        private void BClientChngDate_Click_1(object sender, EventArgs e)
        {
            if (TBClientChngDate.Visible == false)
            {
                TBClientChngDate.Visible = true;
            }
            else
            {
                string path = Application.StartupPath + @"\Список клиентов.txt";
                string path1 = Application.StartupPath + @"\Rewrite.txt";
                int i = 1;
                int i1 = 1;

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string str = sr.ReadLine();
                        while (str != null)
                        {
                            string[] split = str.Split(' ');
                            if (split[0] == ApaLibrary.userinfo[0] && split[1] == ApaLibrary.userinfo[1] && split[2] == ApaLibrary.userinfo[2]
                                    && split[3] == ApaLibrary.userinfo[3] && split[4] == ApaLibrary.userinfo[4] && split[5] == ApaLibrary.userinfo[5]
                                    && split[6] == ApaLibrary.userinfo[6])
                            {
                                split[3] = TBClientChngDate.Value.ToShortDateString();
                                ApaLibrary.userinfo[3] = split[3];
                                break;
                            }
                            else
                            {
                                i1++;
                                str = sr.ReadLine();
                            }
                        }
                    }
                }
                using (FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate))
                using (StreamReader sr1 = new StreamReader(fs1))
                using (StreamWriter sw = new StreamWriter(path1))
                {
                    string line = sr1.ReadLine();
                    while (line != null)
                    {
                        if (i1 == i)
                        {
                            sw.AutoFlush = true;
                            sw.WriteLine(ApaLibrary.userinfo[0] + " " + ApaLibrary.userinfo[1] + " " + ApaLibrary.userinfo[2] + " " +
                                    ApaLibrary.userinfo[3] + " " + ApaLibrary.userinfo[4] + " " + ApaLibrary.userinfo[5] + " " + ApaLibrary.userinfo[6]);
                        }
                        else
                        {
                            sw.AutoFlush = true;
                            sw.WriteLine(line);
                        }
                        i++;
                        line = sr1.ReadLine();
                    }
                }
                File.Delete(path);
                File.Move(path1, path);
                File.Create(path1).Close();
            }
        }
        private void BClientRention_Click(object sender, EventArgs e)
        {
            PClientRent.Visible = true;
        }
        private void FClientMain_Load(object sender, EventArgs e)
        {
            PClientRent.Visible = false;
        }
        //В кнопке "согласиться" будет прописана логика создания отдельного экземпляра договора и сохранение его в профиль пользователя.
        void BClientRentAgree_Click(object sender, EventArgs e)
        {
            //Вызов метода для создания договора аренды
            //RentFiller.Fill(/*Данные, передаваемые методу. Пример: ApaLibrary.userinfo[0], ApaLibrary.userinfo[1], и т.д.;*/);
        }
        //Кнопка отклонения соглашения.
        private void BClientRentDisagree_Click(object sender, EventArgs e)
        {
            PClientRent.Visible = false;
        }
    }
}