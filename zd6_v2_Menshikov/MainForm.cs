using System;
using System.Windows.Forms;

namespace zd6_v2_Menshikov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listBoxRoadWorks.HorizontalScrollbar = true;
        }

        private void btnAddRoadWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtWidth.Text, out double width) ||
                    !double.TryParse(txtLength.Text, out double length) ||
                    !double.TryParse(txtMassPerSquareMeter.Text, out double massPerSquareMeter))
                {
                    MessageBox.Show("Пожалуйста, введите корректные числовые значения для ширины, длины и массы на кв. метр.");
                    return;
                }

                string material = txtMaterial.Text;
                string contractor = txtContractor.Text;

                if (string.IsNullOrEmpty(txtStrengthCoefficient.Text))
                {
                    RoadWork roadWork = new RoadWork(width, length, massPerSquareMeter, material, contractor);
                    RoadWorkManager.AddRoadWork(roadWork);
                }
                else
                {
                    if (!int.TryParse(txtStrengthCoefficient.Text, out int strengthCoefficient))
                    {
                        MessageBox.Show("Пожалуйста, введите корректное значение для коэффициента прочности.");
                        return;
                    }

                    string weatherCondition = txtWeatherCondition.Text;
                    string supervisor = txtSupervisor.Text;
                    DateTime completionDate = dateTimePickerCompletionDate.Value;

                    AdvancedRoadWork advancedRoadWork = new AdvancedRoadWork(width, length, massPerSquareMeter, material, contractor, strengthCoefficient, weatherCondition, supervisor, completionDate);
                    RoadWorkManager.AddRoadWork(advancedRoadWork);
                }

                UpdateRoadWorksList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnDisplayRoadWorks_Click(object sender, EventArgs e)
        {
            UpdateRoadWorksList();
        }

        private void UpdateRoadWorksList()
        {
            listBoxRoadWorks.Items.Clear();
            foreach (var roadWork in RoadWorkManager.RoadWorks)
            {
                listBoxRoadWorks.Items.Add(roadWork.ToString());
            }
        }

        private void btnRemoveRoadWork_Click(object sender, EventArgs e)
        {
            if (listBoxRoadWorks.SelectedItem != null)
            {
                string selectedItem = listBoxRoadWorks.SelectedItem.ToString();
                string key = selectedItem.Split(':')[0].Trim();
                RoadWorkManager.RemoveRoadWork(key);
                UpdateRoadWorksList();
            }
        }
    }
}
