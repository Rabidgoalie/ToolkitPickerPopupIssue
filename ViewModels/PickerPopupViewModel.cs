using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToolkitPickerPopupIssue.ViewModels;

public partial class PickerPopupViewModel : ObservableObject
{
    [ObservableProperty]
    List<string> _pickerItems;

    public PickerPopupViewModel()
    {
        _pickerItems = new List<string>();

        PickerItems.Add("First Option");
        PickerItems.Add("Another Option");
        PickerItems.Add("Last Option");
    }
}
