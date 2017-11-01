﻿using System.ComponentModel;

namespace Wisej.SimpleDemo.Model
{
    public class Customer : INotifyPropertyChanged
    {
        #region Static Fields

        private static int _lastId;

        #endregion

        #region Business Properties

        private readonly int _customerId;

        public int CustomerId
        {
            get { return _customerId; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value.ToUpper();
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        private States _state;

        public States State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged(nameof(State));
                    OnPropertyChanged(nameof(StateName));
                }
            }
        }

        public string StateName
        {
            get { return _state.GetDescription(); }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
        }

        #endregion

        #region Constructor

        public Customer()
        {
            _customerId = System.Threading.Interlocked.Increment(ref _lastId);
            OnPropertyChanged(nameof(CustomerId));
        }

        #endregion

        public void Save()
        {
            if (!CustomerList.Contains(CustomerId))
                CustomerList.GetCustomerList().Add(this);
        }

        public void Delete()
        {
            if (CustomerList.Contains(CustomerId))
                CustomerList.GetCustomerList().Remove(this);
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}