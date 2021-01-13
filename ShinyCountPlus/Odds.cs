using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShinyCountPlus
{
    class Odds
    {
        static int shinyCharmBin;

        #region Odds
        // Static odds
        public static int[] fullOdds1 = { 8192, 2731 };
        public static int[] fullOdds2 = { 4096, 1365 };
        public static int masudaOdds1 = 1365;
        public static int[] masudaOdds2 = { 683, 512 };
        public static int[] hordesOdds = { 819, 273 };
        public static int[] adventureOdds = { 300, 100 };
        public static int friendSafariOdds = 512;

        // Chain/encounter-dependent dynamic odds
        public static int[,] comboOdds1 = new int[2, 4]
        {
            {
                4096, 1024, 512, 341
            },
            {
                1365, 682, 410, 293
            }
        };

        public static int[,] comboOdds2 = new int[2, 4]
        {
            {
                2048, 819, 455, 315
            },
            {
                1024, 585, 372, 273
            }
        };

        public static int[,] chainFishOdds = new int[2, 21]
        {
            {
                4096, 1336, 820, 586, 456, 373, 316, 274, 241, 216, 196,
                179, 164, 152, 142, 133, 125, 118, 111, 106, 100
            },
            {
                1365, 820, 586, 456, 373, 316, 274, 241, 216, 196, 179,
                164, 152, 142, 133, 125, 118, 111, 106, 100, 96
            }
        };

        public static int[,] dexNavOdds = new int[2, 20]
        {
            { //   0  100   150   200   250   300   350   400   450  500  550  600  650  700  750  800  850  900  950, 999
                4096, 1667, 1429, 1250, 1176, 1111, 1053, 1000, 952, 909, 870, 833, 800, 769, 741, 714, 690, 667, 645, 625
            },
            {
                4096, 556,  476,  417,  392,  370,  351,  333,  317, 303, 290, 278, 267, 263, 248, 239, 230, 223, 216, 209
            }
        };

        public static int[,] sosOdds = new int[2, 2]
        {
            { 4096, 1024 }, { 1365, 683 }
        };

        // Radar odds hardly change with charm, and the difference doesn't seem to be well known (at least for gen 6)
        public static int[,] radarOdds1 = new int[2, 41]
        {
            { 
                8192, 8192, 8192, 7282, 7282, 7282, 7282, 6554, 6554, 6554, 5958, 5958, 5958, 5461, 5461, 5041,
                5041, 4681, 4681, 4369, 4096, 4096, 3855, 3641, 3449, 3277, 2979, 2849, 2621, 2427, 2185,
                1986, 1820,  1598, 1394, 1192, 993, 799, 601, 400, 200 
            },
            {
                2731, 2731, 2731, 2427, 2427, 2427, 2427, 2185, 2185, 2185, 1986, 1986, 1986, 1820, 1820, 1680,
                1680, 1560, 1560, 1456, 1365, 1365, 1285, 1214, 1150, 1092, 993, 950, 874, 809, 728,
                662, 607, 533, 465, 397, 331, 266, 200, 200, 200
            }
        };
        public static int[,] radarOdds2 = new int[2, 41]
        {
            {
                4096, 4096, 4096, 3855, 3855, 3641, 3641, 3449, 3449, 3277, 3277, 3121, 2979, 2849, 2849, 2731,
                2621, 2521, 2427, 2341, 2185, 2114, 1986, 1928, 1820, 1680, 1598, 1489, 1394, 1311, 1192,
                1092, 993, 898, 799, 697, 601, 500, 400, 301, 200
            },
            {
                1365, 1365, 1365, 1285, 1285, 1214, 1214, 1150, 1150, 1092, 1092, 1040, 993, 950, 950, 910,
                874, 840, 809, 780, 728, 705, 662, 643, 607, 560, 533, 496, 465, 437, 397,
                364, 331, 299, 266, 232, 200, 200, 200, 200, 200
            }
        };
        #endregion

        public static int getOdds(String method, int encounters, bool shinyCharm)
        {
            // Used to decide whether to grab the non-shiny charm odds (Array index 0) or shiny charm odds (Array index 1)
            if (!shinyCharm)
            {
                shinyCharmBin = 0;
            } else
            {
                shinyCharmBin = 1;
            }

            if (method == "REs (Gen 1-5)" || method == "SRs (Gen 1-5)")
            {
                return fullOdds1[shinyCharmBin];
            }

            if (method == "REs (Gen 6+)" || method == "SRs (Gen 6+)")
            {
                return fullOdds2[shinyCharmBin];
            }

            if (method == "Hordes")
            {
                return hordesOdds[shinyCharmBin];
            }

            if (method == "Friend Safari")
                {
                    return friendSafariOdds;
                }

            if (method == "Dynamax Adventures")
            {
                return adventureOdds[shinyCharmBin];
            }

            if (method == "Masuda (Gen 4-5)")
            {
                return masudaOdds1;
            }

            if (method == "Masuda (Gen 6+)")
            {
                return masudaOdds2[shinyCharmBin];
            }

            if (method == "Catch Combo (No Lure)")
            {
                return getComboOdds(false, encounters);
            }

            if (method == "Catch Combo (With Lure)")
            {
                return getComboOdds(true, encounters);
            }

            if (method == "SoS Calls")
            {
                return getSosOdds(encounters);
            }

            if (method == "Dex Nav")
            {
                return getDexOdds(encounters);
            }

            if (method == "Chain Fishing")
            {
                return getChainFishOdds(encounters);
            }

            if (method == "Poke Radar (Gen 4)")
            {
                return getRadar4Odds(encounters);
            }

            if (method == "Poke Radar (Gen 6)")
            {
                return getRadar6Odds(encounters);
            }

            return 8192;
        }

        public static int getComboOdds(bool lure, int encounters)
        {
            if (!lure)
            {
                if (encounters <= 10)
                {
                    return comboOdds1[shinyCharmBin, 0];
                } else if (encounters <= 20)
                {
                    return comboOdds1[shinyCharmBin, 1]; ;
                } else if (encounters <= 30)
                {
                    return comboOdds1[shinyCharmBin, 2]; ;
                } else
                {
                    return comboOdds1[shinyCharmBin, 3]; ;
                }
            } 
            else
            {
                if (encounters <= 10)
                {
                    return comboOdds2[shinyCharmBin, 0];
                }
                else if (encounters <= 20)
                {
                    return comboOdds2[shinyCharmBin, 1]; ;
                }
                else if (encounters <= 30)
                {
                    return comboOdds2[shinyCharmBin, 2]; ;
                }
                else
                {
                    return comboOdds2[shinyCharmBin, 3]; ;
                }
            }
        }

        public static int getSosOdds(int encounters)
        {
            if (encounters < 70)
            {
                return sosOdds[shinyCharmBin, 0];
            } else
            {
                return sosOdds[shinyCharmBin, 1];
            }
        }

        public static int getDexOdds(int encounters) 
        {
            if (encounters < 100)
            {
                return dexNavOdds[shinyCharmBin, 0];
            } 

            if (encounters >= 999)
            {
                return dexNavOdds[shinyCharmBin, 19];
            }

            // Odds update every interval of 50 (except for pre-100 & 999+) on the search level indicator, so current odds can be found by dividing search level by 50
            int oddsIndex = 1;
            oddsIndex = (encounters / 50) - 1;

            return dexNavOdds[shinyCharmBin, oddsIndex];
        }

        public static int getChainFishOdds(int encounters)
        {
            if (encounters >= 20)
            {
                return chainFishOdds[shinyCharmBin, 20];
            }

            return chainFishOdds[shinyCharmBin, encounters];
        }

        public static int getRadar4Odds(int encounters)
        {
            if (encounters >= 40)
            {
                return radarOdds1[shinyCharmBin, 40];
            }

            return radarOdds1[shinyCharmBin, encounters];
        }

        public static int getRadar6Odds(int encounters)
        {
            if (encounters >= 40)
            {
                return radarOdds2[shinyCharmBin, 40];
            }

            return radarOdds2[shinyCharmBin, encounters];
        }
    }
}
