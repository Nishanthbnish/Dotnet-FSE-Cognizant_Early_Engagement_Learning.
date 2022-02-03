using System;
using System.Collections.Generic;

namespace Builder
{
    class Package
    {
        private int _noOfSweets;
        private int _noOfSavories;

        public Package()
        {
            _noOfSweets = 0;
            _noOfSavories = 0;
        }

        public void AddSweet(int count)
        {
            _noOfSweets += count;
        }

        public void AddSavory(int count)
        {
            _noOfSavories += count;
        }

        public void Show()
        {
            Console.WriteLine($"Package contains {_noOfSweets} Sweets and {_noOfSavories} Savories");
        }
    }
}