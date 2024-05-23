using System;

namespace Course.Entities.Exceptions {

    class MovimentationException : ApplicationException {
        

        public MovimentationException(string message) : base(message) {
        }
    }
}