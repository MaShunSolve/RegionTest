﻿using Prism.Ioc;
using Prism.Unity;
using RegionTest.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace RegionTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            var w = Container.Resolve<MainWindow>();
            return w;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //
        }
    }
}
