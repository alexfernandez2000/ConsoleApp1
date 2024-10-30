using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

public class PersonaForm<T> : Form where T : Persona, new()
{
    private T _currentItem; // El objeto que se editará o creará
    private Dictionary<PropertyInfo, Control> _controlMap; // Mapa de propiedades y sus controles
    private FlowLayoutPanel _formPanel;

    public T Result { get; private set; } // Propiedad para devolver el objeto al finalizar
    public bool Success { get; private set; }
    // Constructor para crear un nuevo objeto
    public PersonaForm() : this(new T()) { }

    // Constructor que recibe un objeto existente
    public PersonaForm(T item)
    {
        Success = false;
        _currentItem = item;
        _controlMap = new Dictionary<PropertyInfo, Control>();
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = $"Formulario de {typeof(T).Name}";
        this.Width = 400;
        this.Height = 300;

        _formPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            AutoScroll = true
        };

        CreateInputFields();
        this.Controls.Add(_formPanel);

        var buttonPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Bottom,
            Height = 40,
            FlowDirection = FlowDirection.RightToLeft
        };

        var saveButton = new Button { Text = "Guardar" };
        saveButton.Click += (sender, e) => SaveItem();

        var cancelButton = new Button { Text = "Cancelar" };
        cancelButton.Click += (sender, e) => this.Close();

        buttonPanel.Controls.Add(saveButton);
        buttonPanel.Controls.Add(cancelButton);
        this.Controls.Add(buttonPanel);
    }

    private void CreateInputFields()
    {
        foreach (var property in typeof(T).GetProperties())
        {
            if (typeof(System.Collections.IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
            {
                continue;
            }

            var label = new Label { Text = property.Name, Width = 100 };
            Control control;

            if (property.PropertyType == typeof(int) || property.PropertyType == typeof(float) || property.PropertyType == typeof(double) || property.PropertyType == typeof(decimal))
            {
                var numericUpDown = new NumericUpDown
                {
                    Width = 200,
                    DecimalPlaces = property.PropertyType == typeof(int) ? 0 : 2,
                    Minimum = 0,
                    Maximum = 1000
                };
                control = numericUpDown;
            }
            else
            {
                control = new TextBox { Width = 200 };
            }

            var fieldPanel = new FlowLayoutPanel { Width = 320, Height = 30 };
            fieldPanel.Controls.Add(label);
            fieldPanel.Controls.Add(control);

            _formPanel.Controls.Add(fieldPanel);

            _controlMap[property] = control;

            if (property.GetValue(_currentItem) != null)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = Convert.ToDecimal(property.GetValue(_currentItem));
                }
                else
                {
                    control.Text = property.GetValue(_currentItem)?.ToString();
                }
            }
        }
    }

    private void SaveItem()
    {
        // Actualizar el objeto actual con los valores de los controles
        foreach (var entry in _controlMap)
        {
            var property = entry.Key;
            var control = entry.Value;

            object value = null;

            // Obtener el valor del control, según el tipo de propiedad
            if (property.PropertyType == typeof(int))
            {
                value = (int)((NumericUpDown)control).Value;
            }
            else if (property.PropertyType == typeof(float))
            {
                value = (float)((NumericUpDown)control).Value;
            }
            else if (property.PropertyType == typeof(double))
            {
                value = (double)((NumericUpDown)control).Value;
            }
            else if (property.PropertyType == typeof(decimal))
            {
                value = ((NumericUpDown)control).Value;
            }
            else
            {
                value = control.Text;
            }

            property.SetValue(_currentItem, value);
        }

        Result = _currentItem;
        //MessageBox.Show($"{typeof(T).Name} guardado con éxito.");
        Success = true;
        this.Close();
    }
}
