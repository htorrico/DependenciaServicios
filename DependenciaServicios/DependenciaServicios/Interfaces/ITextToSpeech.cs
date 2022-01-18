using System;
using System.Collections.Generic;
using System.Text;

namespace DependenciaServicios.Interfaces
{
    public interface ITextToSpeech
    {
        void Speak(string text);
        void GoodMorning();
    }

}
