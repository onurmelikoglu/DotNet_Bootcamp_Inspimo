namespace HangmanDemo
{
    internal class Program
    {

        const int MaxAttempts = 6;

        enum GameState
        {
            Continue,
            Win,
            Lose,
            Exit
        }
        static void Main()
        {
            Console.WriteLine("Hangman Oyununa Hoşgeldiniz!");
        
            string secretWord = ChooseRandomWord(), gameController = string.Empty;
            char[] guessedWord = new char[secretWord.Length];
            bool[] letterGuessed = new bool[26]; // Daha önce kullanılan kelimeler
            int attemptsLeft = MaxAttempts; // Kalan  deneme sayısı

            InitializeGuessedWord(guessedWord);

            GameState gameState;

            do
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

                gameState = CheckGameState(guessedWord, attemptsLeft);

                if (gameState == GameState.Win || gameState == GameState.Lose)
                {
                    
                    if(gameState == GameState.Win)
                    {
                        Console.WriteLine($"Tebrikler Bildiniz!! Doğru kelime: {secretWord}");
                    }
                    else
                    {
                        Console.WriteLine($"Üzgünüm Kaybettiniz!! Doğru kelime: {secretWord}");
                    }
                    Console.WriteLine("Çıkmak için 'ç', tekrar oynamak için herhangi bir tuşa tıklayınız!!!");
                    if (Console.ReadLine() == "ç")
                    {
                        gameState = GameState.Exit;
                    }
                    else
                    {
                        secretWord = ChooseRandomWord();
                        guessedWord = new char[secretWord.Length];
                        InitializeGuessedWord(guessedWord);
                        letterGuessed = new bool[26];
                        attemptsLeft = MaxAttempts;
                    }
                }

            } while (gameState != GameState.Exit);


        }

        static GameState CheckGameState(char[] guessedWord, int attemptsLeft)
        {
            if (Array.IndexOf(guessedWord, '_') == -1)
            {
                return GameState.Win;
            }

            if (attemptsLeft == 0)
            {
                return GameState.Lose;
            }

            return GameState.Continue;
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

            Console.WriteLine(hangmanImages[MaxAttempts - attemptsLeft]);
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
