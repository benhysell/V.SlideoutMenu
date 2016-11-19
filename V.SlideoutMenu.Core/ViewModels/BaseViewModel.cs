// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the BaseViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.SlideoutMenu.Core.ViewModels
{
    using MvvmCross.Core.ViewModels;
    using System;
    using System.Linq.Expressions;

    /// <summary>
    ///    Defines the BaseViewModel type.
    /// </summary>
    public abstract class BaseViewModel : MvxViewModel
    {

        private long id;

        /// <summary>
        /// Get or sets the unique ID for the menu
        /// </summary>
        public long Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(() => Id); }
        }

        private string title = string.Empty;
        /// <summary>
        /// Title property
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(() => Title); }
        }

        /// <summary>
        /// Checks if a property already matches a desired value.  Sets the property and
        /// notifies listeners only when necessary.
        /// </summary>
        /// <typeparam name="T">Type of the property.</typeparam>
        /// <param name="backingStore">Reference to a property with both getter and setter.</param>
        /// <param name="value">Desired value for the property.</param>
        /// <param name="property">The property.</param>
        protected void SetProperty<T>(
            ref T backingStore,
            T value,
            Expression<Func<T>> property)
        {
            if (Equals(backingStore, value))
            {
                return;
            }

            backingStore = value;

            this.RaisePropertyChanged(property);
        }
    }
}
