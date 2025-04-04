using System;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FormBienvenida bienvenida = new FormBienvenida())
            {
                if (bienvenida.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormMenu()); // Inicia el menú después de la bienvenida
                }
            }
        }
    }
}