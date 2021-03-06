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
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IntervalTimer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NumberBoxWorkSeconds_ValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
        {
            if(args.NewValue == 60)
            {
                sender.Value = 0;
                numberBoxWorkMinutes.Value += 1;
            }
        }

        private void NumberBoxRestSeconds_ValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
        {
            if (args.NewValue == 60)
            {
                sender.Value = 0;
                numberBoxRestMinutes.Value += 1;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TrainTimerPage));
        }
    }
}