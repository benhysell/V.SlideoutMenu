using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.SlideoutMenu.Core.ViewModels
{
    public enum SlidingMenuItems
    {
        Unknown,
        MenuOne,
        MenuTwo,
        MenuThree,       
    }

    public class MenuViewModel : BaseViewModel
    {
        private SlidingMenuItems section;

        public SlidingMenuItems Section
        {
            get { return section; }
            set
            {
                section = value;
                Id = (int)section;
                RaisePropertyChanged(() => Section);
            }
        }

        public Type ViewModelType;
    }
}
