using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using AvaloniaUI.Ribbon;

namespace Adorer
{
    public partial class MainWindow :RibbonWindow
    {

        private Control? _adorner;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RemoveAdorner_OnClick(object? sender, RoutedEventArgs e)
        {
            var adornerButton = this.FindControl<Button>("AdornerButton");
            if (adornerButton is { })
            {
                var adorner = AdornerLayer.GetAdorner(adornerButton);
                if (adorner is { })
                {
                    _adorner = adorner;
                }
                AdornerLayer.SetAdorner(adornerButton, null);
            }
        }

        private void AddAdorner_OnClick(object? sender, RoutedEventArgs e)
        {
            var adornerButton = this.FindControl<Button>("AdornerButton");
            if (adornerButton is { })
            {
                if (_adorner is { })
                {
                    AdornerLayer.SetAdorner(adornerButton, _adorner);
                }
            }
        }
    }
}