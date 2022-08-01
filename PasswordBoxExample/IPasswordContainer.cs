using System.Security;

namespace PasswordBoxExample {
    interface IPasswordContainer {
        public SecureString Password { get;}
    }
}
