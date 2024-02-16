using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CircularPlateCalculationApp
{
    public partial class Form1 : Form
    {
        double r; // радиус
        double h; // давление  
        double w; // допустимый прогиб
        double E; // модуль упругости
        double v; // коэффициент Пуассона
        double D; // цилиндрическая жёсткость пластины
        double p; // давление
        double P; // сила

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownElasticityModul.Value = 160;
            numericUpDownPermissibleDeflection.Value = 0;
            numericUpDownPlateRadius.Value = 0;
            numericUpDownPlateThickness.Value = 0;
            numericUpDownPuassonRatio.Value = 0.3M;
            checkBoxScheme1.Checked = false;
            checkBoxScheme2.Checked = false;
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            // Ввод начальных значений и их перевод в СИ
            r = (double)(numericUpDownPlateRadius.Value / 100); // радиус, (см -> м)
            h = (double)(numericUpDownPlateThickness.Value / 100); // толщина, (см -> м)              
            w = (double)(numericUpDownPermissibleDeflection.Value / 1000); // допустимый прогиб, (мм -> м)
            E = (double)(numericUpDownElasticityModul.Value * 1000000000); // модуль упругости (ГПа -> Па)
            v = (double)numericUpDownPuassonRatio.Value; // коэффициент Пуассона 
            D = E * h * h * h / (12 * (1 - v * v));
            if (checkBoxScheme1.Checked) // выбор расчётной схемы №1

            {
                p = 64 * D * (1 + v) * w / (Math.Pow(r, 4) * (5 + v)); // расчёт давления по формуле (1)
                p = Math.Round(p / 1000, 1); // перевод (Па -> кПа) и округление
                textBoxPressure.Text = p.ToString(); // вывод результата
            }

            if (checkBoxScheme2.Checked) // Выбор расчётной схемы №2

            {
                P = 16 * Math.PI * D * (1 + v) * w / (r * r * (3 + v)); // расчёт силы по формуле (2)
                P = Math.Round(P / 1000, 1); // перевод (Н -> кН) и округление
                textBoxPower.Text = P.ToString(); // вывод результата
            }

        }
    }
}
