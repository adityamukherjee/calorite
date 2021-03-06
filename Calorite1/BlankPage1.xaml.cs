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
using Windows.UI.Xaml.Navigation;
using System.Windows;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Calorite1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private async void button_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page4));
            Button btn = sender as Button;
            UserStatic.WeightGoal = btn.Content.ToString();
            WeightGoal wg = new WeightGoal { Text = btn.Content.ToString() };
            await App.MobileService.GetTable<WeightGoal>().InsertAsync(wg);
        }

        private async void button_Click2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page4));
            Button btn = sender as Button;
            UserStatic.WeightGoal = btn.Content.ToString();
            WeightGoal wg = new WeightGoal { Text = btn.Content.ToString() };
            await App.MobileService.GetTable<WeightGoal>().InsertAsync(wg);
        }

        private async void button_Click3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page4));
            Button btn = sender as Button;
            UserStatic.WeightGoal = btn.Content.ToString();
            WeightGoal wg = new WeightGoal { Text = btn.Content.ToString() };
            await App.MobileService.GetTable<WeightGoal>().InsertAsync(wg);
        }



    }
}
