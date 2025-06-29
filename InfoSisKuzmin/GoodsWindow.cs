using CarSystem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarSystem
{
    public partial class GoodsWindow : Form
    {
        private DatabaseContext _dbContext;
        public GoodsWindow()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();

            Column.Items.Add("TripId");
            Column.Items.Add("RouteId");
            Column.Items.Add("VehicleId");
            Column.Items.Add("DriverId");
            Column.Items.Add("ClientId");
            Column.Items.Add("StartDate");
            Column.Items.Add("EndDate");
            Column.Items.Add("CargoDescription");
            Column.Items.Add("CargoWeight");
            Column.Items.Add("Status");
            Column.Items.Add("Cost");
        }

        private void LoadGoodsToGrid()
        {
            try
            {
                var trips = _dbContext.trips.ToList();
                dataGridView1.DataSource = trips;
                dataGridView1.Columns["TripId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке пользователей: " + ex.Message);
            }
        }

        private void GoodsWindow_Load(object sender, EventArgs e)
        {
            LoadGoodsToGrid();
        }


        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = Search.Text.ToLower();
            string selectedColumn = Column.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchText) || string.IsNullOrEmpty(selectedColumn))
            {
                MessageBox.Show("Пожалуйста, выберите столбец и введите текст для поиска.");
                return;
            }
            if (dataGridView1.Columns[selectedColumn] == null)
            {
                MessageBox.Show($"Столбец '{selectedColumn}' не найден в DataGridView.");
                return;
            }

            var filteredGoods = new BindingList<Trips>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[selectedColumn].Value != null &&
                    row.Cells[selectedColumn].Value.ToString().ToLower().Contains(searchText))
                {
                    filteredGoods.Add((Trips)row.DataBoundItem);
                }
            }

            dataGridView1.DataSource = filteredGoods;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите поездку для удаления.");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранную поездку?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var selectedTrip = (Trips)dataGridView1.SelectedRows[0].DataBoundItem;

                    _dbContext.trips.Remove(selectedTrip);
                    _dbContext.SaveChanges();

                    LoadGoodsToGrid();

                    MessageBox.Show("Поездка успешно удалена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении поездки: {ex.Message}");
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newTrip = new Trips
                {
                    RouteId = 1,
                    VehicleId = 1,
                    DriverId = 1,
                    ClientId = 1,
                    StartDate = DateTime.UtcNow,
                    EndDate = null,
                    CargoDescription = "Новый груз",
                    CargoWeight = 1.0m,
                    Status = "Новая",
                    Cost = 100.0m
                };

                _dbContext.trips.Add(newTrip);

                int changes = _dbContext.SaveChanges();

                if (changes > 0)
                {
                    LoadGoodsToGrid();

                    var newRow = dataGridView1.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => ((Trips)r.DataBoundItem).TripId == newTrip.TripId);

                    if (newRow != null)
                    {
                        dataGridView1.CurrentCell = newRow.Cells[1];
                        newRow.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = newRow.Index;
                    }

                    MessageBox.Show("Новая поездка успешно добавлена!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось добавить новую поездку.", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException dbEx)
            {
                string errorMessage = "Ошибка базы данных: ";
                var innerException = dbEx.InnerException;
                while (innerException != null)
                {
                    errorMessage += innerException.Message + Environment.NewLine;
                    innerException = innerException.InnerException;
                }

                MessageBox.Show(errorMessage, "Ошибка базы данных",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении поездки: {ex.Message}\n\nДетали: {ex.StackTrace}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите поездку для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var selectedTrip = (Trips)dataGridView1.SelectedRows[0].DataBoundItem;

                dataGridView1.ReadOnly = false;
                dataGridView1.BeginEdit(true);

                dataGridView1.CurrentCellChanged += (s, ev) =>
                {
                    if (dataGridView1.IsCurrentCellDirty)
                    {
                        dataGridView1.EndEdit();
                    }
                };

                dataGridView1.CellEndEdit += (s, ev) =>
                {
                    try
                    {
                        var updatedTrip = (Trips)dataGridView1.Rows[ev.RowIndex].DataBoundItem;

                        var originalTrip = _dbContext.trips.AsNoTracking().FirstOrDefault(t => t.TripId == updatedTrip.TripId);
                        if (originalTrip != null)
                        {
                            _dbContext.Entry(updatedTrip).State = EntityState.Modified;
                            _dbContext.SaveChanges();

                            MessageBox.Show("Изменения успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadGoodsToGrid();
                    }
                    finally
                    {
                        dataGridView1.ReadOnly = true;
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании поездки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
