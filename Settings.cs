using System;
using System.Collections.Generic;
using System.Linq;

namespace Caffeinated.Properties {
    internal sealed partial class Settings {
        private IList<int> realDurations;
        public IList<int> RealDurations { 
            get {
                if (realDurations == null) {
                    realDurations = Durations.Split(',')
                                             .Select(s => Convert.ToInt32(s))
                                             .ToList();
                }
                return realDurations;
            }
            set {
                this.realDurations = value;
                var strDurations = value.Select(s => s.ToString()).ToArray();
                this.Durations = string.Join(",", strDurations);
            }
        }
    }
}
