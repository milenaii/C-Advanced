using System;

namespace PasswordGenerator
{
    class RandomPasswordGenerator
    {
        private const string CapitalLetters =
                                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters =
                                    "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars =
                              "~!@#$%^&*()_+=**{}[]\\|':;.,/?<>";
        private const string AllChars = CapitalLetters +
                            SmallLetters + Digits + SpecialChars;

        private static Random rnd = new Random();
    }
}
