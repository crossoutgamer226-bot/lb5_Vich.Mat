using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lb5_Vich.Mat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].DefaultCellStyle.Format = "F3";
            PlotRandomPoints();
        }

        private void PlotRandomPoints()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea area = new ChartArea("MainArea");
            chart1.ChartAreas.Add(area);

            // -----------------------------
            // 1. Генерация исходных точек
            // -----------------------------
            Series rawSeries = new Series("Исходные точки");
            rawSeries.ChartType = SeriesChartType.Point;
            rawSeries.MarkerStyle = MarkerStyle.Circle;
            rawSeries.MarkerSize = 6;
            rawSeries.Color = Color.Blue;

            double[] Y = new double[100];
            double[] X = new double[100];
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                double x = i;
                double y = Math.Sin(i / 10.0) + rnd.NextDouble();
                X[i] = x;
                Y[i] = y;

                rawSeries.Points.AddXY(x, y);
            }

            chart1.Series.Add(rawSeries);

            // -----------------------------
            // 1.1. Таблица исходных данных X, Y
            // -----------------------------
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 100; i++)
                dataGridView1.Rows.Add(X[i], Y[i]);

            // -----------------------------
            // 2. Сглаживание (скользящее среднее)
            // -----------------------------

            int window1 = 7;
            int m1 = window1 / 2;
            double[] smoothY1 = new double[100];

            for (int i = 0; i < 100; i++)
            {
                double sum = 0;
                int count = 0;

                for (int j = i - m1; j <= i + m1; j++)
                {
                    if (j >= 0 && j < 100)
                    {
                        sum += Y[j];
                        count++;
                    }
                }

                smoothY1[i] = sum / count;
            }

            Series smoothSeries1 = new Series("Скользящее среднее (окно 7)");
            smoothSeries1.ChartType = SeriesChartType.Line;
            smoothSeries1.Color = Color.Red;
            smoothSeries1.BorderWidth = 2;

            for (int i = 0; i < 100; i++)
                smoothSeries1.Points.AddXY(i, smoothY1[i]);

            chart1.Series.Add(smoothSeries1);

            int window2 = 11;
            int m2 = window2 / 2;
            double[] smoothY2 = new double[100];

            for (int i = 0; i < 100; i++)
            {
                double sum = 0;
                int count = 0;

                for (int j = i - m2; j <= i + m2; j++)
                {
                    if (j >= 0 && j < 100)
                    {
                        sum += Y[j];
                        count++;
                    }
                }

                smoothY2[i] = sum / count;
            }

            Series smoothSeries2 = new Series("Скользящее среднее (окно 11)");
            smoothSeries2.ChartType = SeriesChartType.Line;
            smoothSeries2.Color = Color.Orange;
            smoothSeries2.BorderWidth = 2;

            for (int i = 0; i < 100; i++)
                smoothSeries2.Points.AddXY(i, smoothY2[i]);

            chart1.Series.Add(smoothSeries2);

            // -----------------------------
            // 3. Локальное сглаживание кубическим МНК
            // -----------------------------
            double[] polyY = new double[100];

            for (int i = 0; i < 100; i++)
            {
                int start, end;

                if (i <= 2)
                {
                    start = 0;
                    end = 4;
                }
                else if (i >= 97)
                {
                    start = 95;
                    end = 99;
                }
                else
                {
                    start = i - 2;
                    end = i + 2;
                }

                int n = end - start + 1;

                double[] xs = new double[n];
                double[] ys = new double[n];

                for (int k = 0; k < n; k++)
                {
                    xs[k] = start + k;
                    ys[k] = Y[start + k];
                }

                double[] coeff = FitCubic(xs, ys);

                double x0 = i;
                polyY[i] = coeff[0] * x0 * x0 * x0 +
                           coeff[1] * x0 * x0 +
                           coeff[2] * x0 +
                           coeff[3];
            }

            Series polySeries = new Series("Локальное сглаживание кубическим МНК");
            polySeries.ChartType = SeriesChartType.Line;
            polySeries.Color = Color.Green;
            polySeries.BorderWidth = 2;

            for (int i = 0; i < 100; i++)
                polySeries.Points.AddXY(i, polyY[i]);

            chart1.Series.Add(polySeries);

            // -----------------------------
            // 4. Глобальный многочлен 4-й степени
            // -----------------------------
            double[] quarticCoeff = FitQuartic(X, Y);

            Series quarticSeries = new Series("Глобальный многочлен 4-й степени");
            quarticSeries.ChartType = SeriesChartType.Line;
            quarticSeries.Color = Color.Purple;
            quarticSeries.BorderWidth = 2;

            for (int i = 0; i < 100; i++)
            {
                double x0 = X[i];
                double y0 =
                    quarticCoeff[0] * Math.Pow(x0, 4) +
                    quarticCoeff[1] * Math.Pow(x0, 3) +
                    quarticCoeff[2] * x0 * x0 +
                    quarticCoeff[3] * x0 +
                    quarticCoeff[4];

                quarticSeries.Points.AddXY(x0, y0);
            }

            chart1.Series.Add(quarticSeries);

            // Подписи осей
            chart1.ChartAreas["MainArea"].AxisX.Title = "X = i";
            chart1.ChartAreas["MainArea"].AxisY.Title = "Y, Y_smooth, Y_mnk, Y_quartic";

            ApplyCheckBoxVisibility();
        }

        // ---------------------------------------------------------
        // МНК для кубического многочлена
        // ---------------------------------------------------------
        private double[] FitCubic(double[] x, double[] y)
        {
            int n = x.Length;

            double[,] A = new double[4, 4];
            double[] B = new double[4];

            for (int i = 0; i < n; i++)
            {
                double xi = x[i];
                double yi = y[i];

                double x1 = xi;
                double x2 = xi * xi;
                double x3 = xi * xi * xi;

                A[0, 0] += x3 * x3;
                A[0, 1] += x3 * x2;
                A[0, 2] += x3 * x1;
                A[0, 3] += x3;

                A[1, 0] += x2 * x3;
                A[1, 1] += x2 * x2;
                A[1, 2] += x2 * x1;
                A[1, 3] += x2;

                A[2, 0] += x1 * x3;
                A[2, 1] += x1 * x2;
                A[2, 2] += x1 * x1;
                A[2, 3] += x1;

                A[3, 0] += x3;
                A[3, 1] += x2;
                A[3, 2] += x1;
                A[3, 3] += 1;

                B[0] += yi * x3;
                B[1] += yi * x2;
                B[2] += yi * x1;
                B[3] += yi;
            }

            return Solve4x4(A, B);
        }

        // ---------------------------------------------------------
        // МНК для многочлена 4 степени
        // ---------------------------------------------------------
        private double[] FitQuartic(double[] x, double[] y)
        {
            int n = x.Length;

            double[,] A = new double[5, 5];
            double[] B = new double[5];

            for (int i = 0; i < n; i++)
            {
                double xi = x[i];
                double yi = y[i];

                double x1 = xi;
                double x2 = xi * xi;
                double x3 = x2 * xi;
                double x4 = x2 * x2;

                A[0, 0] += x4 * x4;
                A[0, 1] += x4 * x3;
                A[0, 2] += x4 * x2;
                A[0, 3] += x4 * x1;
                A[0, 4] += x4;

                A[1, 0] += x3 * x4;
                A[1, 1] += x3 * x3;
                A[1, 2] += x3 * x2;
                A[1, 3] += x3 * x1;
                A[1, 4] += x3;

                A[2, 0] += x2 * x4;
                A[2, 1] += x2 * x3;
                A[2, 2] += x2 * x2;
                A[2, 3] += x2 * x1;
                A[2, 4] += x2;

                A[3, 0] += x1 * x4;
                A[3, 1] += x1 * x3;
                A[3, 2] += x1 * x2;
                A[3, 3] += x1 * x1;
                A[3, 4] += x1;

                A[4, 0] += x4;
                A[4, 1] += x3;
                A[4, 2] += x2;
                A[4, 3] += x1;
                A[4, 4] += 1;

                B[0] += yi * x4;
                B[1] += yi * x3;
                B[2] += yi * x2;
                B[3] += yi * x1;
                B[4] += yi;
            }

            return Solve5x5(A, B);
        }

        // ---------------------------------------------------------
        // Решение СЛАУ 4×4 методом Гаусса
        // ---------------------------------------------------------
        private double[] Solve4x4(double[,] A, double[] B)
        {
            int n = 4;
            double[,] M = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    M[i, j] = A[i, j];
                M[i, n] = B[i];
            }

            for (int i = 0; i < n; i++)
            {
                double diag = M[i, i];
                for (int j = i; j <= n; j++)
                    M[i, j] /= diag;

                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = M[k, i];
                    for (int j = i; j <= n; j++)
                        M[k, j] -= factor * M[i, j];
                }
            }

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = M[i, n];

            return x;
        }

        // ---------------------------------------------------------
        // Решение СЛАУ 5×5 методом Гаусса
        // ---------------------------------------------------------
        private double[] Solve5x5(double[,] A, double[] B)
        {
            int n = 5;
            double[,] M = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    M[i, j] = A[i, j];
                M[i, n] = B[i];
            }

            for (int i = 0; i < n; i++)
            {
                double diag = M[i, i];
                for (int j = i; j <= n; j++)
                    M[i, j] /= diag;

                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = M[k, i];
                    for (int j = i; j <= n; j++)
                        M[k, j] -= factor * M[i, j];
                }
            }

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = M[i, n];

            return x;
        }

        // ---------------------------------------------------------
        // ОБРАБОТЧИКИ CheckBox
        // ---------------------------------------------------------

        private void cbRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chart1.Series.IndexOf("Исходные точки") >= 0)
                chart1.Series["Исходные точки"].Enabled = cbRaw.Checked;
        }

        private void cbSmooth7_CheckedChanged(object sender, EventArgs e)
        {
            if (chart1.Series.IndexOf("Скользящее среднее (окно 7)") >= 0)
                chart1.Series["Скользящее среднее (окно 7)"].Enabled = cbSmooth7.Checked;
        }

        private void cbSmooth11_CheckedChanged(object sender, EventArgs e)
        {
            if (chart1.Series.IndexOf("Скользящее среднее (окно 11)") >= 0)
                chart1.Series["Скользящее среднее (окно 11)"].Enabled = cbSmooth11.Checked;
        }

        private void cbCubic_CheckedChanged(object sender, EventArgs e)
        {
            if (chart1.Series.IndexOf("Локальное сглаживание кубическим МНК") >= 0)
                chart1.Series["Локальное сглаживание кубическим МНК"].Enabled = cbCubic.Checked;
        }

        private void cbQuartic_CheckedChanged(object sender, EventArgs e)
        {
            if (chart1.Series.IndexOf("Глобальный многочлен 4-й степени") >= 0)
                chart1.Series["Глобальный многочлен 4-й степени"].Enabled = cbQuartic.Checked;
        }

        private void ApplyCheckBoxVisibility()
        {
            if (chart1.Series.IndexOf("Исходные точки") >= 0)
                chart1.Series["Исходные точки"].Enabled = cbRaw.Checked;

            if (chart1.Series.IndexOf("Скользящее среднее (окно 7)") >= 0)
                chart1.Series["Скользящее среднее (окно 7)"].Enabled = cbSmooth7.Checked;

            if (chart1.Series.IndexOf("Скользящее среднее (окно 11)") >= 0)
                chart1.Series["Скользящее среднее (окно 11)"].Enabled = cbSmooth11.Checked;

            if (chart1.Series.IndexOf("Локальное сглаживание кубическим МНК") >= 0)
                chart1.Series["Локальное сглаживание кубическим МНК"].Enabled = cbCubic.Checked;

            if (chart1.Series.IndexOf("Глобальный многочлен 4-й степени") >= 0)
                chart1.Series["Глобальный многочлен 4-й степени"].Enabled = cbQuartic.Checked;
        }
        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

    }
}
