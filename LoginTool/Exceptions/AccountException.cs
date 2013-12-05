using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginTool.Exceptions
{
    [Serializable()]
    class AccountException : System.Exception
    {
        public AccountException() : base() { }
        public AccountException(string msg) : base(msg) { }
        public AccountException(string msg, System.Exception inner) : base(msg, inner) { }

        protected AccountException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }

    }
}
