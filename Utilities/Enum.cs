namespace DungeonsAndDragons.ChartEngine.Utilities
{
    public enum Dice
    {
        D2 = 2,
        D3 = 3,
        D4 = 4,
        D6 = 6,
        D7 = 7,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100,
        DNull = 0
        
    }

    public enum MonsterTypes
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V
    }


    public enum GemType//todo Should the values of the Gems be in its own GemValueData.txt like Jewelry is?
    {
        Quartz = 10,    
        Turquoise = 10,
        Citrine = 50,
        Onyx = 50,
        Amber = 100,
        Garnet = 100,
        Pearl = 500,
        Topaz = 500,
        Opal = 1000,
        Ruby = 1000
    }

    public enum MonetaryTrasureTypes
    {
        Copper,
        Silver,
        Electrum,
        Gold,
        Platinum,
        Jewelry,
        Gems
    }

    public enum MagicItemTypes
    {
        A = 20,
        B = 30,
        C = 40,
        D = 65,
        E = 85,
        F = 90,
        G = 95,
        H = 100
    
    }

    public enum JewelryType
    {
        Bracelet,
        Pin,
        Brooch,
        Earring,
        Pendant,
        Necklace,
        Crown,
        Sceptre
    }

}
