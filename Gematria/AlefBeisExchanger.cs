namespace PeinearyDevelopment.Libraries.Hebrew.Gematria
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AlefBeisExchanger
    {
        readonly Dictionary<int, char> GematriaToAlefBeisDictionary = new Dictionary<int, char>
                                                             {
                                                                 { 1, 'א' },
                                                                 { 2, 'ב' },
                                                                 { 3, 'ג' },
                                                                 { 4, 'ד' },
                                                                 { 5, 'ה' },
                                                                 { 6, 'ו' },
                                                                 { 7, 'ז' },
                                                                 { 8, 'ח' },
                                                                 { 9, 'ט' },
                                                                 { 10, 'י' },
                                                                 { 20, 'כ' },
                                                                 { 30, 'ל' },
                                                                 { 40, 'מ' },
                                                                 { 50, 'נ' },
                                                                 { 60, 'ס' },
                                                                 { 70, 'ע' },
                                                                 { 80, 'פ' },
                                                                 { 90, 'צ' },
                                                                 { 100, 'ק' },
                                                                 { 200, 'ר' },
                                                                 { 300, 'ש' },
                                                                 { 400, 'ת' }
                                                             };
        public Dictionary<char, OseExchanges> AlefBeisExchangerDictionary = new Dictionary<char, OseExchanges>
                                                             {
                                                                 { 'א', new OseExchanges { Gematria = 1, AtBash = 'ת', ShemHaOse = "אלף" } },
                                                                 { 'ב', new OseExchanges { Gematria = 2, AtBash = 'ש', ShemHaOse = "בית" } },
                                                                 { 'ג', new OseExchanges { Gematria = 3, AtBash = 'ר', ShemHaOse = "גימל" } },
                                                                 { 'ד', new OseExchanges { Gematria = 4, AtBash = 'ק', ShemHaOse = "דלת" } },
                                                                 { 'ה', new OseExchanges { Gematria = 5, AtBash = 'צ', ShemHaOse = "הא" } },
                                                                 { 'ו', new OseExchanges { Gematria = 6, AtBash = 'פ', ShemHaOse = "ואו" } },
                                                                 { 'ז', new OseExchanges { Gematria = 7, AtBash = 'ע', ShemHaOse = "זין" } },
                                                                 { 'ח', new OseExchanges { Gematria = 8, AtBash = 'ס', ShemHaOse = "חית" } },
                                                                 { 'ט', new OseExchanges { Gematria = 9, AtBash = 'נ', ShemHaOse = "טית" } },
                                                                 { 'י', new OseExchanges { Gematria = 10, AtBash = 'מ', ShemHaOse = "יוד" } },
                                                                 { 'כ', new OseExchanges { Gematria = 20, AtBash = 'ל', ShemHaOse = "כף" } },
                                                                 { 'ך', new OseExchanges { Gematria = 20, AtBash = 'ל', ShemHaOse = "כף" } },
                                                                 { 'ל', new OseExchanges { Gematria = 30, AtBash = 'כ', ShemHaOse = "למד" } },
                                                                 { 'מ', new OseExchanges { Gematria = 40, AtBash = 'י', ShemHaOse = "מם" } },
                                                                 { 'ם', new OseExchanges { Gematria = 40, AtBash = 'י', ShemHaOse = "מם" } },
                                                                 { 'נ', new OseExchanges { Gematria = 50, AtBash = 'ט', ShemHaOse = "נון" } },
                                                                 { 'ן', new OseExchanges { Gematria = 50, AtBash = 'ט', ShemHaOse = "נון" } },
                                                                 { 'ס', new OseExchanges { Gematria = 60, AtBash = 'ח', ShemHaOse = "סמך" } },
                                                                 { 'ע', new OseExchanges { Gematria = 70, AtBash = 'ז', ShemHaOse = "עין" } },
                                                                 { 'פ', new OseExchanges { Gematria = 80, AtBash = 'ו', ShemHaOse = "פא" } },
                                                                 { 'ף', new OseExchanges { Gematria = 80, AtBash = 'ו', ShemHaOse = "פא" } },
                                                                 { 'צ', new OseExchanges { Gematria = 90, AtBash = 'ה', ShemHaOse = "צדיק" } },
                                                                 { 'ץ', new OseExchanges { Gematria = 90, AtBash = 'ה', ShemHaOse = "צדיק" } },
                                                                 { 'ק', new OseExchanges { Gematria = 100, AtBash = 'ד', ShemHaOse = "קוף" } },
                                                                 { 'ר', new OseExchanges { Gematria = 200, AtBash = 'ג', ShemHaOse = "ריש" } },
                                                                 { 'ש', new OseExchanges { Gematria = 300, AtBash = 'ב', ShemHaOse = "שין" } },
                                                                 { 'ת', new OseExchanges { Gematria = 400, AtBash = 'א', ShemHaOse = "תיו" } }
                                                             };

        readonly Dictionary<char, char> EmtzaSofisExchangerDictionary = new Dictionary<char, char>
                                                                            {
                                                                                { 'כ', 'ך' },
                                                                                { 'מ', 'ם' },
                                                                                { 'נ', 'ן' },
                                                                                { 'פ', 'ף' },
                                                                                { 'צ', 'ץ' }
                                                                            };

        readonly Dictionary<char, char> SofisEmtzaExchangerDictionary = new Dictionary<char, char>
                                                                            {
                                                                                { 'ך', 'כ' },
                                                                                { 'ם', 'מ' },
                                                                                { 'ן', 'נ' },
                                                                                { 'ף', 'פ' },
                                                                                { 'ץ', 'צ' }
                                                                            }; 

        public int CalculateGematria(string ivrit)
        {
            if (string.IsNullOrWhiteSpace(ivrit))
            {
                return 0;
            }

            ivrit = ivrit.Trim();
            return string.IsNullOrWhiteSpace(ivrit) ? 0 : ivrit.Where(character => AlefBeisExchangerDictionary.ContainsKey(character)).Sum(character => AlefBeisExchangerDictionary[character].Gematria);
        }

        public string ConvertAtBash(string ivrit)
        {
            if (string.IsNullOrWhiteSpace(ivrit))
            {
                return string.Empty;
            }

            ivrit = ivrit.Trim();
            var atBashStringBuilder = new StringBuilder();
            foreach (var ose in ivrit)
            {
                atBashStringBuilder.Append(AlefBeisExchangerDictionary.ContainsKey(ose) ? AlefBeisExchangerDictionary[ose].AtBash : ose);
            }

            var atBashString = atBashStringBuilder.ToString();
            var tokens = atBashString.Split(' ');
            atBashStringBuilder = new StringBuilder();
            foreach (var token in tokens)
            {
                if (EmtzaSofisExchangerDictionary.ContainsKey(token[token.Length - 1]))
                {
                    atBashStringBuilder.Append(token.Remove(token.Length - 1))
                        .Append(EmtzaSofisExchangerDictionary[token[token.Length - 1]])
                        .Append(' ');
                }
                else
                {
                    atBashStringBuilder.Append(token).Append(' ');
                }
            }

            return atBashStringBuilder.ToString().Trim();
        }

        public string ConvertShemHaOse(string ivrit)
        {
            if (string.IsNullOrWhiteSpace(ivrit))
            {
                return string.Empty;
            }

            ivrit = ivrit.Trim();
            var spellOseBuilder = new StringBuilder();
            foreach (var ose in ivrit)
            {
                spellOseBuilder.Append(AlefBeisExchangerDictionary.ContainsKey(ose) ? AlefBeisExchangerDictionary[ose].ShemHaOse : ose.ToString());
            }

            return spellOseBuilder.ToString();
        }
    }
}


