using CommunityToolkit.Maui.Views;
using ToolkitPickerPopupIssue.ViewModels;

namespace ToolkitPickerPopupIssue.Popups;

public partial class PickerPopup : Popup
{
	public PickerPopup(PickerPopupViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;

		/*
		var optionsList = new List<string>();
		optionsList.Add("First Option");
		optionsList.Add("Another Option");
		optionsList.Add("Last option");

		CodeBehindPicker.ItemsSource = optionsList;
		// */
	}

    async void OnDismissButtonClicked(object sender, EventArgs e) => await CloseAsync();
}