using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace MultiTerminal
{
    public class UIThread : INotifyPropertyChanged
    {
        private object _lock;

        public int myProperty;
    
        public event PropertyChangedEventHandler PropertyChanged;
    }

    class Global
    {
        public static string globalVar;

    }
}
