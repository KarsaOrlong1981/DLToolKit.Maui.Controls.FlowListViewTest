using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlowListViewTest
{
    public partial class MainPage : ContentPage
    {
        MainPageModel pageModel;
        public MainPage()
        {
            InitializeComponent();
            pageModel = new MainPageModel(this);
            BindingContext = pageModel;
        }
        //public void FlowScrollTo(object item)
        //{
        //    flowListView.FlowScrollTo(item, ScrollToPosition.MakeVisible, true);
        //}
    }
}
