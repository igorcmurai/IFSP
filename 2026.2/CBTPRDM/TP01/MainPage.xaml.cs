namespace CBTPRDM_TP01
{
    // CBTPRDM - Trabalho Prático 01
    //
    // Autores:
    // Igor Cerqueira Murai - CB3033295
    // Gustavo Cerqueira Murai - CB3033261

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOkClicked(object? sender, EventArgs e)
        {
            string id = IdEntry.Text ?? string.Empty;
            string senha = SenhaEntry.Text ?? string.Empty;

            if (id == "admin" && senha == "senha@dmin")
            {
                await DisplayAlertAsync(
                    "Login",
                    "Login realizado com sucesso!",
                    "OK");
            }
            else
            {
                await DisplayAlertAsync(
                    "Login",
                    "Login não autorizado.",
                    "OK");
            }
        }

        private void OnLimparClicked(object? sender, EventArgs e)
        {
            IdEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;

            IdEntry.Focus();
        }

        private async void OnCreditosClicked(object? sender, EventArgs e)
        {
            await DisplayAlertAsync(
                "Créditos",
                "Igor Cerqueira Murai - CB3033295\n" +
                "Gustavo Cerqueira Murai - CB3033261",
                "OK");
        }
    }
}