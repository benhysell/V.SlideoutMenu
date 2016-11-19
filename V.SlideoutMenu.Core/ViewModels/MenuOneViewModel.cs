// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MenuOneViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace V.SlideoutMenu.Core.ViewModels
{ 
    using MvvmCross.Core.ViewModels;
    using System.Windows.Input;

    /// <summary>
    /// Define the MenuOneViewModel type.
    /// </summary>
    public class MenuOneViewModel : BaseViewModel
    {
        /// <summary>
        /// Backing field for my property.
        /// </summary>
        private string myProperty = "Menu One";

     
        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string MyProperty
        {
            get { return this.myProperty; }
            set { this.SetProperty(ref this.myProperty, value, ()=> this.MyProperty); }
        }

        private MvxCommand showFullScreenViewCommand;

        public MvxCommand ShowFullScreenViewCommand
        {
            get
            {
                showFullScreenViewCommand = showFullScreenViewCommand ?? new MvxCommand(DoShowFullScreenView);
                return showFullScreenViewCommand;
            }
        }

        private void DoShowFullScreenView()
        {
            ShowViewModel<DetailFullScreenViewModel>();
        }

        public override void Start()
        {
            Title = "Menu One Title";
            base.Start();
        }
    }
}

