namespace Attestation_Exceptions
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_OutputUser = new System.Windows.Forms.TextBox();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_MiddleName = new System.Windows.Forms.TextBox();
            this.date_HappyBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmb_Sex = new System.Windows.Forms.ComboBox();
            this.tb_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lb_SecondName = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_DateHB = new System.Windows.Forms.Label();
            this.lb_NumberPhone = new System.Windows.Forms.Label();
            this.lb_Sex = new System.Windows.Forms.Label();
            this.lb_UserNameComputer = new System.Windows.Forms.Label();
            this.tb_UserNameComputer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_OutputUser
            // 
            this.tb_OutputUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_OutputUser.Location = new System.Drawing.Point(12, 196);
            this.tb_OutputUser.Multiline = true;
            this.tb_OutputUser.Name = "tb_OutputUser";
            this.tb_OutputUser.ReadOnly = true;
            this.tb_OutputUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_OutputUser.Size = new System.Drawing.Size(630, 141);
            this.tb_OutputUser.TabIndex = 13;
            this.MyToolTip.SetToolTip(this.tb_OutputUser, "В данном поле будет выводиться вся собранная информация\r\n");
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveFile.Image")));
            this.btn_SaveFile.Location = new System.Drawing.Point(605, 12);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(65, 65);
            this.btn_SaveFile.TabIndex = 12;
            this.MyToolTip.SetToolTip(this.btn_SaveFile, "Кнопка по соххранению данных в файл");
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // MyToolTip
            // 
            this.MyToolTip.ToolTipTitle = "Подсказка по полю";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_LastName.Location = new System.Drawing.Point(91, 12);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(129, 26);
            this.tb_LastName.TabIndex = 1;
            this.MyToolTip.SetToolTip(this.tb_LastName, "Поле для ввода Фамилии\r\n");
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FirstName.Location = new System.Drawing.Point(91, 55);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(129, 26);
            this.tb_FirstName.TabIndex = 3;
            this.MyToolTip.SetToolTip(this.tb_FirstName, "Поле для ввода имени");
            // 
            // tb_MiddleName
            // 
            this.tb_MiddleName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_MiddleName.Location = new System.Drawing.Point(91, 106);
            this.tb_MiddleName.Name = "tb_MiddleName";
            this.tb_MiddleName.Size = new System.Drawing.Size(129, 26);
            this.tb_MiddleName.TabIndex = 5;
            this.MyToolTip.SetToolTip(this.tb_MiddleName, "Поле для ввода отчества");
            // 
            // date_HappyBirthday
            // 
            this.date_HappyBirthday.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_HappyBirthday.Location = new System.Drawing.Point(375, 11);
            this.date_HappyBirthday.Name = "date_HappyBirthday";
            this.date_HappyBirthday.Size = new System.Drawing.Size(157, 25);
            this.date_HappyBirthday.TabIndex = 7;
            this.MyToolTip.SetToolTip(this.date_HappyBirthday, "Выбор даты рождения");
            this.date_HappyBirthday.ValueChanged += new System.EventHandler(this.DateHappyBirthday_ValueChanged);
            // 
            // cmb_Sex
            // 
            this.cmb_Sex.FormattingEnabled = true;
            this.cmb_Sex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cmb_Sex.Location = new System.Drawing.Point(375, 106);
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(133, 21);
            this.cmb_Sex.TabIndex = 11;
            this.MyToolTip.SetToolTip(this.cmb_Sex, "Поле для выбора пола пользователя");
            this.cmb_Sex.SelectedIndexChanged += new System.EventHandler(this.cmb_Sex_SelectedIndexChanged);
            // 
            // tb_PhoneNumber
            // 
            this.tb_PhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PhoneNumber.Location = new System.Drawing.Point(375, 58);
            this.tb_PhoneNumber.Mask = "(999) 000-0000";
            this.tb_PhoneNumber.Name = "tb_PhoneNumber";
            this.tb_PhoneNumber.Size = new System.Drawing.Size(133, 26);
            this.tb_PhoneNumber.TabIndex = 9;
            this.MyToolTip.SetToolTip(this.tb_PhoneNumber, "Поле для ввода номера телефона");
            // 
            // lb_SecondName
            // 
            this.lb_SecondName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SecondName.Location = new System.Drawing.Point(12, 12);
            this.lb_SecondName.Name = "lb_SecondName";
            this.lb_SecondName.Size = new System.Drawing.Size(73, 24);
            this.lb_SecondName.TabIndex = 0;
            this.lb_SecondName.Text = "Фамилия";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_FirstName.Location = new System.Drawing.Point(12, 58);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(40, 23);
            this.lb_FirstName.TabIndex = 2;
            this.lb_FirstName.Text = "Имя";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_LastName.Location = new System.Drawing.Point(12, 109);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(73, 19);
            this.lb_LastName.TabIndex = 4;
            this.lb_LastName.Text = "Отчество";
            // 
            // lb_DateHB
            // 
            this.lb_DateHB.AutoSize = true;
            this.lb_DateHB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_DateHB.Location = new System.Drawing.Point(256, 15);
            this.lb_DateHB.Name = "lb_DateHB";
            this.lb_DateHB.Size = new System.Drawing.Size(113, 19);
            this.lb_DateHB.TabIndex = 6;
            this.lb_DateHB.Text = "Дата Рождения";
            // 
            // lb_NumberPhone
            // 
            this.lb_NumberPhone.AutoSize = true;
            this.lb_NumberPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_NumberPhone.Location = new System.Drawing.Point(250, 58);
            this.lb_NumberPhone.Name = "lb_NumberPhone";
            this.lb_NumberPhone.Size = new System.Drawing.Size(119, 19);
            this.lb_NumberPhone.TabIndex = 8;
            this.lb_NumberPhone.Text = "Номер телефона";
            // 
            // lb_Sex
            // 
            this.lb_Sex.AutoSize = true;
            this.lb_Sex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Sex.Location = new System.Drawing.Point(333, 105);
            this.lb_Sex.Name = "lb_Sex";
            this.lb_Sex.Size = new System.Drawing.Size(36, 19);
            this.lb_Sex.TabIndex = 10;
            this.lb_Sex.Text = "Пол";
            // 
            // lb_UserNameComputer
            // 
            this.lb_UserNameComputer.AutoSize = true;
            this.lb_UserNameComputer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_UserNameComputer.Location = new System.Drawing.Point(12, 151);
            this.lb_UserNameComputer.Name = "lb_UserNameComputer";
            this.lb_UserNameComputer.Size = new System.Drawing.Size(216, 19);
            this.lb_UserNameComputer.TabIndex = 14;
            this.lb_UserNameComputer.Text = "Имя пользователя компьютера";
            // 
            // tb_UserNameComputer
            // 
            this.tb_UserNameComputer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_UserNameComputer.Location = new System.Drawing.Point(234, 150);
            this.tb_UserNameComputer.Name = "tb_UserNameComputer";
            this.tb_UserNameComputer.Size = new System.Drawing.Size(204, 26);
            this.tb_UserNameComputer.TabIndex = 15;
            this.MyToolTip.SetToolTip(this.tb_UserNameComputer, "Поле для ввода \"имени пользователя компьютера\"\r\nЭто нужно, чтобы процесс перезапи" +
        "си и сохранения файла\r\nпроходил без ошибок");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 349);
            this.Controls.Add(this.tb_UserNameComputer);
            this.Controls.Add(this.lb_UserNameComputer);
            this.Controls.Add(this.tb_PhoneNumber);
            this.Controls.Add(this.lb_Sex);
            this.Controls.Add(this.cmb_Sex);
            this.Controls.Add(this.lb_NumberPhone);
            this.Controls.Add(this.lb_DateHB);
            this.Controls.Add(this.date_HappyBirthday);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.tb_MiddleName);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.lb_SecondName);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.tb_OutputUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Attestation Exception";
            this.MyToolTip.SetToolTip(this, "Основное поле программы");
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Date_HappyBirthday_ValueChanged1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Date_HappyBirthday_ValueChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox tb_OutputUser;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Label lb_SecondName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.TextBox tb_MiddleName;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.DateTimePicker date_HappyBirthday;
        private System.Windows.Forms.Label lb_DateHB;
        private System.Windows.Forms.Label lb_NumberPhone;
        private System.Windows.Forms.ComboBox cmb_Sex;
        private System.Windows.Forms.Label lb_Sex;
        private System.Windows.Forms.MaskedTextBox tb_PhoneNumber;
        private System.Windows.Forms.Label lb_UserNameComputer;
        private System.Windows.Forms.TextBox tb_UserNameComputer;
    }
}

