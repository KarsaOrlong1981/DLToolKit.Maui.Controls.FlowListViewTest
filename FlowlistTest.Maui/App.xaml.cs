using DLToolkit.Maui.Controls.FlowListView;

namespace FlowlistTest.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            MainPage = new AppShell();
        }
    }
}