﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioWorker.Interfaces
{
    public interface IPlayable
    {
        void Play();
        void Stop();
        void Pause();
    }
}
