using System;

namespace Adapter
{
    public interface MovableAdapter
    {
        double GetSpeed(); // returns speed in KPH

        double GetPrice(); // returns price in euro
    }
}
