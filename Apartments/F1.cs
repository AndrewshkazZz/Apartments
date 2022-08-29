using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class F1 : Form
    {
        //Создается переменная ch для проверки выбора пользователся
        public static int ch;
        public F1()
        {
            InitializeComponent();
            //Функция для создания плавного появления формы
            Opacity = 0;
            //Таймер для определения времени появления
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
        }
        //В зависимости от предыдущего выбора открывается тот или иной интерфейс
        private void F1BC_Click(object sender, EventArgs e)
        {
            ch = 1;
            PanelF1.Visible = true;
        }
        private void F1BM_Click(object sender, EventArgs e)
        {
            ch = 2;
            PanelF1.Visible = true;
        }
        private void YesBF1_Click(object sender, EventArgs e)
        {
            if (ch == 1)
            {
                
                FClientAuto fc = new FClientAuto();
                fc.Show();
                this.Hide();
            }
            else if (ch == 2)
            {
                
                FManager fm = new FManager();
                fm.Show();
                this.Hide();
            }
        }
        //Кнопка для смены выбора
        private void NoBF1_Click(object sender, EventArgs e)
        {
            PanelF1.Visible = false;
        }
    }
}
