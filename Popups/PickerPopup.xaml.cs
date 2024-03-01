using CommunityToolkit.Maui.Views;
using ToolkitPickerPopupIssue.ViewModels;

namespace ToolkitPickerPopupIssue.Popups;

public partial class PickerPopup : Popup
{
	public PickerPopup(PickerPopupViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

    async void OnDismissButtonClicked(object sender, EventArgs e) => await CloseAsync();
}