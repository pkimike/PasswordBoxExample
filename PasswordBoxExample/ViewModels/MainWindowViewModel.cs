using System;
using System.Windows;
using System.Windows.Input;

namespace PasswordBoxExample.ViewModels {
    class MainWindowViewModel {
        public MainWindowViewModel() {
            CheckPasswordLengthCommand = new RelayCommand(checkPasswordLength);
        }
        public ICommand CheckPasswordLengthCommand { get;}

        void checkPasswordLength(Object o) {
            var securePassword = (o as IPasswordContainer)?.Password;
            MessageBox.Show($"Password Length: {securePassword?.Length ?? 0}");
        }
    }
}
