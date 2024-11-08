using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using EmployeesForm.Model;
using EmployeesForm.Model.BBDDConection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesForm
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var serviceProvider = new ServiceCollection()
                .AddScoped<IDalJob, DalJob>()
                .AddScoped<IDalEmploye, DalEmploye>()
                .AddScoped<IDalDepartment, DalDepartment>()
                .BuildServiceProvider();
            Application.Run(new StarterForm());
        }
    }
}
