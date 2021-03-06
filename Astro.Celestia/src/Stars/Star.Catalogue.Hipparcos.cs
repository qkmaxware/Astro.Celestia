using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
    
    private static List<Star> _Hipparcos = null; 
    public static IEnumerable<Star> Hipparcos{
        get {
            if (_Hipparcos == null) {
                _Hipparcos = new List<Star>(118218);
                _rebuildHipparcos();
            }
            return _Hipparcos.AsReadOnly();
        }
    }
    
    private static void _rebuildHipparcos() {
_addHipparcos_0();
_addHipparcos_1();
_addHipparcos_2();
_addHipparcos_3();
_addHipparcos_4();
_addHipparcos_5();
_addHipparcos_6();
_addHipparcos_7();
_addHipparcos_8();
_addHipparcos_9();
_addHipparcos_10();
_addHipparcos_11();
_addHipparcos_12();
_addHipparcos_13();
_addHipparcos_14();
_addHipparcos_15();
_addHipparcos_16();
_addHipparcos_17();
_addHipparcos_18();
_addHipparcos_19();
_addHipparcos_20();
_addHipparcos_21();
_addHipparcos_22();
_addHipparcos_23();
_addHipparcos_24();
_addHipparcos_25();
_addHipparcos_26();
_addHipparcos_27();
_addHipparcos_28();
_addHipparcos_29();
_addHipparcos_30();
_addHipparcos_31();
_addHipparcos_32();
_addHipparcos_33();
_addHipparcos_34();
_addHipparcos_35();
_addHipparcos_36();
_addHipparcos_37();
_addHipparcos_38();
_addHipparcos_39();
_addHipparcos_40();
_addHipparcos_41();
_addHipparcos_42();
_addHipparcos_43();
_addHipparcos_44();
_addHipparcos_45();
_addHipparcos_46();
_addHipparcos_47();
_addHipparcos_48();
_addHipparcos_49();
_addHipparcos_50();
_addHipparcos_51();
_addHipparcos_52();
_addHipparcos_53();
_addHipparcos_54();
_addHipparcos_55();
_addHipparcos_56();
_addHipparcos_57();
_addHipparcos_58();
_addHipparcos_59();
_addHipparcos_60();
_addHipparcos_61();
_addHipparcos_62();
_addHipparcos_63();
_addHipparcos_64();
_addHipparcos_65();
_addHipparcos_66();
_addHipparcos_67();
_addHipparcos_68();
_addHipparcos_69();
_addHipparcos_70();
_addHipparcos_71();
_addHipparcos_72();
_addHipparcos_73();
_addHipparcos_74();
_addHipparcos_75();
_addHipparcos_76();
_addHipparcos_77();
_addHipparcos_78();
_addHipparcos_79();
_addHipparcos_80();
_addHipparcos_81();
_addHipparcos_82();
_addHipparcos_83();
_addHipparcos_84();
_addHipparcos_85();
_addHipparcos_86();
_addHipparcos_87();
_addHipparcos_88();
_addHipparcos_89();
_addHipparcos_90();
_addHipparcos_91();
_addHipparcos_92();
_addHipparcos_93();
_addHipparcos_94();
_addHipparcos_95();
_addHipparcos_96();
_addHipparcos_97();
_addHipparcos_98();
_addHipparcos_99();
_addHipparcos_100();
_addHipparcos_101();
_addHipparcos_102();
_addHipparcos_103();
_addHipparcos_104();
_addHipparcos_105();
_addHipparcos_106();
_addHipparcos_107();
_addHipparcos_108();
_addHipparcos_109();
_addHipparcos_110();
_addHipparcos_111();
_addHipparcos_112();
_addHipparcos_113();
_addHipparcos_114();
_addHipparcos_115();
_addHipparcos_116();
_addHipparcos_117();
_addHipparcos_118();
  }
}

}
