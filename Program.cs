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
            foreach (string line in data.Split(Environment.NewLine))
            {
                ulong bestLineJoltage = 0;
                for (int firstCharID = 0; firstCharID < line.Length; firstCharID++)
                {
                    char firstChar = line[firstCharID];
                    for (int secondCharID = firstCharID + 1; secondCharID < line.Length; secondCharID++)
                    {
                        char secondChar = line[secondCharID];
                        for (int thirdCharId = secondCharID + 1; thirdCharId < line.Length; thirdCharId++)
                        {
                            char thirdChar = line[thirdCharId];
                            for (int fourthCharId = thirdCharId + 1; fourthCharId < line.Length; fourthCharId++)
                            {
                                char fourthChar = line[fourthCharId];
                                for (int fifthCharId = fourthCharId + 1; fifthCharId < line.Length; fifthCharId++)
                                {
                                    char fifthChar = line[fifthCharId];
                                    for (int sixthCharId = fifthCharId + 1; sixthCharId < line.Length; sixthCharId++)
                                    {
                                        char sixthChar = line[sixthCharId];
                                        for (int seventhCharId = sixthCharId + 1; seventhCharId < line.Length; seventhCharId++)
                                        {
                                            char seventhChar = line[seventhCharId];
                                            for (int eighthCharId = seventhCharId + 1; eighthCharId < line.Length; eighthCharId++)
                                            {
                                                char eighthChar = line[eighthCharId];
                                                for (int ninthCharId = eighthCharId + 1; ninthCharId < line.Length; ninthCharId++)
                                                {
                                                    char ninthChar = line[ninthCharId];
                                                    for (int tenthCharId = ninthCharId + 1; tenthCharId < line.Length; tenthCharId++)
                                                    {
                                                        char tenthChar = line[tenthCharId];
                                                        for (int eleventhCharId = tenthCharId + 1; eleventhCharId < line.Length; eleventhCharId++)
                                                        {
                                                            char eleventhChar = line[eleventhCharId];
                                                            for (int twelthCharId = eleventhCharId + 1; twelthCharId < line.Length; twelthCharId++)
                                                            {
                                                                char twelthChar = line[twelthCharId];
                                                                StringBuilder sbJoltage = new StringBuilder(12);
                                                                sbJoltage.Append([firstChar, secondChar, thirdChar, fourthChar, fifthChar, sixthChar, seventhChar, eighthChar, ninthChar, tenthChar, eleventhChar, twelthChar]);
                                                                ulong joltage = Convert.ToUInt64(sbJoltage.ToString());
                                                                if (joltage > bestLineJoltage)
                                                                {
                                                                    bestLineJoltage = joltage;
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
                totalJoltage += bestLineJoltage;
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
