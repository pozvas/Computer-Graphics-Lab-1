namespace Lab_1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локальныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глобальныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СерыймирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьИзмененияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.щарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приюттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.математическаяМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наращиваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эрозияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размыканиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замыканиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьСтруктурныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.локальныеToolStripMenuItem,
            this.глобальныеToolStripMenuItem,
            this.математическаяМорфологияToolStripMenuItem,
            this.отменитьИзмененияToolStripMenuItem1});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.оттенкиСерогоToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // локальныеToolStripMenuItem
            // 
            this.локальныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.резкостьToolStripMenuItem,
            this.блюрToolStripMenuItem,
            this.гауссаToolStripMenuItem,
            this.собеляToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.щарраToolStripMenuItem,
            this.приюттаToolStripMenuItem});
            this.локальныеToolStripMenuItem.Name = "локальныеToolStripMenuItem";
            this.локальныеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.локальныеToolStripMenuItem.Text = "Локальные";
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // блюрToolStripMenuItem
            // 
            this.блюрToolStripMenuItem.Name = "блюрToolStripMenuItem";
            this.блюрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.блюрToolStripMenuItem.Text = "Блюр";
            this.блюрToolStripMenuItem.Click += new System.EventHandler(this.блюрToolStripMenuItem_Click);
            // 
            // гауссаToolStripMenuItem
            // 
            this.гауссаToolStripMenuItem.Name = "гауссаToolStripMenuItem";
            this.гауссаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гауссаToolStripMenuItem.Text = "Гаусса";
            this.гауссаToolStripMenuItem.Click += new System.EventHandler(this.гауссаToolStripMenuItem_Click);
            // 
            // собеляToolStripMenuItem
            // 
            this.собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            this.собеляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.собеляToolStripMenuItem.Text = "Собеля ";
            this.собеляToolStripMenuItem.Click += new System.EventHandler(this.собеляToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // глобальныеToolStripMenuItem
            // 
            this.глобальныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СерыймирToolStripMenuItem});
            this.глобальныеToolStripMenuItem.Name = "глобальныеToolStripMenuItem";
            this.глобальныеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.глобальныеToolStripMenuItem.Text = "Глобальные";
            // 
            // СерыймирToolStripMenuItem
            // 
            this.СерыймирToolStripMenuItem.Name = "СерыймирToolStripMenuItem";
            this.СерыймирToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.СерыймирToolStripMenuItem.Text = "\"Серый мир\"";
            this.СерыймирToolStripMenuItem.Click += new System.EventHandler(this.СерыймирToolStripMenuItem_Click);
            // 
            // отменитьИзмененияToolStripMenuItem1
            // 
            this.отменитьИзмененияToolStripMenuItem1.Name = "отменитьИзмененияToolStripMenuItem1";
            this.отменитьИзмененияToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.отменитьИзмененияToolStripMenuItem1.Text = "Отменить изменения";
            this.отменитьИзмененияToolStripMenuItem1.Click += new System.EventHandler(this.отменитьИзмененияToolStripMenuItem1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 337);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(485, 19);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // щарраToolStripMenuItem
            // 
            this.щарраToolStripMenuItem.Name = "щарраToolStripMenuItem";
            this.щарраToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.щарраToolStripMenuItem.Text = "Щарра";
            this.щарраToolStripMenuItem.Click += new System.EventHandler(this.щарраToolStripMenuItem_Click);
            // 
            // приюттаToolStripMenuItem
            // 
            this.приюттаToolStripMenuItem.Name = "приюттаToolStripMenuItem";
            this.приюттаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.приюттаToolStripMenuItem.Text = "Приютта";
            this.приюттаToolStripMenuItem.Click += new System.EventHandler(this.приюттаToolStripMenuItem_Click);
            // 
            // математическаяМорфологияToolStripMenuItem
            // 
            this.математическаяМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наращиваниеToolStripMenuItem,
            this.эрозияToolStripMenuItem,
            this.размыканиеToolStripMenuItem,
            this.замыканиеToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.blackHatToolStripMenuItem,
            this.задатьСтруктурныйЭлементToolStripMenuItem});
            this.математическаяМорфологияToolStripMenuItem.Name = "математическаяМорфологияToolStripMenuItem";
            this.математическаяМорфологияToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.математическаяМорфологияToolStripMenuItem.Text = "Математическая морфология";
            // 
            // наращиваниеToolStripMenuItem
            // 
            this.наращиваниеToolStripMenuItem.Name = "наращиваниеToolStripMenuItem";
            this.наращиваниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.наращиваниеToolStripMenuItem.Text = "Наращивание";
            this.наращиваниеToolStripMenuItem.Click += new System.EventHandler(this.наращиваниеToolStripMenuItem_Click);
            // 
            // эрозияToolStripMenuItem
            // 
            this.эрозияToolStripMenuItem.Name = "эрозияToolStripMenuItem";
            this.эрозияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.эрозияToolStripMenuItem.Text = "Эрозия";
            this.эрозияToolStripMenuItem.Click += new System.EventHandler(this.эрозияToolStripMenuItem_Click);
            // 
            // размыканиеToolStripMenuItem
            // 
            this.размыканиеToolStripMenuItem.Name = "размыканиеToolStripMenuItem";
            this.размыканиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размыканиеToolStripMenuItem.Text = "Размыкание";
            this.размыканиеToolStripMenuItem.Click += new System.EventHandler(this.размыканиеToolStripMenuItem_Click);
            // 
            // замыканиеToolStripMenuItem
            // 
            this.замыканиеToolStripMenuItem.Name = "замыканиеToolStripMenuItem";
            this.замыканиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.замыканиеToolStripMenuItem.Text = "Замыкание";
            this.замыканиеToolStripMenuItem.Click += new System.EventHandler(this.замыканиеToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topHatToolStripMenuItem.Text = "Top hat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // blackHatToolStripMenuItem
            // 
            this.blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            this.blackHatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackHatToolStripMenuItem.Text = "Black Hat";
            this.blackHatToolStripMenuItem.Click += new System.EventHandler(this.blackHatToolStripMenuItem_Click);
            // 
            // задатьСтруктурныйЭлементToolStripMenuItem
            // 
            this.задатьСтруктурныйЭлементToolStripMenuItem.Name = "задатьСтруктурныйЭлементToolStripMenuItem";
            this.задатьСтруктурныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.задатьСтруктурныйЭлементToolStripMenuItem.Text = "Задать структурный элемент";
            this.задатьСтруктурныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.задатьСтруктурныйЭлементToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локальныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem глобальныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СерыймирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem блюрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem щарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приюттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem математическаяМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наращиваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эрозияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размыканиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замыканиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьСтруктурныйЭлементToolStripMenuItem;
    }
}

