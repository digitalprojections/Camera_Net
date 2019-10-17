using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camera_NET
{
    public class FPS : IComparable<FPS>, IEquatable<FPS>
    {
        /// Additions of new features or corrections
        /// <author> digitalprojects (fuzalov@gmail.com)</author>
        /// <version>2019.10.16</version>        
        
        /// <summary>
        /// AvgFrameRate for <see cref="Camera"/>
        /// </summary>
        public long AvgFramesPerSec { set; get; }

        public FPS(long fps) { AvgFramesPerSec = fps; }

        public int ToggleValue(int x)
        {
            int retval = 10000000 / x;
            return retval;
        }

        public int CompareTo(FPS y)
        {
            FPS x = this;

            if (x == null)
            {
                if (y == null)
                    return 0; // If x is null and y is null, they're equal. 
                else
                    return -1; // If x is null and y is not null, y is greater. 
            }
            else
            {
                // If x is not null and y is null, x is greater.
                if (y == null)
                    return 1;
            }

            // Main comparison
            // x and y are not null
            if (x.AvgFramesPerSec > y.AvgFramesPerSec)
                return 1;
            else
            if (x.AvgFramesPerSec < y.AvgFramesPerSec)
                return -1;
            else
                return x.AvgFramesPerSec.CompareTo(y.AvgFramesPerSec);  //x.AvgFramesPerSec == y.AvgFramesPerSec
        }

        public bool Equals(FPS other)
        {
            if (other == null)
                return false;

            if (this.AvgFramesPerSec != other.AvgFramesPerSec)
                return false;

            return true;
        }
    }
}
