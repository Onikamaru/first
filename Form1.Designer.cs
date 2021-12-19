namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Color2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Font2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Text2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Left2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Center2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Right2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTB = new System.Windows.Forms.RichTextBox();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.Cut = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italics = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Color = new System.Windows.Forms.ToolStripButton();
            this.Font = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Left = new System.Windows.Forms.ToolStripButton();
            this.Center = new System.Windows.Forms.ToolStripButton();
            this.Right = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.правкаToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.Save_as});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(180, 22);
            this.New.Text = "Новый";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(180, 22);
            this.Open.Text = "Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Save_as
            // 
            this.Save_as.Name = "Save_as";
            this.Save_as.Size = new System.Drawing.Size(180, 22);
            this.Save_as.Text = "Сохранить как...";
            this.Save_as.Click += new System.EventHandler(this.Save_as_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo1,
            this.Clear1,
            this.Cut1,
            this.Copy1,
            this.Paste1});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // Undo1
            // 
            this.Undo1.Name = "Undo1";
            this.Undo1.Size = new System.Drawing.Size(139, 22);
            this.Undo1.Text = "Отменить";
            this.Undo1.Click += new System.EventHandler(this.Undo1_Click);
            // 
            // Clear1
            // 
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(139, 22);
            this.Clear1.Text = "Очистить";
            this.Clear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // Cut1
            // 
            this.Cut1.Name = "Cut1";
            this.Cut1.Size = new System.Drawing.Size(139, 22);
            this.Cut1.Text = "Вырезать";
            this.Cut1.Click += new System.EventHandler(this.Cut1_Click);
            // 
            // Copy1
            // 
            this.Copy1.Name = "Copy1";
            this.Copy1.Size = new System.Drawing.Size(139, 22);
            this.Copy1.Text = "Копировать";
            this.Copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // Paste1
            // 
            this.Paste1.Name = "Paste1";
            this.Paste1.Size = new System.Drawing.Size(139, 22);
            this.Paste1.Text = "Вставить";
            this.Paste1.Click += new System.EventHandler(this.Paste1_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Color2,
            this.Font2,
            this.Text2});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // Color2
            // 
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(192, 22);
            this.Color2.Text = "Цветовая палитра";
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // Font2
            // 
            this.Font2.Name = "Font2";
            this.Font2.Size = new System.Drawing.Size(192, 22);
            this.Font2.Text = "Изменение шрифта";
            this.Font2.Click += new System.EventHandler(this.Font2_Click);
            // 
            // Text2
            // 
            this.Text2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Left2,
            this.Center2,
            this.Right2});
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(192, 22);
            this.Text2.Text = "Выравнивание текста";
            // 
            // Left2
            // 
            this.Left2.Name = "Left2";
            this.Left2.Size = new System.Drawing.Size(122, 22);
            this.Left2.Text = "Слева";
            this.Left2.Click += new System.EventHandler(this.Left2_Click);
            // 
            // Center2
            // 
            this.Center2.Name = "Center2";
            this.Center2.Size = new System.Drawing.Size(122, 22);
            this.Center2.Text = "В центре";
            this.Center2.Click += new System.EventHandler(this.Center2_Click);
            // 
            // Right2
            // 
            this.Right2.Name = "Right2";
            this.Right2.Size = new System.Drawing.Size(122, 22);
            this.Right2.Text = "Справа";
            this.Right2.Click += new System.EventHandler(this.Right2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTB
            // 
            this.richTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTB.Location = new System.Drawing.Point(0, 49);
            this.richTB.Name = "richTB";
            this.richTB.Size = new System.Drawing.Size(487, 254);
            this.richTB.TabIndex = 3;
            this.richTB.Text = "";
            // 
            // Undo
            // 
            this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Undo.Image = ((System.Drawing.Image)(resources.GetObject("Undo.Image")));
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(23, 22);
            this.Undo.Text = "Отменить";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(23, 22);
            this.Clear.Text = "Очистить";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Cut
            // 
            this.Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(23, 22);
            this.Cut.Text = "Вырезать";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(23, 22);
            this.Copy.Text = "Копировать";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(23, 22);
            this.Paste.Text = "Вставить";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "Жирный";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italics
            // 
            this.Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italics.Image = ((System.Drawing.Image)(resources.GetObject("Italics.Image")));
            this.Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italics.Name = "Italics";
            this.Italics.Size = new System.Drawing.Size(23, 22);
            this.Italics.Text = "Курсив";
            this.Italics.Click += new System.EventHandler(this.Italics_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.Text = "Подчеркивание";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Color
            // 
            this.Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Color.Image = ((System.Drawing.Image)(resources.GetObject("Color.Image")));
            this.Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(23, 22);
            this.Color.Text = "Цвет";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Font
            // 
            this.Font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Font.Image = ((System.Drawing.Image)(resources.GetObject("Font.Image")));
            this.Font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(23, 22);
            this.Font.Text = "Шрифт";
            this.Font.Click += new System.EventHandler(this.Font_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Left
            // 
            this.Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Left.Image = ((System.Drawing.Image)(resources.GetObject("Left.Image")));
            this.Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(23, 22);
            this.Left.Text = "Лево";
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Center
            // 
            this.Center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Center.Image = ((System.Drawing.Image)(resources.GetObject("Center.Image")));
            this.Center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(23, 22);
            this.Center.Text = "Центр";
            this.Center.Click += new System.EventHandler(this.Center_Click);
            // 
            // Right
            // 
            this.Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Right.Image = ((System.Drawing.Image)(resources.GetObject("Right.Image")));
            this.Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(23, 22);
            this.Right.Text = "toolStripButton3";
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo,
            this.Clear,
            this.Cut,
            this.Copy,
            this.Paste,
            this.toolStripSeparator1,
            this.Bold,
            this.Italics,
            this.Underline,
            this.toolStripSeparator2,
            this.Color,
            this.Font,
            this.toolStripSeparator3,
            this.Left,
            this.Center,
            this.Right});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(487, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Data,
            this.Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Data
            // 
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(118, 17);
            this.Data.Text = "toolStripStatusLabel1";
            // 
            // Time
            // 
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(118, 17);
            this.Time.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SimpleEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Save_as;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTB;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Undo1;
        private System.Windows.Forms.ToolStripMenuItem Clear1;
        private System.Windows.Forms.ToolStripMenuItem Cut1;
        private System.Windows.Forms.ToolStripMenuItem Copy1;
        private System.Windows.Forms.ToolStripMenuItem Paste1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Color2;
        private System.Windows.Forms.ToolStripMenuItem Font2;
        private System.Windows.Forms.ToolStripMenuItem Text2;
        private System.Windows.Forms.ToolStripMenuItem Left2;
        private System.Windows.Forms.ToolStripMenuItem Center2;
        private System.Windows.Forms.ToolStripMenuItem Right2;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripButton Cut;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripButton Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italics;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Color;
        private System.Windows.Forms.ToolStripButton Font;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Left;
        private System.Windows.Forms.ToolStripButton Center;
        private System.Windows.Forms.ToolStripButton Right;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.ToolStripStatusLabel Time;
    }
}

