using System;

namespace notas.api01.Models
{
    public class MsgErros : Exception
    {
        public MsgErros()
        {
                
        }

        public MsgErros(string message) : base(message)
        {

        } 
    }
}
