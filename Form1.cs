using System.Text;

namespace TP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operations ops = new Operations();

        private void NumOfVarBar_Scroll(object sender, EventArgs e)
        {
            NumOfVarLabel.Text = NumOfVarBar.Value.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < NumOfVarBar.Value; i++)
            {
                if (!File.Exists("G" + (i + 1) + ".dat"))
                {
                    MessageBox.Show("Файл " + "G" + (i + 1) + ".dat" + " не найден", "Ошибка");
                    break;
                }
            }
            if (i == NumOfVarBar.Value) { ops.Dataset(FilesListBox, FunListBox, NumOfVarBar); }
            
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Необходимо выбрать файл для считывания координат", "Ошибка");
            }
            else { ops.ReadXY(FilesListBox.SelectedItem.ToString(), XListBox, YListBox); }
        }

        private void GetFuncButton_Click(object sender, EventArgs e)
        {
            if ((FilesListBox.SelectedItems.Count == 0) || (XListBox.SelectedItems.Count == 0) || (YListBox.SelectedItems.Count == 0))
            {
                MessageBox.Show("Необходимо выбрать координаты и файл для считывания", "Ошибка");
            }
            else
            {
                ops.GetFunc(FilesListBox.SelectedItem.ToString(), XListBox, YListBox, CoordTextBox);
                XListBox.ClearSelected();
                YListBox.ClearSelected();
                FilesListBox.ClearSelected();
            }
        }

        private void RewriteButton_Click(object sender, EventArgs e)
        {
            ops.CreateDefaultFile(NumOfVarBar, FunListBox, FilesListBox, XListBox, YListBox, CoordTextBox);
        }
    }
}