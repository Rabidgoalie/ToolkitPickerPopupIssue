using CommunityToolkit.Maui.Views;
using ToolkitPickerPopupIssue.ViewModels;
using UIKit;

namespace ToolkitPickerPopupIssue.Popups;

public partial class PickerPopup : Popup
{
	public PickerPopup(PickerPopupViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;

		/*
		var optionsList = new List<string>();
		optionsList.Add("First CB Option");
		optionsList.Add("Another CB Option");
		optionsList.Add("Last CB option");

		CodeBehindPicker.ItemsSource = optionsList;
		// */
	}

    async void OnDismissButtonClicked(object sender, EventArgs e) => await CloseAsync();

	// Added to allow a break point to be set, to observe the picker's ItemsSource member.
	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();

		_ = CodeBehindPicker;
	}
}