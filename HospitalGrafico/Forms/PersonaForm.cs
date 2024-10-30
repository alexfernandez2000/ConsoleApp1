using HospitalModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalGrafico.Forms
{
    public partial class PersonaForm<T> : Form where T : Persona, new ()
    {
        private List<T> _dataList;
        private DataGridView dataGridView;

        public PersonaForm(List<T> dataList)
        {
            _dataList = dataList;
            InitializeComponents();
            LoadData();
        }

        private void InitializeComponents()
        {
            this.Text = $"Formulario de {typeof(T).Name}s";
            this.Width = 600;
            this.Height = 400;

            dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true
            };
            this.Controls.Add(dataGridView);

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            var addButton = new Button { Text = "Agregar" };
            addButton.Click += (sender, e) => AddNewItem();

            var removeButton = new Button { Text = "Eliminar" };
            removeButton.Click += (sender, e) => RemoveSelectedItem();

            buttonPanel.Controls.Add(addButton);
            buttonPanel.Controls.Add(removeButton);
            this.Controls.Add(buttonPanel);
        }

        private void LoadData()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _dataList;
        }

        private void AddNewItem()
        {
            var item = new T();
            _dataList.Add(item);
            LoadData();
        }

        private void RemoveSelectedItem()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedIndex = dataGridView.SelectedRows[0].Index;
                _dataList.RemoveAt(selectedIndex);
                LoadData();
            }
        }
    }
}
