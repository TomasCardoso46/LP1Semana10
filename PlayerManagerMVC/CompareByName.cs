using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class CompareByName : IComparer<Player>
    {
        private bool _ascending;

        public CompareByName(bool ascending)
        {
            _ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (_ascending)
            {
                return string.Compare(x.Name, y.Name);
            }
            else
            {
                return string.Compare(y.Name, x.Name);
            }
        }
    }
}
