using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camera_NET
{
    /// <summary>
    /// FPSList class for <see cref="Camera"/>.
    /// </summary>
    /// <remarks>This class is inherited from List<FPS> class.</remarks>
    /// 
    /// Additions of new features or corrections
    /// <author> digitalprojects (fuzalov@gmail.com)</author>
    /// <version>2019.10.16</version>
    
    public class FPSList : List<FPS>
    {
        /// <summary>
        /// Adds fps to the collection if it doesn't already exist in it
        /// </summary>
        /// <param name="item">FPS should be added if it's new.</param>
        /// <returns>True if was added, False otherwise</returns>
        public bool AddIfNew(FPS item)
        {
            if (this.Contains(item))
                return false;

            this.Add(item);
            return true;
        }
    }
}
