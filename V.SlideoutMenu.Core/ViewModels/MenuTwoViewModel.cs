// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MenuTwoViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.SlideoutMenu.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the MenuTwoViewModel type.
    /// </summary>
    public class MenuTwoViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string myProperty = "Menu Two";


        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string MyProperty
        {
            get { return this.myProperty; }
            set { this.SetProperty(ref this.myProperty, value, ()=> this.MyProperty); }
        }

        public override void Start()
        {
            Title = "Menu Two Title";
            base.Start();
        }

    }
}

