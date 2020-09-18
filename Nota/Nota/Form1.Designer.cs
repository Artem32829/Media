namespace Nota
{
    partial class Nota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nota));
            this.Songs = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lable = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.prew = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.low = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.Button();
            this.high = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorSlider2 = new ColorSlider.ColorSlider();
            this.colorSlider4 = new ColorSlider.ColorSlider();
            this.question = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.high)).BeginInit();
            this.SuspendLayout();
            // 
            // Songs
            // 
            this.Songs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Songs.FormattingEnabled = true;
            this.Songs.Location = new System.Drawing.Point(10, 45);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(272, 212);
            this.Songs.TabIndex = 0;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 39);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lable
            // 
            this.lable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lable.Image = ((System.Drawing.Image)(resources.GetObject("lable.Image")));
            this.lable.Location = new System.Drawing.Point(0, 2);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(70, 35);
            this.lable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lable.TabIndex = 3;
            this.lable.TabStop = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play.Location = new System.Drawing.Point(4, 307);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(39, 38);
            this.play.TabIndex = 4;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.Location = new System.Drawing.Point(41, 310);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(31, 32);
            this.stop.TabIndex = 5;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // prew
            // 
            this.prew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.prew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prew.BackgroundImage")));
            this.prew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prew.Location = new System.Drawing.Point(68, 309);
            this.prew.Name = "prew";
            this.prew.Size = new System.Drawing.Size(31, 35);
            this.prew.TabIndex = 6;
            this.prew.UseVisualStyleBackColor = false;
            this.prew.Click += new System.EventHandler(this.prew_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next.Location = new System.Drawing.Point(96, 309);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(31, 35);
            this.next.TabIndex = 7;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause.BackgroundImage")));
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.Location = new System.Drawing.Point(259, 310);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(37, 35);
            this.pause.TabIndex = 8;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // low
            // 
            this.low.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.low.Image = ((System.Drawing.Image)(resources.GetObject("low.Image")));
            this.low.Location = new System.Drawing.Point(128, 316);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(24, 24);
            this.low.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.low.TabIndex = 10;
            this.low.TabStop = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(125, 360);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 47);
            this.add.TabIndex = 12;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // high
            // 
            this.high.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.high.Image = ((System.Drawing.Image)(resources.GetObject("high.Image")));
            this.high.Location = new System.Drawing.Point(234, 316);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(24, 24);
            this.high.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.high.TabIndex = 13;
            this.high.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // colorSlider2
            // 
            this.colorSlider2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colorSlider2.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSlider2.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSlider2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider2.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.colorSlider2.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.colorSlider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSlider2.ForeColor = System.Drawing.Color.White;
            this.colorSlider2.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider2.Location = new System.Drawing.Point(10, 279);
            this.colorSlider2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.colorSlider2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSlider2.Name = "colorSlider2";
            this.colorSlider2.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSlider2.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider2.ShowDivisionsText = true;
            this.colorSlider2.ShowSmallScale = false;
            this.colorSlider2.Size = new System.Drawing.Size(275, 22);
            this.colorSlider2.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSlider2.TabIndex = 19;
            this.colorSlider2.Text = "colorSlider2";
            this.colorSlider2.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider2.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider2.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSlider2.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSlider2.TickAdd = 0F;
            this.colorSlider2.TickColor = System.Drawing.Color.White;
            this.colorSlider2.TickDivide = 0F;
            this.colorSlider2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSlider2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider2_Scroll);
            // 
            // colorSlider4
            // 
            this.colorSlider4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colorSlider4.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSlider4.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSlider4.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider4.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider4.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.colorSlider4.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.colorSlider4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSlider4.ForeColor = System.Drawing.Color.White;
            this.colorSlider4.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider4.Location = new System.Drawing.Point(155, 312);
            this.colorSlider4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.colorSlider4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSlider4.Name = "colorSlider4";
            this.colorSlider4.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSlider4.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider4.ShowDivisionsText = true;
            this.colorSlider4.ShowSmallScale = false;
            this.colorSlider4.Size = new System.Drawing.Size(70, 28);
            this.colorSlider4.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSlider4.TabIndex = 20;
            this.colorSlider4.Text = "colorSlider4";
            this.colorSlider4.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider4.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSlider4.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSlider4.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSlider4.TickAdd = 0F;
            this.colorSlider4.TickColor = System.Drawing.Color.White;
            this.colorSlider4.TickDivide = 0F;
            this.colorSlider4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.colorSlider4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider4_Scroll);
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.question.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("question.BackgroundImage")));
            this.question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.question.Location = new System.Drawing.Point(4, 381);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(27, 26);
            this.question.TabIndex = 21;
            this.question.UseVisualStyleBackColor = false;
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 414);
            this.Controls.Add(this.question);
            this.Controls.Add(this.colorSlider4);
            this.Controls.Add(this.colorSlider2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.high);
            this.Controls.Add(this.add);
            this.Controls.Add(this.low);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prew);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Songs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nota";
            this.Text = "Nota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.high)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox lable;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button prew;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.PictureBox low;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.PictureBox high;
        private ColorSlider.ColorSlider colorSlider1;
        private ColorSlider.ColorSlider colorSlider3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private ColorSlider.ColorSlider colorSlider2;
        private ColorSlider.ColorSlider colorSlider4;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button question;
    }
}

