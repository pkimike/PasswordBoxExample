using System.Security;
using System.Windows;

namespace PasswordBoxExample.Views.Windows {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IPasswordContainer {
        public MainWindow() {
            InitializeComponent();
        }

        public SecureString Password => PwdEntry.SecurePassword;
    }
}
