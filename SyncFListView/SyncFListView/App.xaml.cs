using Syncfusion.ListView.XForms;
using Xamarin.Forms;

namespace SyncFListView
{
	public partial class App : Application
	{
		public App ()
		{
		    SfListView listView;

			InitializeComponent();

            listView =new SfListView();
			//MainPage = new SyncFListView.MainPage();
            MainPage=new ContentPage{Content =listView};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
