using System.Runtime.InteropServices;
using System;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace TP6
{
    internal class Operations
    {
        public double fun(double x, double y)
        {
            return Math.Sqrt(x) / Math.Log(y);
        }
        string myErrors = @"myErrors.log";
        public void GetFunc(string filename, ListBox XListBox, ListBox YListBox, TextBox CoordTextBox)
        {
            int x1 = XListBox.SelectedIndex + 1;
            int y1 = YListBox.SelectedIndex + 1;
            int needbyte = (((x1 - 1) * YListBox.Items.Count * 3) + (3 * y1));
            using (FileStream fstream = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fstream, Encoding.ASCII))
                {
                    if (reader.PeekChar() != -1)
                    {
                        for (int i = 0; i < needbyte - 1; i++)
                        {
                            reader.ReadDouble();
                        }
                        double result = reader.ReadDouble();
                        CoordTextBox.Text = result.ToString();
                    }
                }
            }
        }

        public void ReadXY(string filename, ListBox XListBox, ListBox YListBox)
        {
            XListBox.Items.Clear();
            YListBox.Items.Clear();
            HashSet<double> Xlist = new();
            HashSet<double> Ylist = new();
            double x, y;
            using (FileStream filestr = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(filestr, Encoding.ASCII))
                {
                    while (reader.PeekChar() != -1)
                    {
                        x = reader.ReadDouble();
                        if (!Xlist.Contains(x))
                        {
                            Xlist.Add(x);
                            XListBox.Items.Add(x);
                        }
                        y = reader.ReadDouble();
                        if (!Ylist.Contains(y))
                        {
                            Ylist.Add(y);
                            YListBox.Items.Add(y);
                        }
                        if (reader.PeekChar() != -1)
                        {
                            reader.ReadDouble();
                        }
                    }
                }
            }
        }

        public void Dataset(ListBox FilesListBox, ListBox FunListBox, TrackBar NumOfVarBar)
        {
            try
            {
                FilesListBox.Items.Clear();
                FunListBox.Items.Clear();
                double[,] InitData = InitialData(NumOfVarBar);
                int Nx, Ny;
                double Hy, Y0;
                using (StreamWriter myErrorswriter = new StreamWriter(myErrors, true, Encoding.Default))
                {
                    for (int z = 0; z < NumOfVarBar.Value; z++)
                    {
                        Nx = Convert.ToInt32(InitData[z, 0]);
                        Ny = Convert.ToInt32(InitData[z, 1]);
                        Y0 = InitData[z, 2];
                        Hy = InitData[z, 3];
                        string filename = "G" + (z + 1) + ".dat";

                        //Задаем х
                        double[] x = SetX(Nx);
                        //Задаем у
                        double[] y = SetY(Y0, Hy, Ny);

                        using (FileStream filestr = new FileStream(filename, FileMode.Create))
                        {
                            using (BinaryWriter writer = new BinaryWriter(filestr, Encoding.ASCII))
                            {
                                for (int i = 0; i < x.Length; i++)
                                {
                                    for (int j = 0; j < y.Length; j++)
                                    {
                                        double fx = fun(x[i], y[j]);
                                        writer.Write(x[i]);
                                        writer.Write(y[j]);
                                        //writer.Write(fun(x[i], y[j]));
                                        //FunListBox.Items.Add("G" + (z + 1) + "(" + x[i] + ";" + y[j] + ") = " + fun(x[i], y[j]));
                                        if (double.IsNaN(fx) || double.IsInfinity(fx)) // функция не определена
                                        {
                                            writer.Write(double.NaN);
                                            FunListBox.Items.Add("G" + (z + 1) + "(" + x[i] + ";" + y[j] + ") = " + double.NaN);
                                            myErrorswriter.WriteLine(filename);
                                            myErrorswriter.WriteLine("NaN");
                                            myErrorswriter.WriteLine("x = {0}, y = {1}", x[i], y[j]);
                                            myErrorswriter.WriteLine("Not finite number");
                                            myErrorswriter.WriteLine(" ");
                                        }

                                        else if (y[j] == 1) // условное исключение; значение переменной, при которой происходит деление на ноль
                                        {
                                            writer.Write(double.NaN);
                                            FunListBox.Items.Add("G" + (z + 1) + "(" + x[i] + ";" + y[j] + ") = " + double.NaN);
                                            myErrorswriter.WriteLine(filename);
                                            myErrorswriter.WriteLine("NaN");
                                            myErrorswriter.WriteLine("x = {0}, y = {1}", x[i], y[i]);
                                            myErrorswriter.WriteLine("Divided by zero");
                                            myErrorswriter.WriteLine(" ");
                                        }
                                        else
                                        {
                                            writer.Write(fx);
                                            FunListBox.Items.Add("G" + (z + 1) + "(" + x[i] + ";" + y[j] + ") = " + fx);
                                        }
                                    }
                                }
                            }
                        }
                        FilesListBox.Items.Add(filename);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат", "Ошибка");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Не указаны данные", "Ошибка");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Укажите полный набор данных", "Ошибка");
            }
        }

        public double[] SetY(double Y0, double Hy, int Ny)
        {
            double[] y = new double[Ny];
            for (int i = 0; i < Ny; i++)
            {
                y[i] = Y0 + i * Hy;
            }
            return y;
        }

        public double[] SetX(int Nx)
        {
            Random rand = new Random();
            double[] x = new double[Nx];
            for (int i = 0; i < Nx; i++)
            {
                x[i] = rand.Next(0, 100) * 0.1;
            }
            return x;
        }

        public double[,] InitialData(TrackBar NumOfVarBar)
        {
            double[,] data = new double[NumOfVarBar.Value, 4];
            for (int z = 0; z < NumOfVarBar.Value; z++)
            {
                string filename = "G" + (z + 1) + ".dat";
                string temp = File.ReadLines(filename).Skip(1).First();
                string[] znach = temp.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < 4; i++)
                {
                    data[z, i] = Convert.ToDouble(znach[i]);
                }
            }
            return data;
        }

        public void CreateDefaultFile(TrackBar NumOfVarBar, ListBox FunListBox, ListBox FilesListBox, ListBox XListBox, ListBox YListBox, TextBox CoordTextBox)
        {
            for (int z = 0; z < NumOfVarBar.Value; z++)
            {
                string filename = "G" + (z + 1) + ".dat";
                File.WriteAllText(filename, string.Empty);
                string info = "Для работы программы укажите через пробел на следующей строке: Nx, Ny, Y0, Hy";
                using (StreamWriter sr = new StreamWriter(filename))
                {
                    sr.WriteLine(info);
                }
            }
            FunListBox.Items.Clear();
            FilesListBox.Items.Clear();
            XListBox.Items.Clear();
            YListBox.Items.Clear();
            CoordTextBox.Clear();
        }
    }
}
