﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECGTest
{
    public class data
    {
        public static int[] data2 = { -162, -169, -184, -191, -188, -187, -192, -195, -186, -167, -152, -154, -162, -161, -149, -141, -147, -165, -178, -174, -156, -137, -130, -135, -144, -148, -143, -138, -138, -148, -161, -173, -180, -182, -175, -162, -152, -157, -175, -188, -182, -168, -170, -196, -227, -240, -233, -228, -240, -258, -264, -253, -234, -218, -204, -185, -166, -153, -149, -153, -162, -173, -183, -195, -215, -244, -268, -265, -232, -200, -197, -219, -230, -209, -172, -155, -168, -190, -193, -180, -170, -169, -172, -176, -183, -195, -204, -203, -205, -222, -246, -254, -244, -238, -259, -296, -312, -292, -257, -241, -243, -228, -173, -95, -34, -3, 13, 36, 69, 101, 123, 132, 130, 126, 129, 145, 170, 192, 204, 211, 222, 235, 241, 237, 230, 220, 197, 161, 126, 103, 91, 71, 41, 16, 12, 25, 38, 38, 30, 30, 40, 55, 65, 67, 61, 53, 51, 59, 72, 84, 90, 88, 76, 53, 33, 38, 67, 98, 110, 113, 129, 171, 228, 284, 335, 374, 367, 268, 66, -193, -435, -618, -740, -783, -682, -349, 314, 1406, 2980, 4955, 7106, 9226, 11310, 13468, 15607, 17264, 17918, 17491, 16427, 15181, 13712, 11646, 8925, 6118, 3959, 2653, 1780, 888, -8, -556, -597, -403, -380, -670, -1114, -1520, -1845, -2144, -2421, -2616, -2699, -2707, -2691, -2671, -2642, -2610, -2593, -2607, -2651, -2701, -2724, -2699, -2627, -2537, -2462, -2423, -2411, -2403, -2382, -2350, -2319, -2290, -2255, -2204, -2147, -2099, -2072, -2059, -2049, -2031, -2001, -1957, -1904, -1855, -1821, -1798, -1771, -1732, -1688, -1650, -1622, -1594, -1563, -1537, -1521, -1509, -1489, -1464, -1446, -1436, -1423, -1393, -1350, -1311, -1284, -1261, -1229, -1185, -1138, -1097, -1063, -1034, -1007, -979, -946, -907, -869, -841, -820, -798, -767, -727, -684, -643, -602, -562, -521, -480, -439, -400, -365, -336, -310, -282, -249, -217, -192, -175, -157, -134, -112, -100, -101, -106, -105, -99, -97, -101, -108, -114, -124, -139, -152, -153, -141, -131, -133, -139, -132, -111, -88, -75, -64, -43, -14, 3, -2, -21, -32, -31, -34, -57, -95, -133, -160, -182, -209, -244, -277, -303, -321, -339, -363, -390, -414, -431, -439, -445, -452, -463, -474, -479, -473, -463, -456, -457, -461, -463, -461, -459, -462, -464, -457, -441, -427, -426, -437, -443, -430, -399, -369, -357, -364, -373, -371, -362, -358, -372, -401, -433, -457, -469, -471, -466, -450, -420, -373, -316, -257, -202, -152, -108, -74, -56, -59, -80, -110, -140, -170, -200, -228, -246, -243, -219, -189, -168, -157, -141, -111, -75, -56, -60, -75, -83, -81, -86, -103, -126, -144, -156, -174, -197, -215, -216, -208, -208, -221, -233, -226, -202, -182, -180, -192, -196, -179, -148, -124, -119, -126, -127, -110, -84, -69, -82, -113, -140, -147, -142, -143, -154, -161, -154, -141, -145, -174, -208, -223, -220, -223, -255, -306, -345, -348, -325, -304, -304, -318, -326, -313, -293, -288, -306, -330, -336, -321, -306, -312, -334, -350, -345, -335, -345, -374, -402, -405, -387, -372, -371, -375, -367, -345, -324, -319, -323, -320, -299, -264, -223, -173, -107, -30, 39, 87, 117, 146, 183, 219, 237, 233, 221, 223, 252, 299, 344, 367, 371, 375, 393, 417, 425, 408, 385, 379, 389, 391, 366, 327, 303, 305, 312, 300, 266, 231, 217, 223, 230, 225, 208, 192, 185, 188, 192, 185, 163, 137, 124, 131, 148, 155, 135, 97, 66, 58, 73, 98, 120, 129, 128, 133, 166, 235, 315, 355, 307, 157, -68, -322, -554, -738, -849, -839, -645, -189, 647, 2002, 3918, 6223, 8605, 10868, 13073, 15329, 17420, 18787, 18994, 18183, 16907, 15492, 13713, 11231, 8256, 5544, 3707, 2641, 1774, 783, -99, -488, -386, -205, -323, -755, -1263, -1670, -1974, -2243, -2484, -2657, -2749, -2780, -2772, -2741, -2705, -2686, -2694, -2723, -2761, -2790, -2801, -2788, -2745, -2672, -2584, -2510, -2478, -2487, -2511, -2512, -2476, -2415, -2357, -2317, -2287, -2255, -2214, -2173, -2146, -2132, -2115, -2073, -2006, -1935, -1888, -1875, -1881, -1876, -1844, -1796, -1751, -1720, -1694, -1661, -1617, -1576, -1550, -1533, -1507, -1467, -1424, -1397, -1385, -1369, -1334, -1289, -1256, -1244, -1240, -1218, -1174, -1129, -1105, -1095, -1075, -1031, -981, -952, -947, -938, -902, -854, -828, -833, -838, -810, -754, -710, -698, -699, -676, -624, -574, -551, -553, -555, -545, -531, -529, -541, -558, -568, -561, -538, -507, -479, -459, -434, -394, -343, -301, -285, -284, -275, -248, -213, -190, -176, -156, -119, -77, -47, -26, 2, 42, 78, 90, 83, 79, 89, 99, 88, 61, 38, 31, 26, 8, -25, -55, -73, -89, -112, -149, -191, -229, -261, -284, -299, -312, -326, -339, -343, -335, -322, -320, -334, -355, -367, -364, -356, -356, -372, -398, -420, -432, -437, -445, -457, -473, -486, -493, -494, -485, -462, -432, -409, -402, -406, -405, -389, -368, -359, -368, -387, -402, -404, -400, -396, -396, -399, -401, -403, -406, -412, -415, -410, -396, -383, -381, -386, -388, -377, -356, -339, -336, -339, -334, -319, -301, -292, -291, -290, -282, -271, -265, -271, -281, -285, -280, -272, -269, -276, -290, -300, -302, -290, -271, -256, -252, -254, -249, -231, -210, -205, -221, -241, -246, -237, -231, -240, -259, -267, -258, -241, -233, -235, -239, -237, -235, -237, -243, -247, -249, -253, -263, -274, -280, -281, -286, -301, -318, -332, -342, -358, -386, -420, -444, -451, -450, -457, -479, -509, -531, -536, -531, -531, -550, -581, -602, -595, -557, -499, -440, -388, -343, -298, -247, -193, -148, -123, -120, -122, -112, -91, -72, -64, -60, -42, -6, 31, 47, 41, 24, 10, 2, -4, -15, -35, -62, -91, -112, -119, -115, -113, -117, -125, -127, -121, -116, -115, -114, -109, -101, -99, -107, -119, -125, -121, -111, -107, -114, -130, -151, -168, -178, -180, -179, -178, -172, -153, -126, -94, -55, -11, 31, 56, 43, -37, -209, -470, -753, -957, -1005, -896, -681, -362, 205, 1241, 2821, 4735, 6625, 8318, 9972, 11794, 13614, 14861, 15075, 14394, 13401, 12461, 11330, 9540, 7119, 4740, 3088, 2208, 1578, 777, -81, -601, -636, -460, -447, -707, -1092, -1441, -1718, -1962, -2172, -2313, -2379, -2403, -2413, -2415, -2404, -2383, -2362, -2352, -2360, -2379, -2394, -2389, -2353, -2293, -2225, -2172, -2144, -2138, -2135, -2118, -2090, -2062, -2043, -2027, -2002, -1966, -1932, -1909, -1893, -1869, -1829, -1779, -1729, -1686, -1645, -1602, -1561, -1528, -1500, -1469, -1431, -1389, -1347, -1307, -1265, -1224, -1192, -1171, -1152, -1119, -1072, -1024, -991, -969, -937, -885, -823, -775, -747, -724, -690, -648, -612, -588, -568, -537, -497, -462, -441, -426, -404, -372, -340, -318, -302, -280, -249, -217, -194, -179, -165, -149, -135, -133, -140, -146, -145, -140, -139, -136, -122, -92, -58, -33, -18, -6, 7, 11, -5, -38, -75, -105, -131, -162, -192, -211, -209, -192, -169, -144, -117, -93, -81, -82, -84, -81, -81, -102, -147, -197, -233, -255, -286, -335, -390, -434, -468, -507, -554, -597, -620, -630, -648, -680, -711, -723, -719, -716, -725, -739, -748, -755, -765, -781, -791, -792, -787, -784, -777, -760, -740, -728, -726, -722, -704, -679, -666, -667, -672, -666, -651, -636, -624, -609, -591, -580, -578, -576, -564, -548, -541, -546, -549, -539, -523, -513, -507, -493, -466, -440, -431, -437, -442, -435, -422, -417, -424, -435, -446, -453, -456, -455, -453, -451, -452, -454, -453, -452, -453, -460, -468, -474, -476, -478, -484, -491, -494, -491, -485, -478, -474, -471, -466, -462, -458, -456, -456, -457, -458, -458, -454, -444, -432, -425, -425, -428, -428, -427, -428, -433, -439, -441, -438, -432, -423, -408, -389, -370, -356, -347, -341, -336, -333, -335, -338, -342, -346, -350, -355, -362, -369, -374, -377, -378, -380, -386, -395, -397, -392, -387, -393, -412, -435, -449, -449, -440, -428, -409, -377, -329, -272, -214, -164, -120, -83, -50, -21, 1, 14, 14, 11, 16, 36, 60, 73, 74, 79, 98, 121, 124, 102, 75, 65, 68, 60, 28, -14, -41, -47, -47, -56, -68, -74, -66, -52, -41, -32, -21, -7, 4, 7, 2, -6, -11, -10, -4, 1, 1, -6, -18, -34, -46, -48, -41, -34, -28, -16, 8, 38, 65, 89, 118, 157, 176, 125, -31, -278, -542, -737, -821, -793, -660, -396, 100, 966, 2284, 3976, 5819, 7626, 9414, 11310, 13259, 14858, 15629, 15470, 14753, 13888, 12836, 11207, 8861, 6273, 4175, 2870, 2026, 1164, 216, -486, -688, -542, -427, -564, -887, -1236, -1540, -1822, -2078, -2258, -2341, -2372, -2394, -2416, -2419, -2404, -2390, -2395, -2418, -2445, -2458, -2446, -2402, -2329, -2247, -2186, -2162, -2159, -2154, -2135, -2114, -2097, -2075, -2029, -1966, -1914, -1892, -1892, -1887, -1866, -1836, -1808, -1781, -1743, -1693, -1646, -1610, -1582, -1556, -1527, -1500, -1476, -1451, -1422, -1396, -1376, -1354, -1321, -1275, -1229, -1198, -1179, -1157, -1119, -1072, -1028, -995, -973, -955, -938, -919, -896, -869, -844, -820, -797, -776, -760, -749, -735, -711, -682, -662, -657, -654, -634, -593, -550, -520, -503, -484, -457, -430, -416, -417, -425, -431, -434, -435, -439, -450, -462, -472, -478, -484, -497, -516, -532, -542, -554, -574, -596, -610, -612, -609, -606, -594, -562, -517, -477, -451, -427, -385, -327, -275, -249, -240, -227, -201, -170, -149, -147, -160, -180, -197, -204, -203, -206, -226, -256, -278, -276, -257, -241, -241, -247, -246, -239, -240, -256, -280, -297, -304, -313, -325, -333, -324, -302, -281, -270, -267, -260, -241, -220, -205, -206, -219, -236, -248, -251, -249, -249, -255, -265, -274, -278, -275, -271, -273, -279, -281, -266, -236, -206, -190, -184, -171, -144, -116, -107, -117, -128, -124, -110, -107, -120, -134, -130, -110, -94, -95, -108, -116, -106, -83, -63, -60, -70, -76, -65, -41, -24, -28, -51, -76, -90, -92, -91, -94, -106, -123, -136, -141, -136, -131, -134, -144, -155, -166, -187, -228, -285, -342, -382, -398, -395, -379, -350, -306, -240, -149, -40, 66, 146, 188, 196, 189, 177, 156, 116, 55, -14, -71, -103, -114, -115, -111, -100, -76, -44, -21, -16, -24, -29, -26, -19, -12, -7, -5, -11, -21 };
        public static int[] data1 = {-162,-169,-184,-191,-188,-187,-192,-195,-186,-167,-152,-154,-162,-161
            ,-149,-141,-147,-165,-178,-174,-156,-137,-130,-135,-144,-148,-143,-138,-138,-148,-161,-173,-180,-182,-175
            ,-162,-152,-157,-175,-188,-182,-168,-170,-196,-227,-240,-233,-228,-240,-258,-264,-253,-234,-218,-204,-185,-166
            ,-153,-149,-153,-162,-173,-183,-195,-215,-244,-268,-265,-232,-200,-197,-219,-230,-209,-172,-155,-168,-190,-193,-180,-170
            ,-169,-172,-176,-183,-195,-204,-203,-205,-222,-246,-254,-244,-238,-259,-296,-312,-292,-257,-241,-243,-228,-173,-95,-34,-3,13,36
            ,69,101,123,132,130,126,129,145,170,192,204,211,222,235,241,237,230,220,197,161,126,103,91,71,41,16,12,25,38,38,30,30,40,55,65,67,61
            ,53,51,59,72,84,90,88,76,53,33,38,67,98,110,113,129,171,228,284,335,374,367,268,66,-193,-435,-618,-740,-783,-682,-349,314,1406,2980,4955,
            7106,9226,11310,13468,15607,17264,17918,17491,16427,15181,13712,11646,8925,6118,3959,2653,1780,888,-8,-556,-597,-403,-380,-670,-1114,-1520,
            -1845,-2144,-2421,-2616,-2699,-2707,-2691,-2671,-2642,-2610,-2593,-2607,-2651,-2701,-2724,-2699,-2627,-2537,-2462,-2423,-2411,-2403,-2382,-2350,
            -2319,-2290,-2255,-2204,-2147,-2099,-2072,-2059,-2049,-2031,-2001,-1957,-1904,-1855,-1821,-1798,-1771,-1732,-1688,-1650,-1622,-1594,-1563,-1537,-1521,
            -1509,-1489,-1464,-1446,-1436,-1423,-1393,-1350,-1311,-1284,-1261,-1229,-1185,-1138,-1097,-1063,-1034,-1007,-979,-946,-907,-869,-841,-820,-798,-767,-727,
            -684,-643,-602,-562,-521,-480,-439,-400,-365,-336,-310,-282,-249,-217,-192,-175,-157,-134,-112,-100,-101,-106,-105,-99,-97,-101,-108,-114,-124,-139,-152,
            -153,-141,-131,-133,-139,-132,-111,-88,-75,-64,-43,-14,3,-2,-21,-32,-31,-34,-57,-95,-133,-160,-182,-209,-244,-277,-303,-321,-339,-363,-390,-414,-431,-439,
            -445,-452,-463,-474,-479,-473,-463,-456,-457,-461,-463,-461,-459,-462,-464,-457,-441,-427,-426,-437,-443,-430,-399,-369,-357,-364,-373,-371,-362,-358,-372,
            -401,-433,-457,-469,-471,-466,-450,-420,-373,-316,-257,-202,-152,-108,-74,-56,-59,-80,-110,-140,-170,-200,-228,-246,-243,-219,-189,-168,-157,-141,-111,-75,-56,
            -60,-75,-83,-81,-86,-103,-126,-144,-156,-174,-197,-215,-216,-208,-208,-221,-233,-226,-202,-182,-180,-192,-196,-179,-148,-124,-119,-126,-127,-110,-84,-69,-82,-113,
            -140,-147,-142,-143,-154,-161,-154,-141,-145,-174,-208,-223,-220,-223,-255,-306,-345,-348,-325,-304,-304,-318,-326,-313,-293,-288,-306,-330,-336,-321,-306,-312,-334,
            -350,-345,-335,-345,-374,-402,-405,-387,-372,-371,-375,-367,-345,-324,-319,-323,-320,-299,-264,-223,-173,-107,-30,39,87,117,146,183,219,237,233,221,223,252,299,344,
            367,371,375,393,417,425,408,385,379,389,391,366,327,303,305,312,300,266,231,217,223,230,225,208,192,185,188,192,185,163,137,124,131,148,155,135,97,66,58,73,98,120,
            129,128,133,166,235,315,355,307,157,-68,-322,-554,-738,-849,-839,-645,-189,647,2002,3918,6223,8605,10868,13073,15329,17420,18787,18994,18183,16907,15492,13713,11231,
            8256,5544,3707,2641,1774,783,-99,-488,-386,-205,-323,-755,-1263,-1670,-1974,-2243,-2484,-2657,-2749,-2780,-2772,-2741,-2705,-2686,-2694,-2723,-2761,-2790,-2801,
            -2788,-2745,-2672,-2584,-2510,-2478,-2487,-2511,-2512,-2476,-2415,-2357,-2317,-2287,-2255,-2214,-2173,-2146,-2132,-2115,-2073,-2006,-1935,-1888,-1875,-1881,-1876,
            -1844,-1796,-1751,-1720,-1694,-1661,-1617,-1576,-1550,-1533,-1507,-1467,-1424,-1397,-1385,-1369,-1334,-1289,-1256,-1244,-1240,-1218,-1174,-1129,-1105,-1095,-1075,
            -1031,-981,-952,-947,-938,-902,-854,-828,-833,-838,-810,-754,-710,-698,-699,-676,-624,-574,-551,-553,-555,-545,-531,-529,-541,-558,-568,-561,-538,-507,-479,-459,-434,
            -394,-343,-301,-285,-284,-275,-248,-213,-190,-176,-156,-119,-77,-47,-26,2,42,78,90,83,79,89,99,88,61,38,31,26,8,-25,-55,-73,-89,-112,-149,-191,-229,-261,-284,-299,-312,
            -326,-339,-343,-335,-322,-320,-334,-355,-367,-364,-356,-356,-372,-398,-420,-432,-437,-445,-457,-473,-486,-493,-494,-485,-462,-432,-409,-402,-406,-405,-389,-368,-359,-368,-387};

    }
}
