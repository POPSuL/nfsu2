﻿using System;
namespace NFSU2CH
{
    internal class Converter
    {
        static int[] _a = new int[256] { 144, 39, 78, 119, 5, 171, 202, 98, 200, 178, 50, 140, 214, 72, 196, 49, 100, 25, 53, 225, 107, 138, 65, 71, 73, 89, 175, 170, 116, 114, 165, 13, 239, 117, 75, 54, 106, 161, 131, 233, 21, 182, 155, 23, 2, 87, 70, 137, 90, 241, 95, 41, 1, 128, 230, 7, 197, 55, 46, 36, 52, 0, 167, 42, 198, 59, 69, 12, 215, 20, 124, 205, 166, 173, 238, 60, 134, 152, 102, 250, 218, 37, 22, 216, 91, 31, 99, 162, 179, 169, 129, 206, 156, 151, 32, 188, 183, 82, 220, 194, 180, 177, 85, 228, 33, 201, 26, 195, 9, 184, 110, 123, 14, 157, 193, 189, 199, 121, 149, 68, 125, 122, 164, 111, 94, 191, 47, 38, 249, 19, 213, 88, 86, 84, 207, 242, 3, 204, 186, 210, 203, 244, 66, 27, 227, 10, 158, 163, 115, 190, 253, 153, 51, 187, 221, 255, 81, 237, 44, 108, 57, 135, 58, 77, 208, 217, 34, 243, 172, 231, 101, 147, 229, 132, 141, 251, 64, 79, 113, 92, 80, 245, 254, 232, 159, 105, 136, 130, 28, 154, 252, 83, 67, 226, 247, 223, 192, 93, 212, 148, 15, 139, 16, 127, 35, 43, 6, 145, 62, 40, 176, 185, 209, 61, 168, 120, 56, 219, 142, 143, 236, 211, 160, 126, 48, 74, 174, 45, 104, 234, 18, 224, 96, 109, 103, 181, 146, 8, 29, 4, 246, 76, 222, 150, 97, 235, 24, 240, 133, 30, 112, 248, 11, 118, 63, 17 };
        static int[] _b = new int[256] { 61, 52, 44, 136, 239, 4, 206, 55, 237, 108, 145, 252, 67, 31, 112, 200, 202, 255, 230, 129, 69, 40, 82, 43, 246, 17, 106, 143, 188, 238, 249, 85, 94, 104, 166, 204, 59, 81, 127, 1, 209, 51, 63, 205, 158, 227, 58, 126, 224, 15, 10, 152, 60, 18, 35, 57, 216, 160, 162, 65, 75, 213, 208, 254, 176, 22, 142, 192, 119, 66, 46, 23, 13, 24, 225, 34, 241, 163, 2, 177, 180, 156, 97, 191, 133, 102, 132, 45, 131, 25, 48, 84, 179, 197, 124, 50, 232, 244, 7, 86, 16, 170, 78, 234, 228, 185, 36, 20, 159, 233, 110, 123, 250, 178, 29, 148, 28, 33, 253, 3, 215, 117, 121, 111, 70, 120, 223, 203, 53, 90, 187, 38, 173, 248, 76, 161, 186, 47, 21, 201, 11, 174, 218, 219, 0, 207, 236, 171, 199, 118, 243, 93, 77, 151, 189, 42, 92, 113, 146, 184, 222, 37, 87, 147, 122, 30, 72, 62, 214, 89, 27, 5, 168, 73, 226, 26, 210, 101, 9, 88, 100, 235, 41, 96, 109, 211, 138, 153, 95, 115, 149, 125, 196, 114, 99, 107, 14, 56, 64, 116, 8, 105, 6, 140, 137, 71, 91, 134, 164, 212, 139, 221, 198, 130, 12, 68, 83, 165, 80, 217, 98, 154, 242, 195, 231, 19, 193, 144, 103, 172, 54, 169, 183, 39, 229, 245, 220, 157, 74, 32, 247, 49, 135, 167, 141, 181, 240, 194, 251, 128, 79, 175, 190, 150, 182, 155 };
        //великий Джа сказал "апще апасные массивы"
        static int[] _c = new int[2192] { 1363, 1764, 639, 740, 372, 883, 347, 160, 1240, 1262, 168, 1639, 323, 1373, 648, 237, 1368, 1310, 151, 493, 1119, 98, 205, 1283, 444, 1284, 1144, 361, 2131, 1454, 1963, 78, 1703, 461, 1972, 1955, 221, 1465, 254, 2113, 1708, 743, 2115, 1381, 297, 1138, 114, 1462, 1501, 331, 624, 325, 2012, 586, 1686, 1331, 847, 550, 1053, 1922, 817, 380, 416, 1785, 234, 1268, 674, 220, 2007, 9, 1505, 43, 915, 1276, 288, 878, 592, 607, 2134, 1438, 343, 75, 903, 240, 2079, 1602, 2089, 2163, 2075, 719, 585, 290, 10, 1139, 678, 993, 1389, 990, 780, 1479, 764, 2063, 435, 2024, 790, 796, 1941, 937, 742, 1847, 487, 61, 1067, 1011, 1956, 1305, 1469, 625, 785, 310, 846, 235, 1023, 2049, 620, 1227, 1588, 1924, 167, 1509, 612, 2165, 1952, 1180, 1304, 1379, 2175, 485, 1947, 308, 1739, 2152, 1600, 773, 770, 1154, 1236, 111, 1332, 162, 1371, 2184, 825, 768, 891, 961, 1546, 1223, 1594, 1057, 36, 230, 1314, 2004, 583, 55, 101, 973, 1127, 2117, 302, 369, 527, 329, 1351, 1348, 1378, 705, 1528, 291, 856, 491, 794, 1282, 1653, 809, 1504, 1106, 1951, 402, 215, 1440, 806, 45, 1078, 2191, 364, 545, 2047, 355, 721, 1084, 1846, 766, 1896, 1004, 834, 370, 667, 1307, 163, 1015, 1994, 1567, 708, 1341, 1678, 1292, 119, 2166, 30, 1798, 2156, 1737, 2187, 2100, 2154, 1370, 2076, 258, 1255, 1741, 661, 802, 952, 914, 2046, 999, 426, 1096, 746, 1878, 349, 279, 1808, 2072, 1907, 928, 2132, 1202, 1857, 868, 1323, 1018, 974, 1098, 801, 968, 2028, 1826, 2158, 1086, 1984, 1946, 1419, 131, 1493, 1327, 2010, 596, 1673, 137, 750, 1869, 410, 692, 619, 85, 227, 1845, 1472, 56, 1705, 822, 673, 549, 2188, 1494, 269, 2168, 2153, 2074, 1251, 2096, 1496, 866, 1264, 112, 1108, 1684, 627, 1742, 34, 327, 1012, 157, 351, 79, 1814, 886, 1201, 1447, 72, 509, 1330, 1422, 186, 1843, 1289, 1273, 1713, 977, 1391, 1485, 165, 1521, 1540, 1288, 1816, 1627, 128, 478, 192, 1612, 2123, 139, 1933, 82, 152, 130, 483, 1497, 1626, 614, 1024, 248, 1254, 638, 1317, 1614, 1792, 367, 718, 1781, 1851, 1731, 1662, 126, 1157, 191, 2039, 278, 1772, 572, 1597, 464, 864, 1477, 726, 1910, 779, 1174, 621, 1333, 821, 144, 828, 1721, 1406, 174, 955, 1286, 250, 150, 684, 135, 1838, 1679, 1860, 486, 143, 1452, 1919, 424, 1533, 1629, 1599, 1839, 480, 1608, 534, 850, 15, 1908, 1446, 1183, 1672, 506, 1234, 429, 358, 1691, 1052, 996, 321, 196, 2065, 2105, 1334, 326, 2000, 906, 1022, 666, 1852, 2060, 341, 1250, 414, 301, 720, 146, 1830, 1263, 2147, 5, 2118, 1877, 365, 975, 28, 25, 1574, 606, 1295, 1667, 565, 2161, 338, 2092, 632, 436, 932, 1641, 1791, 1085, 1983, 602, 316, 1417, 970, 1689, 502, 2064, 1973, 1039, 58, 833, 2180, 330, 1476, 42, 2125, 1849, 1921, 600, 959, 277, 1319, 122, 1858, 106, 244, 1969, 1593, 1811, 433, 1748, 23, 964, 1506, 427, 1299, 1848, 656, 1125, 1719, 2, 1301, 1631, 18, 782, 1175, 788, 1971, 978, 1247, 1978, 1906, 717, 2093, 908, 1864, 986, 1536, 1316, 2027, 51, 1148, 745, 651, 1949, 307, 1219, 383, 1774, 1553, 1313, 691, 776, 2035, 1754, 404, 811, 645, 501, 1200, 804, 1709, 829, 577, 172, 608, 1998, 953, 2108, 658, 1549, 1628, 481, 715, 1162, 1261, 1650, 333, 32, 409, 1604, 786, 1666, 969, 1141, 584, 1801, 1176, 1999, 1303, 381, 2013, 1740, 356, 1889, 1216, 1486, 1530, 571, 554, 2170, 949, 1344, 173, 1895, 1006, 1048, 1221, 413, 580, 1761, 1208, 319, 1675, 739, 538, 334, 1580, 531, 198, 1905, 887, 2103, 175, 1960, 421, 1030, 704, 1618, 841, 1215, 578, 888, 1311, 20, 1927, 737, 1610, 1928, 911, 797, 465, 463, 2080, 1169, 2142, 2138, 53, 1743, 255, 1587, 1625, 2159, 1431, 1701, 39, 1488, 94, 734, 697, 874, 1796, 1069, 1309, 109, 1335, 303, 1829, 289, 893, 925, 1013, 789, 579, 2144, 0, 954, 2018, 2054, 418, 2042, 256, 507, 1045, 2055, 2145, 84, 2167, 1923, 859, 1134, 305, 194, 169, 1360, 867, 1964, 1231, 530, 1633, 1090, 1766, 712, 1432, 732, 1212, 641, 346, 100, 814, 1950, 2034, 909, 1562, 876, 2070, 1755, 1418, 1620, 1290, 88, 918, 1137, 104, 1824, 526, 393, 118, 2069, 1573, 1403, 1966, 618, 979, 575, 92, 350, 207, 756, 948, 1297, 1636, 1982, 623, 1590, 1014, 1635, 1104, 757, 1459, 344, 455, 236, 2025, 2087, 2124, 1003, 456, 1806, 1160, 1699, 763, 27, 1676, 1683, 86, 1325, 892, 1818, 412, 1171, 479, 193, 617, 1017, 2058, 1894, 440, 488, 246, 1872, 1681, 348, 1997, 1450, 533, 1376, 912, 1912, 665, 898, 1434, 1480, 117, 2021, 1233, 615, 936, 1124, 1552, 1680, 907, 1190, 2129, 1660, 593, 1226, 466, 238, 50, 1153, 1198, 1617, 212, 988, 1759, 270, 19, 749, 1260, 1692, 1986, 536, 1518, 1718, 1120, 634, 1510, 1909, 1445, 62, 407, 419, 1172, 1720, 1409, 1107, 1123, 1690, 16, 127, 1413, 224, 1159, 337, 758, 995, 462, 1189, 1827, 1214, 1329, 1823, 1337, 2015, 312, 655, 722, 399, 1797, 2174, 11, 1421, 598, 232, 498, 610, 1043, 835, 1402, 1339, 1944, 1110, 1517, 2173, 2186, 1249, 812, 1016, 1113, 736, 687, 2008, 2182, 2003, 902, 879, 314, 933, 1256, 35, 1213, 647, 916, 1362, 257, 795, 1677, 1991, 1237, 860, 1122, 392, 880, 428, 670, 354, 415, 406, 313, 1704, 646, 1669, 1274, 1321, 158, 384, 1129, 1735, 939, 889, 992, 1049, 706, 129, 741, 2135, 2032, 379, 1193, 148, 1605, 1312, 223, 1821, 1423, 1592, 1388, 1981, 635, 1854, 1693, 1076, 1102, 807, 1773, 64, 458, 218, 1787, 1031, 1042, 1093, 695, 1649, 1315, 1468, 1147, 17, 548, 1535, 1026, 1756, 41, 557, 1687, 570, 1071, 1481, 1142, 1326, 276, 1511, 1364, 709, 374, 188, 1094, 37, 1492, 1420, 216, 1156, 559, 967, 976, 1027, 1977, 1296, 123, 669, 1918, 59, 1140, 99, 899, 204, 233, 972, 761, 1545, 2172, 1916, 1862, 1550, 1723, 1252, 1938, 1882, 1354, 873, 2143, 1901, 96, 516, 1385, 1232, 1178, 1197, 1579, 2185, 1165, 1624, 1958, 195, 1727, 1179, 180, 707, 1229, 265, 460, 1126, 1621, 156, 622, 1856, 727, 854, 1647, 2149, 816, 616, 1064, 2140, 2086, 2169, 958, 2045, 1439, 2077, 1783, 1825, 1914, 1993, 1384, 1622, 819, 561, 1455, 1942, 762, 420, 528, 650, 434, 1634, 1776, 1664, 1041, 1805, 1503, 2067, 132, 209, 1514, 219, 1717, 848, 184, 863, 182, 844, 626, 2190, 956, 2068, 711, 1663, 1508, 613, 1813, 336, 46, 451, 1794, 511, 2041, 1435, 2002, 652, 1696, 1630, 1850, 1544, 895, 1308, 767, 422, 1874, 280, 1478, 2133, 781, 1275, 1358, 1340, 1470, 145, 960, 1619, 211, 1868, 1109, 476, 1519, 345, 2101, 225, 1799, 1606, 1009, 213, 751, 52, 690, 1034, 1005, 14, 1451, 497, 1892, 657, 872, 304, 713, 1158, 1930, 1655, 1959, 203, 518, 2110, 1777, 1306, 1656, 2071, 1357, 90, 1038, 1483, 1377, 1035, 865, 747, 1164, 609, 1280, 1932, 403, 1967, 249, 431, 2139, 1744, 1961, 935, 1073, 1688, 663, 1522, 2181, 1763, 2141, 1149, 1336, 1072, 1507, 342, 1523, 842, 543, 332, 107, 919, 1392, 1163, 1008, 1278, 1929, 1115, 208, 386, 630, 214, 242, 1029, 1044, 1694, 710, 1258, 1170, 134, 611, 1074, 894, 1863, 1822, 542, 1411, 1644, 1888, 1271, 470, 1346, 539, 1394, 699, 245, 13, 1565, 2116, 1355, 1279, 1582, 1988, 1046, 853, 1001, 2048, 628, 2107, 1779, 941, 1948, 1520, 1782, 1844, 774, 1904, 1833, 569, 1841, 1429, 775, 855, 1512, 222, 199, 685, 1596, 1293, 296, 1182, 576, 1184, 176, 366, 1702, 1767, 2119, 605, 851, 1502, 65, 1443, 1404, 1913, 2019, 679, 962, 951, 179, 905, 187, 980, 1733, 468, 1224, 1897, 839, 1146, 320, 563, 285, 283, 1525, 1151, 1623, 1911, 1083, 1050, 1534, 447, 924, 1097, 1272, 601, 239, 206, 1671, 1287, 1491, 1513, 1414, 2099, 668, 920, 48, 1807, 1225, 997, 49, 1467, 115, 2112, 110, 1133, 629, 298, 1746, 724, 2177, 1788, 1228, 2183, 1430, 31, 1809, 1500, 2091, 166, 1112, 1099, 869, 537, 2040, 467, 1007, 26, 71, 1398, 1059, 830, 385, 966, 1068, 500, 1095, 1532, 1917, 1659, 1241, 1722, 448, 2136, 524, 1716, 2171, 765, 664, 897, 1416, 631, 21, 54, 564, 1802, 1581, 1992, 1192, 2066, 1285, 885, 714, 1771, 566, 1729, 1885, 1778, 588, 1487, 1369, 1568, 1812, 430, 535, 1563, 1632, 1572, 125, 1638, 1734, 1405, 1554, 1668, 87, 1835, 70, 772, 2051, 2088, 1828, 1063, 1970, 1880, 177, 1710, 581, 1566, 1187, 2120, 1643, 77, 799, 2155, 689, 1890, 450, 787, 1300, 783, 890, 1101, 1558, 1770, 754, 1428, 1396, 2073, 793, 985, 963, 877, 1051, 282, 503, 540, 1561, 633, 1853, 387, 266, 1670, 1601, 287, 1987, 400, 2050, 823, 181, 981, 1484, 425, 1990, 1793, 1876, 1834, 1168, 1070, 1135, 1324, 1367, 300, 1945, 178, 701, 1578, 1267, 445, 1395, 1167, 63, 2038, 582, 1079, 748, 1056, 1473, 702, 815, 1516, 1186, 1881, 1408, 2011, 1674, 2023, 1697, 826, 1415, 858, 676, 1658, 1954, 1979, 917, 3, 149, 1775, 1957, 904, 275, 1836, 2057, 1259, 725, 398, 929, 923, 800, 81, 599, 499, 544, 76, 2059, 1353, 755, 1576, 91, 1088, 1883, 1203, 1751, 1066, 508, 2005, 1736, 390, 901, 1575, 1819, 432, 437, 971, 1651, 1595, 682, 1642, 1564, 2009, 926, 6, 183, 1188, 2104, 457, 2111, 1173, 832, 1583, 1538, 396, 1637, 1730, 660, 251, 532, 1539, 2146, 1374, 2148, 1065, 1865, 2031, 411, 1585, 849, 2098, 1661, 698, 728, 831, 862, 515, 2162, 1758, 155, 1441, 108, 4, 716, 1375, 1277, 264, 1032, 555, 1143, 1570, 360, 2127, 142, 1867, 324, 1577, 1087, 1209, 185, 1548, 1265, 22, 1584, 2095, 322, 2044, 595, 47, 1832, 1253, 2157, 2016, 837, 987, 1871, 672, 803, 729, 2106, 1831, 1886, 328, 2097, 637, 1607, 438, 521, 1100, 934, 913, 1366, 335, 1495, 791, 1715, 210, 2062, 1541, 113, 170, 1711, 574, 546, 471, 1390, 989, 1489, 553, 105, 1786, 1359, 671, 1551, 1291, 1019, 2114, 1281, 44, 520, 1220, 568, 1222, 1884, 1343, 1526, 556, 74, 882, 494, 1749, 1062, 921, 1242, 489, 442, 60, 93, 1615, 752, 1054, 838, 253, 382, 2128, 1453, 1840, 217, 495, 2178, 262, 1747, 1934, 1657, 1752, 1555, 1338, 1762, 944, 644, 1724, 1111, 1460, 147, 643, 1426, 1036, 121, 268, 229, 1204, 1803, 512, 1790, 957, 1925, 1645, 2026, 133, 875, 1380, 1654, 2179, 1586, 1685, 861, 376, 1937, 260, 945, 272, 1899, 798, 1768, 662, 703, 1000, 1401, 525, 2043, 1817, 154, 1424, 2121, 1939, 2014, 2020, 1132, 1926, 1800, 1902, 1953, 1210, 654, 942, 950, 295, 1560, 910, 881, 1542, 1873, 231, 1191, 2176, 7, 492, 1060, 273, 1155, 653, 541, 927, 1616, 551, 567, 1347, 120, 900, 1196, 40, 2036, 1537, 1603, 1698, 2102, 1412, 69, 1294, 2017, 352, 1080, 1760, 1206, 857, 1145, 1598, 1765, 2029, 1207, 189, 675, 1457, 1322, 1387, 1116, 318, 649, 1002, 1915, 83, 1037, 1103, 2053, 589, 1985, 1900, 1471, 769, 735, 1935, 1975, 452, 1058, 852, 1976, 371, 870, 317, 1543, 357, 1131, 784, 1769, 1150, 1943, 723, 1879, 760, 505, 1328, 1499, 1750, 642, 1061, 1114, 293, 1464, 1118, 2084, 792, 1195, 1789, 587, 1246, 1962, 603, 562, 560, 353, 1529, 1081, 1936, 820, 243, 818, 1527, 417, 730, 1217, 57, 124, 2022, 946, 453, 1, 2052, 1456, 686, 1040, 1903, 1410, 1515, 1437, 2160, 395, 896, 309, 1047, 808, 1458, 1461, 1609, 368, 1152, 1968, 388, 1482, 1920, 529, 2006, 1859, 38, 1383, 2109, 136, 1712, 994, 2082, 1571, 1804, 362, 1442, 1020, 1075, 1448, 1365, 1861, 1248, 1463, 315, 824, 1194, 459, 496, 1302, 1965, 1361, 1257, 12, 640, 405, 984, 363, 738, 522, 930, 982, 1810, 1780, 1400, 1449, 1753, 1350, 1732, 375, 1345, 1218, 294, 1199, 401, 475, 284, 597, 1648, 1121, 73, 80, 1028, 306, 938, 197, 1269, 33, 1238, 523, 241, 1342, 299, 1611, 688, 389, 1974, 1077, 474, 2189, 805, 1427, 394, 733, 1891, 1995, 263, 1177, 991, 116, 884, 1557, 377, 547, 2085, 947, 2126, 140, 681, 1382, 261, 2090, 472, 2130, 391, 24, 274, 693, 66, 443, 1893, 683, 594, 267, 161, 2164, 292, 1055, 871, 1652, 469, 1372, 845, 2061, 1444, 777, 1898, 1356, 517, 1842, 827, 510, 8, 103, 1466, 286, 1243, 153, 604, 753, 504, 1559, 67, 965, 1136, 843, 680, 983, 1433, 1613, 228, 1887, 694, 378, 1569, 1707, 2122, 759, 439, 1524, 423, 1298, 1745, 1399, 513, 1547, 1211, 373, 840, 29, 1714, 558, 1726, 397, 1010, 998, 408, 1181, 2094, 1757, 1320, 1931, 339, 1870, 1700, 1161, 1021, 1397, 1866, 482, 1784, 1436, 1105, 477, 1393, 2056, 1815, 696, 1728, 202, 1205, 1725, 1556, 97, 1682, 1025, 677, 771, 441, 1266, 2030, 200, 1989, 1996, 1239, 1589, 1425, 1706, 1245, 813, 1166, 2037, 2150, 1082, 490, 1475, 1820, 359, 1837, 1665, 940, 1875, 259, 1092, 68, 1474, 311, 1407, 1128, 271, 1270, 1089, 744, 454, 1349, 1795, 836, 1033, 1940, 2001, 141, 2078, 1244, 1235, 591, 449, 659, 95, 922, 484, 519, 252, 931, 1185, 89, 171, 1490, 473, 1855, 1531, 247, 1640, 778, 636, 226, 446, 1498, 1318, 1230, 190, 1117, 2033, 1980, 943, 2137, 138, 102, 1695, 1646, 573, 810, 340, 2151, 700, 1738, 201, 731, 1130, 1591, 1352, 2081, 1386, 159, 590, 1091, 2083, 514, 164, 281, 552 };
        static int[] _d = new int[2192] { 652, 1861, 497, 1484, 1568, 435, 1530, 1751, 2014, 69, 92, 838, 1915, 1206, 1115, 402, 816, 935, 500, 794, 611, 1351, 1588, 488, 1987, 441, 1326, 739, 440, 2051, 220, 1314, 555, 1949, 302, 867, 160, 955, 1888, 632, 1766, 940, 471, 71, 1644, 193, 1070, 1594, 1295, 1299, 786, 517, 1111, 624, 1352, 165, 281, 1856, 466, 969, 1662, 111, 807, 1459, 923, 1251, 1990, 2024, 2116, 1773, 1385, 1327, 312, 1942, 1653, 81, 1502, 1400, 31, 307, 1943, 1498, 337, 1796, 663, 277, 742, 1383, 697, 2146, 1135, 1507, 712, 1663, 634, 2139, 990, 2085, 21, 971, 685, 166, 2168, 2015, 700, 1635, 481, 1170, 1567, 641, 1303, 147, 297, 1625, 46, 1301, 1971, 770, 704, 218, 1763, 1693, 479, 966, 1857, 1377, 357, 817, 330, 901, 339, 265, 1050, 1704, 1189, 385, 1891, 271, 2167, 335, 1979, 2132, 1579, 390, 375, 1095, 431, 1689, 907, 1485, 383, 18, 338, 2019, 1727, 1565, 1011, 305, 892, 2184, 7, 1996, 149, 210, 2189, 324, 1318, 128, 10, 670, 1626, 2147, 541, 580, 379, 600, 1243, 1393, 1452, 1259, 1004, 1437, 1058, 1531, 1056, 1585, 316, 1261, 953, 1786, 2161, 359, 332, 749, 669, 1001, 415, 1947, 596, 1235, 2093, 2177, 2081, 1127, 973, 22, 1286, 714, 1178, 1051, 1622, 1098, 790, 1109, 1181, 190, 958, 1673, 925, 1053, 67, 36, 1234, 910, 819, 1105, 2156, 278, 2032, 1695, 161, 1748, 841, 974, 64, 121, 729, 15, 785, 1285, 83, 1952, 1182, 1850, 482, 1205, 756, 2152, 345, 1148, 382, 1544, 2143, 1668, 38, 626, 658, 872, 229, 2114, 1714, 1982, 1676, 1968, 1572, 1007, 1429, 1995, 1694, 288, 793, 2121, 1716, 1754, 1988, 1489, 948, 477, 361, 243, 1087, 2190, 1422, 1272, 1938, 1271, 2017, 1432, 74, 645, 91, 179, 1998, 1832, 1934, 1742, 1239, 44, 1306, 1954, 1450, 429, 170, 643, 1121, 668, 1945, 522, 139, 1873, 119, 2118, 832, 886, 864, 1906, 458, 1814, 1792, 589, 1269, 414, 1591, 12, 1581, 51, 419, 303, 1608, 173, 469, 49, 1169, 554, 593, 1618, 1069, 821, 448, 2064, 2173, 426, 1165, 80, 727, 1103, 684, 6, 759, 242, 713, 306, 1776, 1845, 883, 199, 570, 1816, 410, 2109, 1577, 27, 1897, 1919, 196, 438, 1244, 351, 1879, 171, 207, 1812, 4, 2049, 952, 1931, 1712, 1974, 2035, 905, 61, 567, 1669, 524, 893, 1331, 1179, 1428, 1882, 1957, 1516, 1986, 879, 703, 1964, 1871, 1540, 2055, 1494, 835, 1434, 1936, 189, 1146, 532, 1917, 885, 808, 2058, 556, 274, 1553, 746, 585, 428, 884, 62, 1853, 656, 809, 1039, 602, 1085, 2042, 393, 1440, 238, 491, 881, 409, 1372, 1149, 1520, 486, 1042, 102, 451, 1521, 1612, 2040, 754, 2090, 1661, 1991, 24, 1456, 2157, 1280, 1341, 2137, 1405, 1071, 1808, 1860, 2125, 728, 734, 1534, 924, 1909, 1008, 33, 824, 619, 365, 618, 784, 1324, 1264, 2002, 1200, 1630, 1984, 2149, 1960, 1937, 1101, 2075, 331, 748, 398, 549, 2071, 340, 2141, 137, 389, 110, 755, 1660, 2106, 181, 1752, 19, 1655, 1674, 1910, 1117, 842, 1500, 1334, 535, 462, 1423, 2022, 1825, 407, 659, 1513, 313, 2013, 1073, 1698, 2046, 2188, 1562, 991, 2010, 1128, 2142, 1645, 1613, 1921, 1951, 1343, 1724, 702, 172, 1040, 1885, 675, 595, 1545, 762, 400, 1373, 799, 1322, 592, 1202, 1424, 1757, 1195, 1168, 1501, 197, 1629, 1975, 936, 285, 57, 1760, 2191, 1634, 576, 1574, 1652, 941, 2053, 960, 1844, 1035, 1843, 1270, 1353, 446, 1363, 1761, 1647, 1228, 943, 575, 363, 2171, 1628, 711, 1241, 540, 608, 650, 586, 1395, 1461, 164, 562, 90, 53, 1839, 1367, 1800, 2185, 2136, 76, 782, 1994, 1593, 269, 1939, 840, 1499, 475, 1284, 457, 1842, 2020, 1248, 443, 77, 542, 1143, 843, 1190, 130, 1067, 343, 773, 1019, 750, 709, 276, 124, 372, 1012, 720, 50, 117, 1060, 300, 1217, 1305, 1180, 1350, 450, 1426, 803, 916, 2155, 1610, 347, 2, 1916, 683, 1829, 1690, 1685, 534, 888, 869, 14, 1793, 1041, 520, 1077, 1756, 1739, 833, 494, 1119, 546, 2138, 1543, 232, 1720, 1156, 1347, 766, 423, 208, 1293, 967, 882, 1638, 1602, 284, 66, 1787, 1479, 2088, 94, 1256, 2028, 1980, 1525, 1993, 384, 1236, 1864, 858, 1956, 1403, 1112, 528, 275, 1989, 2034, 930, 2079, 636, 1558, 1204, 2175, 1453, 1466, 1721, 604, 177, 900, 1005, 214, 951, 1186, 1064, 679, 1122, 1361, 550, 1569, 509, 352, 89, 430, 200, 834, 1822, 1308, 1493, 368, 1014, 1559, 1604, 1854, 2178, 681, 1965, 635, 1805, 857, 613, 1920, 591, 3, 902, 108, 41, 2124, 519, 240, 1141, 1463, 795, 272, 1110, 1665, 2021, 1413, 1505, 715, 725, 822, 2039, 1824, 976, 1038, 738, 100, 1346, 203, 1084, 153, 1804, 144, 2089, 1386, 143, 1225, 1231, 529, 2007, 2154, 370, 98, 1090, 501, 1408, 1818, 118, 558, 1406, 503, 649, 104, 1620, 1836, 1417, 182, 873, 105, 617, 1718, 1401, 1497, 256, 233, 1603, 537, 1962, 192, 921, 1875, 185, 2172, 533, 854, 2101, 686, 1467, 1018, 60, 1851, 1034, 1849, 374, 283, 1436, 1907, 152, 1476, 2012, 376, 539, 1330, 1560, 1537, 467, 206, 845, 2128, 1599, 1667, 1267, 2050, 606, 1167, 2027, 1059, 2004, 120, 56, 1055, 1555, 401, 1249, 1810, 1214, 1015, 1232, 180, 1780, 1478, 666, 877, 1711, 1561, 1057, 366, 1140, 295, 672, 251, 1321, 1813, 2000, 1120, 987, 637, 1705, 691, 1420, 75, 863, 880, 1745, 1654, 5, 1972, 1360, 309, 598, 609, 897, 1409, 154, 744, 646, 1192, 1082, 1872, 1348, 767, 972, 1764, 1517, 862, 82, 1488, 1260, 421, 778, 511, 689, 1744, 616, 764, 1616, 235, 72, 870, 1483, 698, 1171, 1294, 1658, 2140, 1496, 1281, 647, 1529, 1758, 247, 1495, 1922, 2144, 452, 865, 1615, 1153, 774, 107, 1946, 896, 2112, 1220, 1740, 2165, 1684, 1715, 1859, 1977, 716, 578, 1741, 1258, 234, 544, 653, 380, 1062, 1700, 1024, 476, 1096, 155, 1257, 1419, 489, 2025, 1332, 961, 257, 560, 460, 1522, 975, 167, 254, 439, 962, 321, 505, 710, 1262, 1438, 1923, 2029, 1918, 1418, 513, 1600, 791, 1632, 97, 1970, 898, 95, 1893, 823, 413, 1298, 2057, 237, 1722, 1215, 1794, 733, 205, 1114, 582, 1325, 1174, 1108, 2056, 113, 304, 648, 722, 211, 855, 751, 253, 1641, 1899, 2068, 422, 122, 344, 2087, 938, 963, 1944, 1183, 603, 927, 1573, 2129, 1113, 1139, 1692, 1797, 1136, 465, 1865, 1046, 928, 844, 1184, 660, 1213, 1874, 583, 899, 1278, 1421, 412, 58, 1666, 1999, 1464, 159, 1809, 1329, 1753, 1830, 1657, 1390, 1020, 1550, 1512, 112, 1333, 639, 1446, 944, 1163, 1154, 1191, 1900, 919, 1959, 194, 1462, 1777, 1847, 2105, 1277, 201, 455, 261, 1583, 1508, 2123, 677, 2186, 2115, 929, 954, 1335, 239, 1282, 255, 1320, 1614, 1410, 920, 1798, 724, 2074, 187, 813, 298, 1100, 849, 1687, 1319, 856, 1831, 1177, 1791, 2162, 1834, 20, 802, 1941, 878, 814, 775, 495, 1009, 168, 2120, 894, 2179, 1817, 1733, 1304, 667, 1447, 2026, 699, 45, 93, 970, 561, 946, 1575, 26, 1781, 1268, 934, 518, 1161, 1820, 1274, 1880, 787, 145, 1755, 959, 358, 1123, 820, 736, 2067, 551, 1173, 1142, 998, 2102, 1458, 1445, 621, 1188, 747, 810, 1536, 371, 502, 564, 1969, 994, 1003, 133, 2059, 1240, 405, 1242, 2145, 1469, 1397, 1532, 825, 779, 1749, 1357, 906, 1908, 1837, 1765, 995, 788, 1935, 536, 310, 249, 1510, 1696, 2082, 1779, 1785, 588, 1584, 1738, 2048, 682, 868, 827, 607, 572, 1855, 1933, 523, 1646, 584, 1648, 157, 1265, 1297, 783, 125, 1311, 1006, 2160, 674, 993, 772, 408, 2135, 146, 876, 1950, 2096, 8, 1339, 1659, 2018, 2134, 2100, 1840, 506, 1904, 853, 427, 292, 983, 1596, 346, 230, 866, 1914, 1187, 1492, 796, 552, 9, 433, 296, 1587, 2091, 1455, 65, 1948, 2122, 1199, 1283, 319, 890, 1091, 73, 1571, 1175, 1210, 1144, 1643, 183, 23, 25, 1359, 381, 1288, 327, 318, 696, 1640, 217, 1238, 1774, 444, 965, 717, 2043, 492, 1407, 498, 1911, 566, 134, 115, 1131, 209, 1083, 640, 17, 610, 909, 527, 162, 932, 515, 348, 2159, 478, 2062, 891, 1789, 252, 1448, 743, 947, 267, 1826, 828, 314, 55, 148, 373, 418, 642, 1162, 830, 1682, 847, 1093, 215, 1953, 1650, 579, 1932, 1201, 1762, 175, 2126, 1929, 174, 2181, 1504, 986, 1209, 2009, 1134, 1092, 1637, 671, 1913, 871, 0, 950, 1902, 1617, 1449, 16, 1369, 227, 150, 2003, 13, 1548, 1570, 763, 1138, 176, 135, 1706, 43, 1981, 1889, 1032, 992, 2183, 1790, 914, 96, 1631, 322, 1172, 2076, 1203, 1457, 1415, 2069, 1328, 2045, 1926, 1723, 846, 707, 1253, 1380, 378, 2119, 1471, 812, 1867, 1196, 1772, 818, 1291, 1477, 1349, 459, 694, 264, 957, 839, 315, 912, 1728, 2098, 1691, 1963, 1414, 1230, 1313, 630, 680, 2030, 768, 1075, 2073, 1869, 79, 1026, 191, 1566, 1898, 1252, 2006, 806, 404, 311, 1901, 1927, 761, 1116, 391, 1671, 29, 1036, 1863, 1788, 1876, 726, 1688, 1877, 47, 1905, 1833, 37, 2016, 1300, 933, 116, 1094, 1803, 280, 1465, 2117, 2107, 470, 367, 1088, 99, 769, 945, 1883, 1137, 1439, 323, 573, 1368, 633, 1633, 2148, 1289, 956, 266, 287, 1619, 294, 341, 2158, 1827, 1316, 48, 1250, 1048, 186, 70, 490, 1164, 1066, 129, 804, 949, 1233, 1290, 1052, 1868, 1468, 850, 800, 1102, 1222, 325, 1157, 1166, 2041, 1273, 1651, 1852, 178, 1846, 574, 2151, 1336, 394, 1279, 937, 514, 1768, 1539, 1546, 326, 1624, 1746, 1815, 1081, 977, 156, 2047, 1586, 547, 981, 1639, 776, 526, 1381, 1681, 2084, 1973, 1411, 2023, 1743, 1425, 690, 1374, 1527, 1207, 1396, 213, 1370, 2036, 1576, 1895, 1376, 706, 442, 1518, 1506, 1582, 1454, 996, 594, 1355, 1211, 1538, 1589, 1554, 1709, 627, 126, 2097, 721, 2180, 913, 484, 158, 1524, 1237, 364, 1782, 396, 142, 1431, 85, 1769, 557, 908, 1107, 1611, 399, 1878, 614, 1955, 333, 2031, 349, 1664, 1759, 789, 605, 1097, 695, 1010, 1033, 1275, 999, 628, 342, 329, 548, 395, 1079, 499, 1375, 676, 1043, 723, 718, 1541, 1378, 11, 2153, 453, 1526, 1399, 1197, 1702, 2170, 1016, 1940, 931, 553, 1523, 2001, 184, 1707, 1125, 1132, 1679, 1480, 1338, 781, 1557, 356, 1065, 1045, 2111, 559, 445, 1382, 889, 1430, 1287, 406, 270, 1473, 590, 740, 874, 216, 387, 777, 758, 2086, 741, 299, 1710, 54, 942, 1155, 461, 815, 411, 797, 918, 1185, 2169, 1078, 1475, 1770, 737, 2066, 631, 1245, 32, 887, 282, 2099, 2037, 40, 538, 1394, 1627, 1892, 320, 2052, 1621, 1344, 1054, 801, 496, 811, 377, 1340, 982, 1686, 2083, 2054, 1002, 2080, 1364, 1542, 355, 1930, 1263, 1379, 895, 1515, 223, 2176, 140, 569, 231, 301, 625, 1151, 2044, 1307, 1677, 487, 1656, 1828, 1511, 1680, 1928, 531, 693, 939, 2061, 1564, 792, 1778, 587, 1683, 1159, 1, 1783, 678, 1246, 1719, 1819, 1412, 1362, 362, 922, 525, 1486, 1044, 1130, 1366, 1219, 1925, 353, 1223, 1028, 2072, 63, 1636, 926, 1310, 1838, 1699, 454, 350, 1442, 1072, 2127, 638, 836, 221, 1106, 1735, 563, 1354, 1697, 1896, 1047, 735, 1296, 244, 1315, 1924, 485, 1371, 1068, 308, 2078, 328, 1726, 745, 1519, 2108, 911, 1194, 829, 701, 1029, 259, 826, 1389, 644, 432, 1606, 1595, 1227, 1444, 1384, 1490, 2110, 386, 397, 1672, 1229, 2011, 317, 1224, 279, 202, 109, 493, 473, 1080, 354, 424, 1427, 917, 2150, 1013, 250, 480, 1887, 388, 1903, 980, 1193, 512, 1551, 2070, 1580, 1099, 273, 2065, 1601, 757, 1747, 1086, 2113, 1443, 437, 241, 1823, 1392, 1470, 985, 1509, 1649, 1365, 1607, 2033, 1198, 571, 1404, 1966, 1118, 1992, 753, 581, 204, 1266, 2008, 1717, 1802, 989, 1736, 1866, 1226, 597, 508, 246, 403, 805, 369, 1276, 765, 1254, 1030, 1795, 979, 1337, 968, 392, 1884, 474, 59, 665, 127, 1701, 1734, 612, 615, 1176, 1124, 2063, 1145, 336, 1678, 1806, 1848, 1713, 984, 1730, 2130, 106, 1037, 1821, 848, 1451, 263, 138, 1221, 521, 687, 188, 132, 1737, 1481, 35, 114, 1487, 1000, 1126, 601, 1152, 1841, 30, 673, 1912, 708, 1147, 1881, 483, 1391, 504, 34, 464, 1958, 1807, 1811, 964, 507, 1482, 2164, 915, 719, 456, 262, 1801, 798, 1433, 1212, 2094, 1441, 875, 1356, 1031, 212, 1967, 2095, 760, 543, 565, 420, 2131, 1076, 861, 163, 1514, 1886, 68, 859, 1528, 268, 1472, 52, 568, 1731, 831, 1598, 1775, 654, 1255, 1732, 771, 1858, 1474, 103, 730, 1703, 516, 258, 1784, 2092, 1552, 904, 2163, 688, 530, 1767, 2103, 1460, 360, 1323, 1074, 657, 1725, 1592, 1025, 236, 198, 1216, 123, 1435, 1387, 1862, 1799, 655, 661, 2077, 1491, 752, 1503, 425, 2005, 1623, 101, 463, 416, 1358, 1049, 1063, 705, 692, 1133, 245, 1416, 291, 88, 228, 1027, 2133, 84, 620, 2182, 1894, 2187, 1835, 1976, 1022, 731, 1388, 86, 1983, 1317, 449, 510, 2060, 1590, 293, 1609, 1556, 1292, 225, 1104, 1771, 599, 1533, 417, 1605, 1218, 545, 1890, 1129, 1535, 1302, 39, 1642, 42, 1208, 169, 436, 1247, 1398, 1729, 2038, 334, 732, 472, 1978, 1578, 1670, 780, 1985, 28, 248, 1089, 78, 903, 1342, 2166, 623, 1150, 1021, 1160, 622, 988, 651, 662, 1547, 434, 1549, 1017, 2104, 2174, 141, 290, 226, 1402, 222, 1597, 260, 629, 1870, 447, 1563, 87, 1997, 131, 219, 664, 289, 1023, 577, 1345, 978, 851, 837, 136, 1750, 1309, 1675, 1708, 468, 1158, 860, 1312, 151, 997, 852, 224, 286, 1961, 1061, 195 };

        static int _enc(int b)
        {
            return _a[b];
        }
        static int _dec(int b)
        {
            return _b[b];
        }
        public static byte[] Encode(int[] b)
        {
            int[] a = new int[b.Length];
            byte[] outarr = new byte[b.Length];
            int i = 0;
            //замена байтов
            foreach (int c in b)
            {
                a[i] = _enc(c);
                i++;
            }
            //Перестановочный шифр
            int[] e = new int[b.Length];
            i = 0;
            foreach (int f in a)
            {
                e[_c[i]] = f;
                i++;
            }
            //конвертирование в байты
            i = 0;
            foreach (int d in e)
            {
                outarr[i] = (byte)d;
                i++;
            }
            a = null;
            b = null;
            e = null;
            return outarr;
        }
        public static int[] Decode(byte[] b)
        {
            int[] a = new int[b.Length];
            int i = 0;
            foreach (int c in b)
            {
                a[i] = c;
                i++;
            }
            i = 0;
            int[] d = new int[b.Length];
            foreach (int c in a)
            {
                d[i] = a[_c[i]];
                i++;
            }
            i = 0;
            foreach (int c in d)
            {
                d[i] = _dec(c);
                i++;
            }
            b = null;
            a = null;
            return d;
        }
    }
}
