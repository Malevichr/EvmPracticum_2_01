namespace CircularPlateCalculationApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPuassonRatio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownElasticityModul = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPermissibleDeflection = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlateThickness = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlateRadius = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPressure = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxScheme1 = new System.Windows.Forms.CheckBox();
            this.checkBoxScheme2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuassonRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElasticityModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPermissibleDeflection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlateThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlateRadius)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownPuassonRatio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownElasticityModul);
            this.groupBox1.Controls.Add(this.numericUpDownPermissibleDeflection);
            this.groupBox1.Controls.Add(this.numericUpDownPlateThickness);
            this.groupBox1.Controls.Add(this.numericUpDownPlateRadius);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод начальных значений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коэфицент Пуассона";
            // 
            // numericUpDownPuassonRatio
            // 
            this.numericUpDownPuassonRatio.DecimalPlaces = 2;
            this.numericUpDownPuassonRatio.Location = new System.Drawing.Point(275, 135);
            this.numericUpDownPuassonRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPuassonRatio.Name = "numericUpDownPuassonRatio";
            this.numericUpDownPuassonRatio.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPuassonRatio.TabIndex = 8;
            this.numericUpDownPuassonRatio.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Модуль упругости, ГПа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Допускаемый прогиб, см";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Толщина пластины, см";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Радиус пластины, см";
            // 
            // numericUpDownElasticityModul
            // 
            this.numericUpDownElasticityModul.Location = new System.Drawing.Point(275, 107);
            this.numericUpDownElasticityModul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownElasticityModul.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownElasticityModul.Name = "numericUpDownElasticityModul";
            this.numericUpDownElasticityModul.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownElasticityModul.TabIndex = 3;
            this.numericUpDownElasticityModul.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // numericUpDownPermissibleDeflection
            // 
            this.numericUpDownPermissibleDeflection.DecimalPlaces = 1;
            this.numericUpDownPermissibleDeflection.Location = new System.Drawing.Point(276, 78);
            this.numericUpDownPermissibleDeflection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPermissibleDeflection.Name = "numericUpDownPermissibleDeflection";
            this.numericUpDownPermissibleDeflection.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPermissibleDeflection.TabIndex = 2;
            // 
            // numericUpDownPlateThickness
            // 
            this.numericUpDownPlateThickness.DecimalPlaces = 1;
            this.numericUpDownPlateThickness.Location = new System.Drawing.Point(277, 49);
            this.numericUpDownPlateThickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPlateThickness.Name = "numericUpDownPlateThickness";
            this.numericUpDownPlateThickness.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPlateThickness.TabIndex = 1;
            // 
            // numericUpDownPlateRadius
            // 
            this.numericUpDownPlateRadius.Location = new System.Drawing.Point(277, 21);
            this.numericUpDownPlateRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPlateRadius.Name = "numericUpDownPlateRadius";
            this.numericUpDownPlateRadius.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPlateRadius.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPower);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxPressure);
            this.groupBox2.Location = new System.Drawing.Point(13, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(403, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Допускаемое значение внешней нагрузки из расчета на жесткость";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(243, 79);
            this.textBoxPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.ReadOnly = true;
            this.textBoxPower.Size = new System.Drawing.Size(151, 22);
            this.textBoxPower.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Сила P, кН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Давление p, кПа";
            // 
            // textBoxPressure
            // 
            this.textBoxPressure.Location = new System.Drawing.Point(243, 50);
            this.textBoxPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPressure.Name = "textBoxPressure";
            this.textBoxPressure.ReadOnly = true;
            this.textBoxPressure.Size = new System.Drawing.Size(152, 22);
            this.textBoxPressure.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxScheme2);
            this.groupBox3.Controls.Add(this.checkBoxScheme1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(423, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(543, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбр расчетной системы";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CircularPlateCalculationApp.Properties.Resources.Scheme2;
            this.pictureBox2.Location = new System.Drawing.Point(275, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CircularPlateCalculationApp.Properties.Resources.Scheme1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(423, 190);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(267, 146);
            this.buttonEvaluate.TabIndex = 3;
            this.buttonEvaluate.Text = "Рассчитать";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(699, 190);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(267, 146);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Сбросить все";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxScheme1
            // 
            this.checkBoxScheme1.AutoSize = true;
            this.checkBoxScheme1.Location = new System.Drawing.Point(8, 144);
            this.checkBoxScheme1.Name = "checkBoxScheme1";
            this.checkBoxScheme1.Size = new System.Drawing.Size(79, 20);
            this.checkBoxScheme1.TabIndex = 4;
            this.checkBoxScheme1.Text = "Схема 1";
            this.checkBoxScheme1.UseVisualStyleBackColor = true;
            // 
            // checkBoxScheme2
            // 
            this.checkBoxScheme2.AutoSize = true;
            this.checkBoxScheme2.Location = new System.Drawing.Point(276, 144);
            this.checkBoxScheme2.Name = "checkBoxScheme2";
            this.checkBoxScheme2.Size = new System.Drawing.Size(79, 20);
            this.checkBoxScheme2.TabIndex = 5;
            this.checkBoxScheme2.Text = "Схема 2";
            this.checkBoxScheme2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 359);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuassonRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElasticityModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPermissibleDeflection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlateThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlateRadius)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPlateThickness;
        private System.Windows.Forms.NumericUpDown numericUpDownPlateRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownElasticityModul;
        private System.Windows.Forms.NumericUpDown numericUpDownPermissibleDeflection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPuassonRatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPressure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxScheme2;
        private System.Windows.Forms.CheckBox checkBoxScheme1;
    }
}

