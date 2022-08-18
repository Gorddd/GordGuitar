using System;
using System.Threading;
using System.Windows.Forms;

namespace GordGuitar
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadingForm loadingForm = new LoadingForm();
            //new Thread(() => Application.Run(loadingForm)).Start();

            GameForm gameForm = new GameForm((m) =>
            {
                loadingForm.progressBar.Value += 10;
                loadingForm.message.Text = m;
            });
            loadingForm.Hide();
            gameForm.ShowDialog();
            loadingForm.Close();
        }
    }
}
