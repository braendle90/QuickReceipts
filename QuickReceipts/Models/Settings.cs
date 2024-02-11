using System.ComponentModel.DataAnnotations;

namespace QuickReceipts.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        public Language Language { get; set; }
        public Currency Currency { get; set; }
    }

    public enum Currency
    {

        USD, // US-Dollar
        EUR, // Euro
        GBP, // Britisches Pfund
        JPY, // Japanischer Yen
        CAD, // Kanadischer Dollar
        AUD, // Australischer Dollar
        CHF, // Schweizer Franken
        CNY, // Chinesischer Yuan
        SEK, // Schwedische Krone
        NZD  // Neuseeland-Dollar
    }

    public enum Language
    {

        English,
        Spanish,
        French,
        German,
        Chinese,
        Japanese,
        Russian,
        Portuguese,
        Arabic,
        Hindi
    }
}
