using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ToDoList.Models
{
    class ToDoModels : INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _IsDone;
        private string _text;

       

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsDone
        {
            get { return _IsDone; }
            set
            {
                if (_IsDone == value)
                    return;
                _IsDone = value;

                    OnPropertyChanged("IsDone");
                
            
            }
        }

        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                {
                    _text = value;
                    OnPropertyChanged("Text");
                }
                
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
           
                
        }
    }

   

}
