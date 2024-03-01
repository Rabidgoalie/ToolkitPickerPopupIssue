using CommunityToolkit.Maui.Core;
using ToolkitPickerPopupIssue.ViewModels;

namespace ToolkitPickerPopupIssue
{
    public partial class MainPage : ContentPage
    {
        private readonly IPopupService _popupService;

        int count = 0;

        public MainPage(IPopupService popupService)
        {
            InitializeComponent();

            _popupService = popupService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnPopupButtonClickedAsync(object sender, EventArgs e)
        {
            await _popupService.ShowPopupAsync<PickerPopupViewModel>();
        }
    }

}
