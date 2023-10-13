# How to show the calendar agenda view events using SfDataGrid in Xamarin.Forms?

This example demonstrates to show calendar agenda view events using SfDataGrid.

See [How to show the calendar agenda view events using SfDataGrid in Xamarin.Forms](https://www.syncfusion.com/kb/10323/how-to-show-the-calendar-agenda-view-events-using-sfdatagrid-in-xamarin-forms) for more details.

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| Android   | API level 21 and later versions |
| iOS | iOS 9.0 and later versions |
| UWP | Windows 10 devices |

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*
   
2. Register your license key in the App.xaml.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
	
			InitializeComponent();
	
			MainPage = new App1.MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/xamarin/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples. 