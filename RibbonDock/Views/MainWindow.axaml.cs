using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using AvaloniaUI.Ribbon;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace RibbonDock.Views
{
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            //Button verticalRibbonButton = this.Find<Button>("VerticalRibbonButton");
            //Button horizontalRibbonButton = this.Find<Button>("HorizontalRibbonButton");
         
            //verticalRibbonButton.Click += (sneder, args) =>
            //{this.Find<Button>("VerticalRibbonButton");

            //    Orientation = Avalonia.Layout.Orientation.Horizontal;
            //    this.Ribbon.Orientation = Orientation;

            //   // DockPanel.SetDock(this.Ribbon, Dock.Left);
            //    Orientation = Avalonia.Layout.Orientation.Vertical;
            //    verticalRibbonButton.IsVisible = false;
            //    horizontalRibbonButton.IsVisible = true;
            //    //

            //};
            //horizontalRibbonButton.Click += (sneder, args) =>
            //{
            //    /*ribbon.Orientation = Orientation.Horizontal;
            //    DockPanel.SetDock(ribbon, Dock.Top);*/
            //    Orientation = Avalonia.Layout.Orientation.Horizontal;
            //    horizontalRibbonButton.IsVisible = false;
            //    verticalRibbonButton.IsVisible = true;
            //};
            //this.Find<Button>("TestItemsButton").Click += (sneder, args) => this.Find<QuickAccessToolbar>("QAT").TestItems();

            //  var lightsToggleSwitch = this.Find<ToggleSwitch>("LightsToggleSwitch");
        }

        private void MainWindow_Loaded(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            //似乎有个bug,这样会刷新
            WindowState = WindowState.Normal;
            AdornerLayer layer = AdornerLayer.GetAdornerLayer(MainView);
            if (layer == null)
            {

                Console.WriteLine("Hello World!");

            }

         

        }

        
    }
}