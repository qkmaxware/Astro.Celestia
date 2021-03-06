using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
    
    private static List<DeepSkyObject> _NGC = null; 
    public static IEnumerable<DeepSkyObject> NGC{
        get {
            if (_NGC == null) {
                _NGC = new List<DeepSkyObject>(13226);
                _rebuildNGC();
            }
            return _NGC.AsReadOnly();
        }
    }
    
    private static void _rebuildNGC() {
_addNGC_0();
_addNGC_1();
_addNGC_2();
_addNGC_3();
_addNGC_4();
_addNGC_5();
_addNGC_6();
_addNGC_7();
_addNGC_8();
_addNGC_9();
_addNGC_10();
_addNGC_11();
_addNGC_12();
_addNGC_13();
  }
}

}
