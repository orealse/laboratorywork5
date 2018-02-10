using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class CarlsDeadException : ApplicationException
    {
        public DateTime ErrorTimeStamp
        {
            get;
            set;
        }
        public string CauseOfError
        {
            get;
            set;
        }
        public CarlsDeadException() { }

        // Передача сообщения конструктору родительского класса.
        public CarlsDeadException(string message,
            string cause, DateTime time)
            :base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        /* Переопределение свойства Exception.Message.
        public override string Message
        {
            get
            {
                return string.Format("Car Error Message: {0}", messageDetails);
            }
        }*/
    }
}
