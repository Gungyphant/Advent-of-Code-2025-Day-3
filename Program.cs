using System.Text;

namespace AOC2025Day3
{
    internal class Program
    {
        static string PartOne(string data)
        {
            int totalJoltage = 0;
            foreach (string line in data.Split(Environment.NewLine))
            {
                int bestLineJoltage = 0;
                for (int firstCharID = 0; firstCharID < line.Length; firstCharID++)
                {
                    for (int secondCharID = firstCharID + 1; secondCharID < line.Length; secondCharID++)
                    {
                        string sJoltage = Convert.ToString(line[firstCharID]) + Convert.ToString(line[secondCharID]);
                        int joltage = Convert.ToInt32(sJoltage);
                        if (joltage > bestLineJoltage)
                        {
                            bestLineJoltage = joltage;
                        }
                    }
                }
                totalJoltage += bestLineJoltage;
            }
            return Convert.ToString(totalJoltage);
        }
        static string PartTwo(string data)
        {
            ulong totalJoltage = 0;
            int linesDone = 0;
            foreach (string line in data.Split(Environment.NewLine))
            {
                Console.WriteLine($"{linesDone/2.0}%");
                string bestLineJoltage = "000000000000";
                for (int firstCharID = 0; firstCharID < line.Length; firstCharID++)
                {
                    char firstChar = line[firstCharID];
                    string first1Char = new string([firstChar]);
                    if (Convert.ToUInt64(first1Char) < Convert.ToUInt64(bestLineJoltage[..1]))
                    {
                        continue;
                    }
                    for (int secondCharID = firstCharID + 1; secondCharID < line.Length; secondCharID++)
                    {
                        char secondChar = line[secondCharID];
                        string first2Char = first1Char + secondChar;
                        if (Convert.ToUInt64(first2Char) < Convert.ToUInt64(bestLineJoltage[..2]))
                        {
                            continue;
                        }
                        for (int thirdCharId = secondCharID + 1; thirdCharId < line.Length; thirdCharId++)
                        {
                            char thirdChar = line[thirdCharId];
                            string first3Char = first2Char + thirdChar;
                            if (Convert.ToUInt64(first3Char) < Convert.ToUInt64(bestLineJoltage[..3]))
                            {
                                continue;
                            }
                            for (int fourthCharId = thirdCharId + 1; fourthCharId < line.Length; fourthCharId++)
                            {
                                char fourthChar = line[fourthCharId];
                                string first4Char = first3Char + fourthChar;
                                if (Convert.ToUInt64(first4Char) < Convert.ToUInt64(bestLineJoltage[..4]))
                                {
                                    continue;
                                }
                                for (int fifthCharId = fourthCharId + 1; fifthCharId < line.Length; fifthCharId++)
                                {
                                    char fifthChar = line[fifthCharId];
                                    string first5Char = first4Char + fifthChar;
                                    if (Convert.ToUInt64(first5Char) < Convert.ToUInt64(bestLineJoltage[..5]))
                                    {
                                        continue;
                                    }
                                    for (int sixthCharId = fifthCharId + 1; sixthCharId < line.Length; sixthCharId++)
                                    {
                                        char sixthChar = line[sixthCharId];
                                        string first6Char = first5Char + sixthChar;
                                        if (Convert.ToUInt64(first6Char) < Convert.ToUInt64(bestLineJoltage[..6]))
                                        {
                                            continue;
                                        }
                                        for (int seventhCharId = sixthCharId + 1; seventhCharId < line.Length; seventhCharId++)
                                        {
                                            char seventhChar = line[seventhCharId];
                                            string first7Char = first6Char + seventhChar;
                                            if (Convert.ToUInt64(first7Char) < Convert.ToUInt64(bestLineJoltage[..7]))
                                            {
                                                continue;
                                            }
                                            for (int eighthCharId = seventhCharId + 1; eighthCharId < line.Length; eighthCharId++)
                                            {
                                                char eighthChar = line[eighthCharId];
                                                string first8Char = first7Char + eighthChar;
                                                if (Convert.ToUInt64(first8Char) < Convert.ToUInt64(bestLineJoltage[..8]))
                                                {
                                                    continue;
                                                }
                                                for (int ninthCharId = eighthCharId + 1; ninthCharId < line.Length; ninthCharId++)
                                                {
                                                    char ninthChar = line[ninthCharId];
                                                    string first9Char = first8Char + ninthChar;
                                                    if (Convert.ToUInt64(first9Char) < Convert.ToUInt64(bestLineJoltage[..9]))
                                                    {
                                                        continue;
                                                    }
                                                    for (int tenthCharId = ninthCharId + 1; tenthCharId < line.Length; tenthCharId++)
                                                    {
                                                        char tenthChar = line[tenthCharId];
                                                        string first10Char = first9Char + tenthChar;
                                                        if (Convert.ToUInt64(first10Char) < Convert.ToUInt64(bestLineJoltage[..10]))
                                                        {
                                                            continue;
                                                        }
                                                        for (int eleventhCharId = tenthCharId + 1; eleventhCharId < line.Length; eleventhCharId++)
                                                        {
                                                            char eleventhChar = line[eleventhCharId];
                                                            string first11Char = first10Char + eleventhChar;
                                                            if (Convert.ToUInt64(first11Char) < Convert.ToUInt64(bestLineJoltage[..11]))
                                                            {
                                                                continue;
                                                            }
                                                            for (int twelthCharId = eleventhCharId + 1; twelthCharId < line.Length; twelthCharId++)
                                                            {
                                                                char twelthChar = line[twelthCharId];
                                                                StringBuilder sbJoltage = new StringBuilder(12);
                                                                sbJoltage.Append([firstChar, secondChar, thirdChar, fourthChar, fifthChar, sixthChar, seventhChar, eighthChar, ninthChar, tenthChar, eleventhChar, twelthChar]);
                                                                ulong joltage = Convert.ToUInt64(sbJoltage.ToString());
                                                                if (joltage > Convert.ToUInt64(bestLineJoltage))
                                                                {
                                                                    bestLineJoltage = Convert.ToString(joltage);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                totalJoltage += Convert.ToUInt64(bestLineJoltage);
                linesDone++;
            }
            return Convert.ToString(totalJoltage);
        }
        static void Main()
        {
            string file = File.ReadAllText(@"../../../input.txt");
            Console.WriteLine(PartOne(file));
            Console.WriteLine(PartTwo(file));
        }
    }
}
