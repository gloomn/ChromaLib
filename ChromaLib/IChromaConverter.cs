using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib
{
    public interface IChromaConverter<TInput, TOutput>
    {
        TOutput Convert(TInput input);
    }
}
