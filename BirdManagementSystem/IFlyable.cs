using System;
using System.Collections.Generic;
using System.Text;

namespace BirdManagementSystem
{
    internal interface IFlyable
    {
        void CanFly();
    }
    internal interface IRunnable
    {
        void CanRun();

    }
    internal interface ISwimmable
    {
        void CanSwim();

    }
}
