using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
    public partial class FManager : Form
    {
        //Переменная хранящая путь к файлу, содержащему список клиентов
        public string path = Application.StartupPath + @"\Список клиентов.txt";
        public FManager()
        {
            InitializeComponent();
        }
        //Открытие формы выбора типа входа в систему при закрытии интерфейса менеджера
        private void FManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            F1 f1 = new F1();
            f1.Show();
        }
        //Навигация по интерфейсу менеджера
        private void BManagerUpAdd_Click(object sender, EventArgs e)
        {
            BManagerEdit.Visible = false; BManagerAdd.Visible = true; PManagerClients.Visible = false;  PManagerMain.Visible = true; 
            PClientMainApsCtrl.Visible = false; BManagerUpdtTable.Visible = false;
            ApaLibrary.mngcheck = 1;
        }
        private void BManagerUpEdit_Click(object sender, EventArgs e)
        {
            BManagerEdit.Visible = true; BManagerAdd.Visible = false; PManagerClients.Visible = false; PManagerMain.Visible = true; 
            PClientMainApsCtrl.Visible = true; BManagerUpdtTable.Visible = false;
            ApaLibrary.mngcheck = 2;
        }
        private void BManagerClients_Click_1(object sender, EventArgs e)
        {
            PManagerMain.Visible = false; PManagerClients.Visible = true; PClientMainApsCtrl.Visible = false; BManagerUpdtTable.Visible = true;
            ApaLibrary.mngcheck = 3;
        }
        private void BManagerEdit_Click(object sender, EventArgs e)
        {
        }
        private void BManagerAdd_Click(object sender, EventArgs e)
        {
        }
        private void BManagerChngPic_Click(object sender, EventArgs e)
        {
        }
        private void BManagerChngDesc_Click(object sender, EventArgs e)
        {
        }
        private void BManagerChngName_Click(object sender, EventArgs e)
        {
        }

        void FManager_Load(object sender, EventArgs e)
        {
            BManagerUpdtTable.Visible = false;
        }

        private void DGClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //Кнопка обновления данных в таблице списка пользователей
        private void BManagerUpdtTable_Click(object sender, EventArgs e)
        {
            DTClients.Rows.Clear();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            using (StreamReader sr = new StreamReader(fs))
            {
                string str = sr.ReadLine();
                while (str != null)
                {
                    string[] split = str.Split(' ');
                    DTClients.Rows.Add(split);
                    str = sr.ReadLine();
                }
            }
        }

        private void LClientApInfo1_Click(object sender, EventArgs e)
        {

        }
        //Кнопка которая ищет строку в файле с пользователями такую же, как и выбранная строка таблицы на форме,
        //затем удаляет ее и обновляет таблицу с пользователями.
        private void BManagerDelUser_Click(object sender, EventArgs e)
        {
        }
    }
}