namespace QuikPW
{
    /// <summary>
    /// Generates random passwords 'quikly'
    /// </summary>
    public class PasswordGenerator
    {
        private readonly Random _random;
        private readonly List<char> chars;

        /// <summary>
        /// Generates random passwords 'quikly' uses preset list of characters
        /// </summary>
        public PasswordGenerator()
        {
            _random = new Random();
            chars = new List<char>()
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            '!',
            '@',
            '#',
            '$',
            '%',
            '^',
            '&',
            '*',
            '(',
            ')',
            '_',
            '+',
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9'
        };
        }

        /// <summary>
        /// Generates random passwords 'quikly' using the provided list of characters
        /// </summary>
        /// <param name="characterList"></param>
        public PasswordGenerator(List<char> characterList)
        {
            _random = new Random();
            chars = characterList;
        }

        /// <summary>
        /// Randomly generates a password based on the provided length (will not include escape characters)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GeneratePassword(int length)
        {
            string password = string.Empty;
            int i = 0;
            while (i < length)
            {
                password += chars[_random.Next(0,chars.Count)];
                i++;
            }
            return password;
        }

        /// <summary>
        /// Randomly generates a pin code based on the provided length
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public string GeneratePin(int length)
        {
            string password = string.Empty;
            int i = 0;
            while (i < length)
            {
                password += _random.Next(0, 9).ToString();
                i++;
            }
            return password;
        }
    }
}
