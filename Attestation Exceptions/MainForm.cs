using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



/*   ДОРАБОАТЬ КОД, НА УЛУЧШЕННУЮ ПРОВЕРКУ ВАЛИДНОСТИ ДАННЫХ
        ПОКА ЧТО ОНА РАБОТАЕТ, НО НЕ ТАК, КАК БЫ МНЕ ХОТЕЛОСЬ */

namespace Attestation_Exceptions
{
    public partial class MainForm : Form
    {
        private string FirstName;
        private string MiddleName;
        private string LastName;
        private string DayHB;
        private string NumberPhone;
        private string Sex;
        private string FilePath;
        private string UserNameComputer;


        public MainForm()
        {
            InitializeComponent();

        }


        // МЕТОД ПО ПОЛУЧЕНИЮ ЗНАЧЕНИЙ, КОТОРЫЕ ВВЕЛ ПОЛЬЗОВАТЕЛЬ В ЯЧЕЙКИ
        private void GetValueFromCells()
        { 
            LastName = CheckCells(tb_LastName.Text, "Фамилия");
            FirstName = CheckCells(tb_FirstName.Text, "Имя");
            MiddleName = CheckCells(tb_MiddleName.Text, "Отчество");
        }


        // МЕТОД ПО ОБРАБОТКЕ ЗНАЧЕНИЙ В ЯЧЕЙКЕ
        // МНЕ НЕ НРАВИТСЯ, КАК ПРОХОДИТ ПРОВЕРКА НА ПУСТЫЕ ЯЧЕЙКИ, НУЖНО ОПТИМИЗИРОВАТЬ АЛГОРИТМ ПРОВЕРКИ ЯЧЕЕК НА ПУСТОЕ ПОЛЕ.
        private string CheckCells(string cell, string NameCell)
        {
            int CellNum;
            string ValCell = "";

            if (cell.Equals("") && NameCell.Equals("Фамилия"))
            {
                MessageBox.Show("Вы ничего не ввели в поле Фамилия, попробуйте еще раз",
                                "Сообщение по ФИО",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
            }
            else if (cell.Equals("") && NameCell.Equals("Имя"))
            {
                MessageBox.Show("Вы ничего не ввели в поле Имя, попробуйте еще раз",
                                "Сообщение по ФИО",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
            }
            else if (cell.Equals("") && NameCell.Equals("Отчество"))
            {
                ValCell = ""; // Отчество я оставил, потому что не у всех оно бывает
            }
            else
            {
                try
                {
                    CellNum = int.Parse(cell);
                    MessageBox.Show("Цифры нельзя вводить, попробуйте еще раз",
                                    "Сообщение по ФИО",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button1);

                }
                catch (FormatException)
                {
                    ValCell = cell;
                }

            }

            return ValCell;
        }


        // МЕТОД ПО ОБРАБОТКЕ СОБЫТИЯ ИЗМЕНЕНИЯ ДАТЫ В КАЛЕНДАРЕ
        private void DateHappyBirthday_ValueChanged(object sender, EventArgs e)
        {
            DayHB = date_HappyBirthday.Value.Date.ToString("dd.MM.yyyy");
        }




        // МЕТОД ПО ПРОВЕРКИ ПРАВИЛЬНОСТИ ВВЕДЕННОГО НОМЕРА ПО МАСКЕ

        private void CheckPhoneNumber()
        {
            if (tb_PhoneNumber.MaskFull) NumberPhone = "+7" + tb_PhoneNumber.Text;
            else
            {
                MessageBox.Show("Похоже вы не полностью ввели номер телефона, попробуйте еще раз",
                                 "Сообщение по номеру телефона",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
            }

        }


        // МЕТОД ПО ОБРАБОТКЕ СОБЫТИЯ ИЗМЕНЕНИЯ ВЫБОРА ПОЛА

        private void cmb_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sex = cmb_Sex.Text;
        }



        // МЕТОД ПО ОБРАБОТКЕ СОБЫТИЯ НАЖАТИЯ НА КНОПКУ
        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            tb_OutputUser.Text = "";

            GetValueFromCells();
            tb_OutputUser.Text = LastName;
            tb_OutputUser.Text += " " + FirstName;
            tb_OutputUser.Text += " " + MiddleName + ";";
            tb_OutputUser.Text += " " + DayHB + ";";

            CheckPhoneNumber();
            tb_OutputUser.Text += " " + NumberPhone + ";";
            tb_OutputUser.Text += " " + Sex + ";";

            UserNameComputer = tb_UserNameComputer.Text;
            tb_OutputUser.Text += "\n" + UserNameComputer;


            SaveFileTXT();

        }


        // В ДАННОМ МЕТОДЕ Я ЗАДАЮ ОСНОВНЫЕ СВОЙСТВА НЕКОТРЫХ КОМПОНЕНТОВ ИНТЕРФЕЙСА
        private void MainForm_Load(object sender, EventArgs e)
        {
            date_HappyBirthday.Value = DateTime.Now;

            DayHB = date_HappyBirthday.Value.ToString("dd.MM.yyyy");

            Sex = cmb_Sex.Text;

            cmb_Sex.SelectedIndex = 0;

        }


        // МЕТОД ПО ПРОВЕРКА НА НАЛИЧИЯ ФАЙЛА С ТАКОЙ ФАМИЛИЕЙ И В ЗАВИСИМОСТИ ОТ ТОГО
        // ЕСТЬ ЛИ ТАКОЙ ФАЙЛ ИЛИ НЕТ, ВЫЗЫВАЕТСЯ СВОЙ МЕТОД, ТАКЖЕ ЕЩЕ ПРОВЕРКА НА ПУСТУЮ ЯЧЕЙКУ В ВИДЕ ФАМИЛИИ
        private void SaveFileTXT()

        {
            if (LastName.Equals(""))
            {
                MessageBox.Show("Нечего сохранять, основные поля пустые",
                                "Error Save",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                string LastNamePath = LastName + ".txt";
                FilePath = @"C:\Users\" + UserNameComputer + "\\" + LastNamePath; 

                if (File.Exists(FilePath)) OverWritingFile();
                else CreateAndWritingNewFile();
            }
        }


        // МЕТОД ПО ПЕРЕЗАПИСИ ФАЙЛА (ТОЧНЕЕ ДОБАВЛЕНИЕ НОВОГО ПОЛЬЗОВАТЕЛЯ В УЖЕ ИМЕЮЩИЙСЯ ФАЙЛ)
        private void OverWritingFile()
        {
            // using Работает также, как try(source) в Java
            // после работы с файлом мне не нужно закрывать его в обязательном порядке
            using(StreamWriter sw  = new StreamWriter(FilePath, true)) 
            { 
                sw.WriteLine(tb_OutputUser.Text);
                MessageBox.Show("Файл перезаписан",
                                "Save File",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
            }

            // ВЫЗЫВАЮ ФАЙЛ НА ЧТЕНИЕ, ЧТОБЫ ПОТОМ ВЫВЕСТИ ВСЕХ ЛЮДЕЙ С ТАКОЙ ФАМИЛИЕЙ В ТЕКСТОВОЕ ПОЛЕ
            using(StreamReader sr = new StreamReader(FilePath)) 
            {
                tb_OutputUser.Text = "";
                string line;
                while ((line = sr.ReadLine()) != null) 
                { 
                    line = line.Trim();
                    tb_OutputUser.Text += line + "\n";
                }
            }
        }


        // МЕТОД ПО СОЗДАНИЮ НОВОГО ФАЙЛА И ЗАПИСЬ В НЕГО ПОЛЬЗОВАТЕЛЯ
        private void CreateAndWritingNewFile()
        {
            using(SaveFileDialog sfd = new SaveFileDialog()) 
            {
                sfd.InitialDirectory = @"C:\Users\" + UserNameComputer;
                sfd.RestoreDirectory = true;
                sfd.FileName = LastName + ".txt";
                sfd.DefaultExt = "txt";
                sfd.Filter = "Text files (*.txt*)|*.txt*|All files(*.*)|*.*";
                sfd.Title = "Save File";

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    string FullPath = Path.GetFullPath(sfd.FileName);

                    using(StreamWriter sw = new StreamWriter(FullPath))
                    {
                        sw .WriteLine(tb_OutputUser.Text);

                        MessageBox.Show("Файл создан и сохранен",
                                        "Save file",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
    }
}
