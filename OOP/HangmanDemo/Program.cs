namespace HangmanDemo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hangman Oyununa Hoşgeldiniz!");
        
            string secretWord = ChooseRandomWord(), gameController = string.Empty;
            char[] guessedWord = new char[secretWord.Length];
            bool[] letterGuessed = new bool[26]; // Daha önce kullanılan kelimeler
            int attemptsLeft = 6; // Kalan  deneme sayısı

            InitializeGuessedWord(guessedWord);

            while (gameController != "ç")
            {
                DisplayHangman(attemptsLeft);
                DisplayWord(guessedWord);

                char guessedLetter = GetValidGuess(letterGuessed);
                letterGuessed[guessedLetter - 'a'] = true;

                if (UpdateGuessedWord(secretWord, guessedWord, guessedLetter))
                {
                    Console.WriteLine("Doğru!");
                }
                else
                {
                    Console.WriteLine("Yanlış!");
                    attemptsLeft--;
                }

                if (Array.IndexOf(guessedWord, '_') == -1)
                {
                    Console.WriteLine("Tebrikler! Doğru kelime: " + secretWord);
                }

                if (attemptsLeft == 0)
                {
                    Console.WriteLine("Üzgünüm, hakkınız doldu. Doğru kelime: " + secretWord);
                   
                }

                if (attemptsLeft == 0 || Array.IndexOf(guessedWord, '_') == -1)
                {
                    Console.WriteLine("Çıkmak için ç, tekrar oynamak için herhangi bir tuşa tıklayınız!!!");
                    gameController = Console.ReadLine();
                    secretWord = ChooseRandomWord();
                    guessedWord = new char[secretWord.Length];
                    InitializeGuessedWord(guessedWord);
                    letterGuessed = new bool[26];
                    attemptsLeft = 6;
                }
            }

            

            
        }

        static string ChooseRandomWord()
        {
            string[] words = { "programlama", "elma", "armut", "tabanca", "sandalet", "sunuculuk", "karadelik" };
            Random random = new Random();
            return words[random.Next(words.Length)];
        }

        static void InitializeGuessedWord(char[] guessedWord)
        {
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }
        }

        static void DisplayHangman(int attemptsLeft)
        {
            string[] hangmanImages = {
                @"       ________
       |      |
       |
       |
       |
       |
    ___|___",
                @"      ________
       |      |
       |      O
       |
       |
       |
    ___|___",
                @"      ________
       |      |
       |      O
       |      |
       |
       |
    ___|___",
                @"      ________
       |      |
       |      O
       |     /|
       |
       |
    ___|___",
                @"      ________
       |      |
       |      O
       |     /|\
       |
       |
    ___|___",
                @"      ________
       |      |
       |      O
       |     /|\
       |     /
       |
    ___|___",
                @"      ________
       |      |
       |      O
       |     /|\
       |     / \
       |
    ___|___"
            };

            Console.WriteLine(hangmanImages[6 - attemptsLeft]);
        }

        static void DisplayWord(char[] guessedWord)
        {
            Console.Write("Kelime: ");
            foreach (char letter in guessedWord)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }

        static char GetValidGuess(bool[] letterGuessed)
        {
            char guessedLetter;

            while (true)
            {
                Console.Write("Bir harf tahmini giriniz: ");
                string input = Console.ReadLine().ToLower();

                if (input.Length == 1 && Char.IsLetter(input[0]))
                {
                    guessedLetter = input[0];
                    if (!letterGuessed[guessedLetter - 'a'])
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bu harfi daha önce kullandınız. Lütfen tekrar deneyiniz!");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı giriş. Lütfen bir harf giriniz...");
                }
            }

            return guessedLetter;
        }

        static bool UpdateGuessedWord(string secretWord, char[] guessedWord, char guessedLetter)
        {
            bool correctGuess = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guessedLetter)
                {
                    guessedWord[i] = guessedLetter;
                    correctGuess = true;
                }
            }

            return correctGuess;
        }
    }
}
