// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeView.xaml type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Windows;
using System.Windows.Controls;
using V.SlideoutMenu.Core.ViewModels;
using V.SlideoutMenu.Wpf.Utilities;

namespace V.SlideoutMenu.Wpf.Views
{
    /// <summary>
    ///    Defines the HomeView.xaml type.
    /// </summary>

    [Region(Region.SlidingMenu)]
    public partial class HomeView
    {
        private HomeViewModel viewModel;

        public new HomeViewModel ViewModel
        {
            get { return viewModel ?? (viewModel = base.ViewModel as HomeViewModel); }
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="HomeView"/> class.
        /// </summary>
        public HomeView()
        {
            InitializeComponent();
            Loaded += HomeViewLoaded;
        }

        /// <summary>
        /// Once loaded navigate to route management view model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void HomeViewLoaded(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectMenuItemCommand.Execute(ViewModel.MenuItems.FirstOrDefault(x => x.ViewModelType == typeof(MenuOneViewModel)));
            Loaded -= HomeViewLoaded;
        }

        private void SlideOutMenuButtonClick(object sender, RoutedEventArgs e)
        {
            if (Visibility.Collapsed == rect.Visibility)
            {
                rect.Visibility = Visibility.Visible;
                SlideOutMenuButton.Content = "\u25C0\uFE0E";
            }
            else
            {
                HideSlideOutMenu();
            }
        }

        /// <summary>
        /// Hide the slide out menu
        /// </summary>
        private void HideSlideOutMenu()
        {
            rect.Visibility = Visibility.Collapsed;
            SlideOutMenuButton.Content = "\u25B6\uFE0E";
        }

        private void SelectMenuItem(object sender, RoutedEventArgs e)
        {
            var selectedItem = ViewModel.MenuItems.FirstOrDefault(x => x.Title == (string)((Button)sender).Content);
            if (null != selectedItem)
            {
                ViewModel.SelectMenuItemCommand.Execute(selectedItem);
                HideSlideOutMenu();
            }
        }
    }
}

