// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the HomeViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace V.SlideoutMenu.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the HomeViewModel type.
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        private List<MenuViewModel> menuItems;
        /// <summary>
        /// List of menu items
        /// </summary>
        public List<MenuViewModel> MenuItems
        {
            get { return menuItems; }
            set { if (menuItems == value) return; menuItems = value; RaisePropertyChanged(() => MenuItems); }
        }


        public HomeViewModel()
        {
            menuItems = new List<MenuViewModel>
            {
                new MenuViewModel()
                {
                    Section = SlidingMenuItems.MenuOne,
                    Title = "Menu One",
                    ViewModelType = typeof(MenuOneViewModel)
                },
                new MenuViewModel()
                {
                    Section = SlidingMenuItems.MenuTwo,
                    Title = "Menu Two",
                    ViewModelType = typeof(MenuTwoViewModel)
                },
                new MenuViewModel()
                {
                    Section = SlidingMenuItems.MenuThree,
                    Title = "Menu Three",
                    ViewModelType = typeof(MenuThreeViewModel)
                }
            };
        }

        private MvxCommand<MenuViewModel> selectMenuItemCommand;
        /// <summary>
        /// Item selected from sliding menu
        /// </summary>
        public MvxCommand<MenuViewModel> SelectMenuItemCommand
        {
            get
            {
                selectMenuItemCommand = selectMenuItemCommand ?? new MvxCommand<MenuViewModel>(DoSelectMenuItem);
                return selectMenuItemCommand;
            }
        }

        /// <summary>
        /// Show the proper view model from the list
        /// </summary>
        /// <param name="item"></param>
        public void DoSelectMenuItem(MenuViewModel item)
        {

            ShowViewModel(item.ViewModelType);            
        }
    }
}

