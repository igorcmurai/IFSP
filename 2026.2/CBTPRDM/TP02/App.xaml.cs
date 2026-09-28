// TP02 - CBTPRDM
// Igor Cerqueira Murai - CB3033295
// Gustavo Cerqueira Murai - CB3033261

using Microsoft.Extensions.DependencyInjection;

namespace TarefasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}