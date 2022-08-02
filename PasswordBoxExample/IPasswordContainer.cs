using System;
using System.Security;

namespace PasswordBoxExample {
    interface IPasswordContainer : IDisposable {
        public SecureString Password { get;}
    }
}
