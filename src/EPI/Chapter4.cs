
namespace EPI
{
    public class Chapter4
    {
        // Computing the parity of a word
        public class Problem_1_Parity
        {
            public static int Solution_1(uint number)
            {
                var result = 0;
                while (number > 0)
                {
                    result ^= (int)(number & 1);
                    number >>= 1;
                }

                return result;
            }

            public static int Solution_2(uint number)
            {
                var result = 0;
                while (number > 0)
                {
                    number = number & (number - 1);
                    result++;
                }

                return result & 0x01;
            }

            public static int Solution_3(uint number)
            {
                var masks = new int[0x100];
                for (uint i = 0; i < masks.Length; i++)
                {
                    masks[i] = Solution_1(i);
                }

                return masks[number & 0xff]
                    ^ masks[(number >> 8) & 0xff]
                    ^ masks[(number >> 16) & 0xff]
                    ^ masks[(number >> 24) & 0xff];
            }

            public static int Solution_4(uint number)
            {
                number = number ^ (number >> 16);
                number = number ^ (number >> 8);
                number = number ^ (number >> 4);
                number = number ^ (number >> 2);
                number = number ^ (number >> 1);

                return (int)(number & 0x01);
            }
        }
    }
}
