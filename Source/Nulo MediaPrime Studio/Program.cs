using Nulo.Modules.WorkspaceManager;
using Nulo.Pages;

namespace Nulo {

    internal static class Program {
        public static WorkspaceManager<WorkspaceTheme, WorkspaceData> WorkspaceManager;

        [STAThread]
        private static void Main() {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            ///Inicia a tela SplashScreen
            //Abre o formulário de apresentação
            var splashScreen = new SplashScreen();
            splashScreen.Show();
            //Atualizar tela.
            Application.DoEvents();
            Thread.Sleep(5000);

            WorkspaceManager = new WorkspaceManager<WorkspaceTheme, WorkspaceData>();

            ///Finaliza a tela SplashScreen
            splashScreen.Dispose();

            Application.Run(new MainPage());
        }
    }
}