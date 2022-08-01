using System;
using System.Windows;
using System.Windows.Input;
using SysadminsLV.WPF.OfficeTheme.Toolkit.Commands;

namespace PasswordBoxExample.ViewModels {
    class MainWindowViewModel {
        public MainWindowViewModel() {
            CheckLengthCommand = new RelayCommand(checkLength);
        }
        public ICommand CheckLengthCommand { get;}

        void checkLength(Object o) {
            var encryptedPassword = (o as IPasswordContainer)?.Password;
            MessageBox.Show($"Password Length: {encryptedPassword?.Length ?? 0}");
        }
    }
}
