namespace Lab5_2
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
   this.panel1 = new System.Windows.Forms.Panel();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
   this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.повернутьВокруг0YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.уменьшитьВ2РазаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.прозрачныйЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.colorDialog1 = new System.Windows.Forms.ColorDialog();
   this.фильтроватьПоПикселямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.растянутьИСохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.обрезатьПоРамкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.panel1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.menuStrip1.SuspendLayout();
   this.SuspendLayout();
   // 
   // panel1
   // 
   this.panel1.AutoScroll = true;
   this.panel1.Controls.Add(this.pictureBox1);
   this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.panel1.Location = new System.Drawing.Point(0, 24);
   this.panel1.Name = "panel1";
   this.panel1.Size = new System.Drawing.Size(625, 435);
   this.panel1.TabIndex = 0;
   // 
   // pictureBox1
   // 
   this.pictureBox1.Location = new System.Drawing.Point(0, 0);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(625, 435);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox1.TabIndex = 0;
   this.pictureBox1.TabStop = false;
   this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
   this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
   this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
   this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
   // 
   // openFileDialog1
   // 
   this.openFileDialog1.FileName = "openFileDialog1";
   this.openFileDialog1.Filter = "Все файлы|*.*";
   // 
   // открытьToolStripMenuItem
   // 
   this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
   this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
   this.открытьToolStripMenuItem.Text = "Открыть";
   this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
   // 
   // menuStrip1
   // 
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(625, 24);
   this.menuStrip1.TabIndex = 1;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // файлToolStripMenuItem
   // 
   this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
   this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
   this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
   this.файлToolStripMenuItem.Text = "Файл";
   // 
   // открытьToolStripMenuItem1
   // 
   this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
   this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
   this.открытьToolStripMenuItem1.Text = "Открыть";
   this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
   // 
   // правкаToolStripMenuItem
   // 
   this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повернутьВокруг0YToolStripMenuItem,
            this.уменьшитьВ2РазаToolStripMenuItem,
            this.прозрачныйЦветToolStripMenuItem,
            this.фильтроватьПоПикселямToolStripMenuItem,
            this.оттенкиСерогоToolStripMenuItem,
            this.растянутьИСохранитьToolStripMenuItem,
            this.обрезатьПоРамкеToolStripMenuItem});
   this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
   this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
   this.правкаToolStripMenuItem.Text = "Правка";
   // 
   // повернутьВокруг0YToolStripMenuItem
   // 
   this.повернутьВокруг0YToolStripMenuItem.Name = "повернутьВокруг0YToolStripMenuItem";
   this.повернутьВокруг0YToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.повернутьВокруг0YToolStripMenuItem.Text = "Повернуть на 180 градусов";
   this.повернутьВокруг0YToolStripMenuItem.Click += new System.EventHandler(this.повернутьВокруг0YToolStripMenuItem_Click);
   // 
   // уменьшитьВ2РазаToolStripMenuItem
   // 
   this.уменьшитьВ2РазаToolStripMenuItem.Name = "уменьшитьВ2РазаToolStripMenuItem";
   this.уменьшитьВ2РазаToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.уменьшитьВ2РазаToolStripMenuItem.Text = "Уменьшить в 2 раза";
   this.уменьшитьВ2РазаToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьВ2РазаToolStripMenuItem_Click);
   // 
   // сохранитьToolStripMenuItem
   // 
   this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
   this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
   this.сохранитьToolStripMenuItem.Text = "Сохранить";
   this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
   // 
   // прозрачныйЦветToolStripMenuItem
   // 
   this.прозрачныйЦветToolStripMenuItem.Name = "прозрачныйЦветToolStripMenuItem";
   this.прозрачныйЦветToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.прозрачныйЦветToolStripMenuItem.Text = "Прозрачный цвет";
   this.прозрачныйЦветToolStripMenuItem.Click += new System.EventHandler(this.прозрачныйЦветToolStripMenuItem_Click);
   // 
   // фильтроватьПоПикселямToolStripMenuItem
   // 
   this.фильтроватьПоПикселямToolStripMenuItem.Name = "фильтроватьПоПикселямToolStripMenuItem";
   this.фильтроватьПоПикселямToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.фильтроватьПоПикселямToolStripMenuItem.Text = "Фильтровать по пикселям";
   this.фильтроватьПоПикселямToolStripMenuItem.Click += new System.EventHandler(this.фильтроватьПоПикселямToolStripMenuItem_Click);
   // 
   // оттенкиСерогоToolStripMenuItem
   // 
   this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
   this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
   this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
   // 
   // растянутьИСохранитьToolStripMenuItem
   // 
   this.растянутьИСохранитьToolStripMenuItem.Name = "растянутьИСохранитьToolStripMenuItem";
   this.растянутьИСохранитьToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.растянутьИСохранитьToolStripMenuItem.Text = "Растянуть и сохранить";
   this.растянутьИСохранитьToolStripMenuItem.Click += new System.EventHandler(this.растянутьИСохранитьToolStripMenuItem_Click);
   // 
   // обрезатьПоРамкеToolStripMenuItem
   // 
   this.обрезатьПоРамкеToolStripMenuItem.Name = "обрезатьПоРамкеToolStripMenuItem";
   this.обрезатьПоРамкеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
   this.обрезатьПоРамкеToolStripMenuItem.Text = "Обрезать по рамке";
   this.обрезатьПоРамкеToolStripMenuItem.Click += new System.EventHandler(this.обрезатьПоРамкеToolStripMenuItem_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(625, 459);
   this.Controls.Add(this.panel1);
   this.Controls.Add(this.menuStrip1);
   this.Name = "Form1";
   this.Text = "Form1";
   this.panel1.ResumeLayout(false);
   this.panel1.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.OpenFileDialog openFileDialog1;
  private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
  private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem повернутьВокруг0YToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem уменьшитьВ2РазаToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem прозрачныйЦветToolStripMenuItem;
  private System.Windows.Forms.ColorDialog colorDialog1;
  private System.Windows.Forms.ToolStripMenuItem фильтроватьПоПикселямToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem растянутьИСохранитьToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem обрезатьПоРамкеToolStripMenuItem;
 }
}

