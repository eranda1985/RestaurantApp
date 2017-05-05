using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrains.Core.ViewModel
{
    public class SearchMenu : MvxViewModel, IDisposable
    {
        private string _title = "This is initial text";
        private string _cousine = 

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }
        public void Dispose()
        {
            
        }
    }
}
