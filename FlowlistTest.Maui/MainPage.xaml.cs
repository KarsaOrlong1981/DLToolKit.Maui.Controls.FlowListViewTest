using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace FlowlistTest.Maui
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
      
    }
}
