﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using System.Diagnostics;
using Microsoft_Band_Simulator.SettingControls;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media.Animation;
using Microsoft_Band_Simulator;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Band_Simulator.SettingControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Setting6 : Page
    {
        public Setting6()
        {
            this.InitializeComponent();
            // Setting color properties
            Application.Current.Resources["ToggleButtonBackgroundChecked"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPointerOver"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ToggleButtonBackgroundCheckedPressed"] = new SolidColorBrush(devtheme);
            Application.Current.Resources["ComboBoxBackgroundPointerOver"] = new SolidColorBrush(Color.FromArgb(255, 102, 102, 102));    
        }

        // Public variables
        public static Color devtheme;
        public static string sysname;
        public static string bandname;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingApp), null, new SuppressNavigationTransitionInfo());
        }

        private void Setting6view_Loaded(object sender, RoutedEventArgs e)
        {
            Setting6Sidebar.Fill = new SolidColorBrush(devtheme);
            SysLabel.Foreground = new SolidColorBrush(devtheme);
            SysNameText.Text = sysname;
            BandNameLabel.Foreground = new SolidColorBrush(devtheme);
            BandName.Text = bandname;
            Serial.Foreground = new SolidColorBrush(devtheme);
            BuildLabel.Foreground = new SolidColorBrush(devtheme);
        }
    }
}
