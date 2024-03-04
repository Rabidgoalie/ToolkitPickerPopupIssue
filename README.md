# Overview
The issue that this repo is meant to reproduce is observed when a user displays the popup from the main page, attempts to select an option from the Picker view, and no response is seen from the Picker. There is no list of options presented to the user. From the user's point of view, it appears that the Picker is ignoring the clicked event (but, this is supposition on my part...I don't know if the event is being fired or not).

**_This issue is only observed in MacCatalyst, and doesn't manifest on the other three major platforms (Android, iOS, and Windows are all working fine)._**

## Diagnostic Efforts Performed
Code has been added to set the Picker's `ItemsSource` via code-behind, XAML definitions, and through data-binding to a view model. Commenting/Uncommenting the relevant XAML markup (and the `List<string>` initialization in the case of the code-behind) will allow for each approach to be tested.

The `OnBindingContextChanged()` method for the Popup has been overridden to allow a breakpoint to be set and the code to be stepped through. In the method, a discard is set with the Picker view so that the Picker's members can be read during debugging. In all three `ItemsSource` initialization approaches, the data **_is_** set before the popup is finally displayed. So, while the Picker is acting as if it doesn't have data to display, it in fact does.

A Picker is added to the main page to demonstrate that the Picker view itself doesn't seem to be the cause of the problem. The main page's Picker has it's `ItemsSource` set via XAML, and when clicked on, it displays a list of options to chose from.

## System Information
* Test Device: Mac Mini M1
* OS version: Sonoma 14.3.1
* Xcode version: 15.2
* VSCode version: 1.87.0 (Universal)
* CommunityToolkit.Maui version: 7.0.1
* CommunityToolkit.Mvvm version: 8.2.2
* iOS Simulator: iPhone 15
* Build configuration: Debug and Release
