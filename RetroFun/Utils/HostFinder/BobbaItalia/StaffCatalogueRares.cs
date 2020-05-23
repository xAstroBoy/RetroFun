using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    class StaffCatalogueRares
    {
        public static readonly List<int> Bobba_PagineStaff = new List<int> { 10174, 10172, 15623, 9639, 9659, 9658, 9657, 9656, 9653, 9105, 9104, 3894, 3991, 11121, 4887, 4886, 4884, 4885, 4883 };
        public static readonly List<int> Bobba_BGWired = new List<int> { 18368, 4319, 3821, 10247, 18042 };
        public static readonly List<int> Bobba_RariMaggioHabbo = new List<int> { 16136, 16135, 16134, 16133, 16132, 16128, 16127, 16126, 16125, 16124, 16083, 16115, 16077, 16138, 16137 };
        public static readonly List<int> Bobba_RariFogliadiTe = new List<int> { 10431, 10430, 10429, 10428, 10427, 10426, 10425, 10424, 10423, 10422, 10421, 10437, 10436, 10435, 10434, 10433, 10432 };
        public static readonly List<int> Bobba_RariVerdi = new List<int> { 9546, 9545, 9544, 9543, 9542, 9540, 9539, 9538, 9537, 9536, 9535, 9534, 9533, 9532, 9531, 9530 };
        public static readonly List<int> Bobba_GameFLASH = new List<int> { 3014, 3055, 2734, 1967, 2369, 2367, 2757, 2368, 2375, 2374, 2373, 2372, 2371, 2370, 1738, 1966 };
        public static readonly List<int> Bobba_RariLPTPOK = new List<int> { 3018, 2627, 4331, 4417, 2520, 9772, 9771, 9770, 9769, 9768, 9767, 3567, 2975, 3052, 285, 2628, 2630, 1980, 1979, 1978, 1977, 1976, 1975, 1973, 1972, 1971, 1970, 1982, 1764, 1763, 1762, 1761, 1760, 3896, 4542, 3022 };
        public static readonly List<int> Bobba_RariSTAFF = new List<int> { 3225, 4140, 2969, 243, 2762, 9251, 9250, 9249, 9248, 9247, 9246, 2921, 9330, 3062, 9327, 4058, 3680, 294, 2756, 3064, 2938, 2629, 266, 265, 261, 293, 2987, 3063, 2986, 2985, 2984, 2968, 128, 19099, 234, 2941, 4176, 3110, 3109 };
        public static readonly List<int> Bobba_MiniTornei = new List<int> { 9175, 9174, 9173, 9172, 9171, 9170, 9169, 2763, 186, 185, 10204, 4834, 1772, 300, 305, 304, 303, 302, 2806, 449, 2225, 301, 1773, 286, 1771, 3268, 10699, 17551, 10590, 283 };
        public static readonly List<int> Bobba_CompetizioniEventi = new List<int> { 4422, 9278, 3104, 3102, 4423, 10526, 2366, 24509, 299, 298, 297, 296, 295, 254, 292, 291, 290, 4299, 9781, 10348, 231, 10611, 260, 4911, 4910, 9281, 9280, 4427, 4426, 9277, 9276, 9275, 9274, 4591, 2157, 9279 };
        public static readonly List<int> Bobba_Foche = new List<int> { 11282, 11281, 11280, 11279, 11278, 11276, 11274, 11273, 11272, 11271 };
        public static readonly List<int> Bobba_Tartarughe = new List<int> { 9815, 9813, 9812, 9811, 9810, 9809, 9808, 9807, 9806, 9805, 9804, 9803 };
        public static readonly List<int> Bobba_Ricci = new List<int> { 9224, 9223, 9222, 9221, 9220, 9218, 9217, 9216, 9215, 9214, 9227, 9226 };
        public static readonly List<int> Bobba_Ippopotami = new List<int> { 7613, 7612, 7611, 7610, 7609, 7608, 7607, 7606, 7605, 7604, 7603, 7602, 7601, 7600, 7599, 7598, 7597, 7596, 7595, 7594, 7616, 7614 };
        public static readonly List<int> Bobba_Panda = new List<int> { 10660, 10658, 10657, 10656, 10655, 10653, 10652, 10650, 10662, 10661 };
        public static readonly List<int> Bobba_DraghiStaff = new List<int> { 1623, 1622, 1619, 4659, 4408, 1628, 1626 };
        public static readonly List<int> Bobba_RariMensili = new List<int> { 24182, 11230, 10944, 11226, 11269 };
        public static readonly List<int> Bobba_Arcadev_1220 = new List<int> { 3091, 7678, 4832, 7675, 7673, 7672, 10382, 10354, 3094, 7681, 7680 };
        public static readonly List<int> Bobba_Raroniv_min_1250 = new List<int> { 9597, 230, 4304, 4531, 4803, 10568, 9622, 6089, 5001, 25084, 4300, 263, 3220, 3224, 9456, 4516, 4515, 22043 };
        public static readonly List<int> Bobba_UovaHabberge = new List<int> { 22574, 24518, 24517, 10581, 24515, 24514, 24513, 24512, 22573, 22605, 10215, 22596 };
        public static readonly List<int> Bobba_TrofeiStaff = new List<int> { 4414, 4413, 4412, 3852, 3851, 3850, 4411, 4428, 4416, 5766, 5765, 45819, 4438, 45818, 5764, 4415 };
        public static readonly List<int> Bobba_LimitedScaduti = new List<int> { 10714, 10777, 10776, 10775, 10774, 10773, 10772, 10632, 10631, 10630, 10629, 10628, 10627, 10626, 10625, 10624, 10623, 10622, 10621, 9299, 19965, 10620, 11204, 10615, 7615, 10609, 10601, 10659, 10649, 10654, 10651, 25125, 25724, 19524, 19760, 19759, 25596, 10555, 9814, 9225, 11189, 9219, 11275, 11270, 11277, 11283, 8388, 9166, 7617, 9718, 9672, 9690, 9665, 9671, 9716, 9684, 9661, 9708, 9662, 9728, 9707, 11167, 11103, 25133, 10756, 10723, 10762 };
        public static readonly List<int> Bobba_Habbo15Anni = new List<int> { 11320, 11319, 11318, 11332, 11331, 11330, 11329, 11328, 11327, 11326, 11325, 11324, 11323, 11322, 11321 };
        public static readonly List<int> Bobba_ScaricatidaHabbo = new List<int> { 25088, 19313, 19311, 19115, 19936, 19858, 19271, 19270, 22898, 15854, 19737, 19736, 25133, 19728, 20223, 19116, 22433, 22432, 25130, 25040, 25125, 20163, 25122, 25119, 25115, 20027, 19533, 21974, 19967, 17052, 25100, 25099, 19957, 23129, 25111 };
        public static readonly List<int> Bobba_TrofeiMarzo2020 = new List<int> { 19043, 19042, 19041, 19040, 19039, 19038, 19037, 20224, 19726, 16726, 16725, 15914, 15913, 15912, 15911, 15910, 15909, 15907, 15906, 15905, 15904, 15903, 15902, 15900, 15899, 15898, 15897, 15896, 15895, 18853, 18852, 18851, 17719, 18259, 19051, 19727, 19049, 19725, 19724, 18398, 19722, 19970, 18397, 19971, 19050, 19969, 19723, 19676, 17432, 17349, 19054, 19053, 19052, 16925, 16924, 16923, 19048, 19047, 19046, 19045, 19044 };
        public static readonly List<int> Bobba_RariHarryPotter = new List<int> { 25979, 25978, 25960, 26078, 26026, 25974, 26081, 25970, 26086, 25984, 26051, 25999 };
        public static readonly List<int> Bobba_Vari1 = new List<int> { 11410, 11409, 11408, 11407, 11406, 11405, 11404, 11403, 11402, 11401, 11400, 11399, 11398, 11397, 11392, 11391, 11390, 11389, 11388, 11387, 11368, 11367, 11366, 11365, 11357, 11356, 11353, 11352, 11351, 11350, 11453, 11457, 11456, 11455, 11454, 5755, 11452, 11451, 11450, 11449, 11448, 11447, 11446, 11445, 11444, 11443, 11442, 11441, 11440, 11439, 11438, 11437, 11436, 11435, 11434, 11433, 11432, 11431, 11430, 11429, 11428, 11427, 11426, 11425, 11424, 11423, 11422, 11421, 11420, 11419, 11418, 11417, 11416, 11415, 11414, 11413, 11412, 11411 };
        public static readonly List<int> Bobba_RariCelesti = new List<int> { 23141, 23140, 23139, 23138, 23137, 23136, 23135, 23134, 23133, 23132, 23131, 23130, 23128, 23127, 23126 };
        public static readonly List<int> Bobba_QuadriLimited = new List<int> { 25720, 25664, 25663, 25662, 25661, 25660, 25659, 25658, 25657, 25656, 25655, 25654, 25719, 25718, 25727, 25726, 25725, 25724, 25723, 25722, 25597, 25596, 25595, 25594, 25593, 25592, 25711, 25710, 25709, 25708, 25707, 25706, 25705, 25704, 25703, 25702, 25701, 25700, 25721 };
        public static readonly List<int> Bobba_Bradipi = new List<int> { 22560, 22559, 22558, 22557, 22556, 22555, 22554, 22553, 22552, 22551, 22550, 22549, 22548, 22547 };
        public static readonly List<int> Bobba_LibriHabbo = new List<int> { 19679, 19678, 19677, 19686, 19685, 19684, 19683, 19682, 19681, 19680 };
        public static readonly List<int> Bobba_RariLTDdelmese = new List<int> { 18932, 19941, 19962, 22534, 24415, 19964, 19963, 19525, 19961, 16758, 22128, 20217, 18933 };
        public static readonly List<int> Bobba_Sacchidabox = new List<int> { 19721, 19720, 19719, 19718, 19717, 19716, 19715 };
        public static readonly List<int> Bobba_Carpe = new List<int> { 17484, 17481, 17477, 17476, 17475, 17486 };
        public static readonly List<int> Bobba_GattiPeluche = new List<int> { 25037, 25036, 25035, 25034, 25033, 25032 };
        public static readonly List<int> Bobba_Macchinedelcaff = new List<int> { 25030, 25029, 25028, 25027, 25026, 25031 };
        public static readonly List<int> Bobba_RariBordeaux = new List<int> { 11317, 11316, 11315, 11314, 11313, 11312, 11311, 11310, 11309, 11308, 11307, 11306, 11305, 11304, 11303 };
        public static readonly List<int> Bobba_TappetiniZampa = new List<int> { 25024, 25023, 25022, 25021, 25020, 25019 };
        public static readonly List<int> Bobba_LampadaPanciuta = new List<int> { 25013, 25018, 25017, 25016, 25015, 25014 };
        public static readonly List<int> Bobba_TestBug = new List<int> { 24409, 9041, 25499, 19379, 23891, 18441, 25202, 9459, 19432, 19431, 19430, 19429, 23544, 16048, 25145, 19406, 19405, 19403, 19402, 19401, 19400, 19399, 19398, 19397, 19396, 25146, 19394, 19393, 19391, 17483, 17482, 19388, 19387, 19386, 17478, 19384, 19383, 19382, 19380, 18671, 19378, 19377, 19376, 19375, 19374, 19373, 19372, 19371, 19370, 19369, 19368, 19367, 19366, 19365, 19364, 19363, 19362, 19361, 19360, 19359, 19358, 19357, 19356, 19355, 19354, 19353, 19352, 19351, 19350, 19349, 19348, 19347, 25142, 19345, 19344, 19343, 19342, 19341, 19340, 19339, 19338, 19337, 19336, 19335, 19334, 19333, 19332, 19330, 15716, 19327, 19968, 19328, 25140, 19385, 18366, 23283, 22561, 19389, 19903, 19902, 25043, 25143, 25039, 19813, 19761, 25141, 25571, 25139, 25025, 19390, 22989, 22988, 25588, 25012, 19097, 19096, 25038, 25628, 25572, 24414, 25570 };
        public static readonly List<int> Bobba_EdizioneLimitata = new List<int> { 5000, 4999, 4995, 4994, 4993, 5005, 5004, 5003, 5002 };
        public static readonly List<int> Bobba_BamboleBoBBaWeen = new List<int> { 15418, 15417, 15416, 15415, 15414, 15413, 15412, 15411, 15500, 15419 };
        public static readonly List<int> Bobba_BonusRari17 = new List<int> { 9237, 9236, 9235, 9234, 9233, 9232, 9231, 9230, 9229, 9228, 9245, 9244, 9243, 9242, 9241, 9240, 9239, 9238 };
        public static readonly List<int> Bobba_BonusRari18 = new List<int> { 9750, 9749, 9748, 9747, 9746, 9745, 9766, 9765, 9764, 9763, 9762, 9761, 9758, 9757, 9756, 9755, 9754, 9753 };
        public static readonly List<int> Bobba_FurniCalippo = new List<int> { 2994, 2516, 4020, 3020, 2493, 3004, 2997 };
        public static readonly List<int> Bobba_Promozioni = new List<int> { 25402, 25389, 2841, 25498, 25574, 17601, 4030, 2600, 17824, 17823, 4249, 4247, 4243, 4240, 4239, 4122, 4114, 4113, 4112, 25454, 4108, 4107, 4106, 4103, 4101, 4100, 4099, 4098, 4096, 4090, 4089, 4092, 4091, 4088, 25383, 4083, 4082, 4081, 4080, 4079, 4066, 17544, 4053, 4052, 4049, 4045, 3085, 4330, 25430, 19269, 4256, 4325, 17535, 18284, 18689, 17302, 4327, 3096, 4328, 19739, 2749, 2981, 2977, 18022, 2959, 2958, 2956, 2950, 2943, 19942, 2908, 2907, 2906, 2905, 2899, 2896, 2895, 25418, 2884, 2879, 2878, 2877, 2876, 2874, 25384, 2872, 4258, 2846, 2845, 4338, 25382, 15874, 4347, 2758, 25493, 18473, 18410, 3009, 17586, 4344, 25404, 25391, 2960, 2961, 18365, 18364, 2998, 2480, 4345, 3015, 4341, 19740, 17554, 4425, 3895, 4018, 4019, 4051, 18268, 17610, 17498, 19114, 19113, 25449, 4259, 2733, 18553, 25403, 17676, 19102, 18147, 18089, 18088, 18087, 18086, 25575, 22899, 25401, 17616, 18021, 18020 };
        public static readonly List<int> Bobba_Rari = new List<int> { 2873, 4654, 4260, 2957, 2843, 3166, 3103, 3023, 4017, 3129, 3624, 4055, 2, 3151, 44, 43, 2481, 24519, 4650, 24516, 3610, 2989, 2976, 2971, 2962, 1577, 1578, 1576, 1575, 4021, 4804, 1569, 2732 };
        public static readonly List<int> Bobba_System = new List<int> { 205, 4271, 3178, 2847, 6088, 4105, 4104, 4102, 2937, 2936, 2935, 2933, 2932, 2931, 2382, 2881, 193, 192, 191, 190, 189, 188, 187, 2930, 2927, 2926, 2925, 2922, 3134, 2920, 2919, 2917, 2916, 2915, 2914, 2913, 2912, 2911, 2910, 2909 };
        public static readonly List<int> Bobba_Trax = new List<int> { 2365, 2335, 2334, 2333, 2332, 2518, 2517, 2309, 2105, 2330, 2382, 2331, 2383, 2519 };
        public static readonly List<int> Bobba_NuoviWired_s = new List<int> { 10674, 10673, 10672, 10671, 10670, 10669, 10668, 10667, 10666, 10665, 10664, 19032, 3497 };
        public static readonly List<int> Bobba_Utility = new List<int> { 4409, 51807, 8843, 60095, 4203, 11107, 5761, 4339, 8826, 9110, 8702, 3222, 4111, 4301, 7850, 11087, 11082, 11079, 11098, 10344, 9722, 3054, 3024, 8695, 2492, 11094, 11210, 9048, 6164, 7589, 4479, 3333, 4477, 2944, 4397, 2923, 7803, 8213, 8212, 7567, 2898, 51911, 2886, 7561, 8759, 7854, 3182, 8192, 4429, 9004, 7763, 10346, 4424, 4410, 10343, 7757, 4303, 8003, 3638, 3643, 3645, 3637, 7748, 11165, 4298, 60096, 2482, 60094, 15427, 7996, 10347, 7660, 3250, 3246, 10345, 4457, 8216, 4460, 4590, 9165, 11160, 7935, 7623, 5340, 2515, 7802, 4419, 4541 };
        public static readonly List<int> Bobba_LimitedEditionNEW = new List<int> { 16083, 25664, 19963, 7935 };

        public static bool isRareFurni(HFloorItem item)
        {
            if (Bobba_PagineStaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_BGWired.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariMaggioHabbo.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariFogliadiTe.Contains(item.TypeId)){ return true; }
            else if (Bobba_RariVerdi.Contains(item.TypeId)) { return true; }
            else if (Bobba_GameFLASH.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariLPTPOK.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariSTAFF.Contains(item.TypeId)) { return true; }
            else if (Bobba_MiniTornei.Contains(item.TypeId)) { return true; }
            else if (Bobba_CompetizioniEventi.Contains(item.TypeId)) { return true; }
            else if (Bobba_Foche.Contains(item.TypeId)) { return true; }
            else if (Bobba_Tartarughe.Contains(item.TypeId)) { return true; }
            else if (Bobba_Ricci.Contains(item.TypeId)) { return true; }
            else if (Bobba_Ippopotami.Contains(item.TypeId)) { return true; }
            else if (Bobba_Panda.Contains(item.TypeId)) { return true; }
            else if (Bobba_DraghiStaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariMensili.Contains(item.TypeId)) { return true; }
            else if (Bobba_Arcadev_1220.Contains(item.TypeId)) { return true; }
            else if (Bobba_Raroniv_min_1250.Contains(item.TypeId)) { return true; }
            else if (Bobba_UovaHabberge.Contains(item.TypeId)) { return true; }
            else if (Bobba_TrofeiStaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_LimitedScaduti.Contains(item.TypeId)) { return true; }
            else if (Bobba_Habbo15Anni.Contains(item.TypeId)) { return true; }
            else if (Bobba_ScaricatidaHabbo.Contains(item.TypeId)) { return true; }
            else if (Bobba_TrofeiMarzo2020.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariHarryPotter.Contains(item.TypeId)) { return true; }
            else if (Bobba_Vari1.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariCelesti.Contains(item.TypeId)) { return true; }
            else if (Bobba_QuadriLimited.Contains(item.TypeId)) { return true; }
            else if (Bobba_Bradipi.Contains(item.TypeId)) { return true; }
            else if (Bobba_LibriHabbo.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariLTDdelmese.Contains(item.TypeId)) { return true; }
            else if (Bobba_Sacchidabox.Contains(item.TypeId)) { return true; }
            else if (Bobba_Carpe.Contains(item.TypeId)) { return true; }
            else if (Bobba_GattiPeluche.Contains(item.TypeId)) { return true; }
            else if (Bobba_Macchinedelcaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariBordeaux.Contains(item.TypeId)) { return true; }
            else if (Bobba_TappetiniZampa.Contains(item.TypeId)) { return true; }
            else if (Bobba_LampadaPanciuta.Contains(item.TypeId)) { return true; }
            else if (Bobba_TestBug.Contains(item.TypeId)) { return true; }
            else if (Bobba_EdizioneLimitata.Contains(item.TypeId)) { return true; }
            else if (Bobba_BamboleBoBBaWeen.Contains(item.TypeId)) { return true; }
            else if (Bobba_BonusRari17.Contains(item.TypeId)) { return true; }
            else if (Bobba_BonusRari18.Contains(item.TypeId)) { return true; }
            else if (Bobba_FurniCalippo.Contains(item.TypeId)) { return true; }
            else if (Bobba_Promozioni.Contains(item.TypeId)) { return true; }
            else if (Bobba_Rari.Contains(item.TypeId)) { return true; }
            else if (Bobba_System.Contains(item.TypeId)) { return true; }
            else if (Bobba_Trax.Contains(item.TypeId)) { return true; }
            else if (Bobba_NuoviWired_s.Contains(item.TypeId)) { return true; }
            else if (Bobba_Utility.Contains(item.TypeId)) { return true; }
            else if (Bobba_LimitedEditionNEW.Contains(item.TypeId)) { return true; }

            else
            {
                return false;
            }
        }


        public static bool isRareFurni(HWallItem item)
        {
            if (Bobba_PagineStaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_BGWired.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariMaggioHabbo.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariFogliadiTe.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariVerdi.Contains(item.TypeId)) { return true; }
            else if (Bobba_GameFLASH.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariLPTPOK.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariSTAFF.Contains(item.TypeId)) { return true; }
            else if (Bobba_MiniTornei.Contains(item.TypeId)) { return true; }
            else if (Bobba_CompetizioniEventi.Contains(item.TypeId)) { return true; }
            else if (Bobba_Foche.Contains(item.TypeId)) { return true; }
            else if (Bobba_Tartarughe.Contains(item.TypeId)) { return true; }
            else if (Bobba_Ricci.Contains(item.TypeId)) { return true; }
            else if (Bobba_Ippopotami.Contains(item.TypeId)) { return true; }
            else if (Bobba_Panda.Contains(item.TypeId)) { return true; }
            else if (Bobba_DraghiStaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariMensili.Contains(item.TypeId)) { return true; }
            else if (Bobba_Arcadev_1220.Contains(item.TypeId)) { return true; }
            else if (Bobba_Raroniv_min_1250.Contains(item.TypeId)) { return true; }
            else if (Bobba_UovaHabberge.Contains(item.TypeId)) { return true; }
            else if (Bobba_TrofeiStaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_LimitedScaduti.Contains(item.TypeId)) { return true; }
            else if (Bobba_Habbo15Anni.Contains(item.TypeId)) { return true; }
            else if (Bobba_ScaricatidaHabbo.Contains(item.TypeId)) { return true; }
            else if (Bobba_TrofeiMarzo2020.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariHarryPotter.Contains(item.TypeId)) { return true; }
            else if (Bobba_Vari1.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariCelesti.Contains(item.TypeId)) { return true; }
            else if (Bobba_QuadriLimited.Contains(item.TypeId)) { return true; }
            else if (Bobba_Bradipi.Contains(item.TypeId)) { return true; }
            else if (Bobba_LibriHabbo.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariLTDdelmese.Contains(item.TypeId)) { return true; }
            else if (Bobba_Sacchidabox.Contains(item.TypeId)) { return true; }
            else if (Bobba_Carpe.Contains(item.TypeId)) { return true; }
            else if (Bobba_GattiPeluche.Contains(item.TypeId)) { return true; }
            else if (Bobba_Macchinedelcaff.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariBordeaux.Contains(item.TypeId)) { return true; }
            else if (Bobba_TappetiniZampa.Contains(item.TypeId)) { return true; }
            else if (Bobba_LampadaPanciuta.Contains(item.TypeId)) { return true; }
            else if (Bobba_TestBug.Contains(item.TypeId)) { return true; }
            else if (Bobba_EdizioneLimitata.Contains(item.TypeId)) { return true; }
            else if (Bobba_BamboleBoBBaWeen.Contains(item.TypeId)) { return true; }
            else if (Bobba_BonusRari17.Contains(item.TypeId)) { return true; }
            else if (Bobba_BonusRari18.Contains(item.TypeId)) { return true; }
            else if (Bobba_FurniCalippo.Contains(item.TypeId)) { return true; }
            else if (Bobba_Promozioni.Contains(item.TypeId)) { return true; }
            else if (Bobba_Rari.Contains(item.TypeId)) { return true; }
            else if (Bobba_System.Contains(item.TypeId)) { return true; }
            else if (Bobba_Trax.Contains(item.TypeId)) { return true; }
            else if (Bobba_NuoviWired_s.Contains(item.TypeId)) { return true; }
            else if (Bobba_Utility.Contains(item.TypeId)) { return true; }
            else if (Bobba_LimitedEditionNEW.Contains(item.TypeId)) { return true; }

            else
            {
                return false;
            }
        }

    }





}
