using fordina.LevelOfGrumpiness;
namespace fordina.Grandpa
{
    public struct Granddad
    {
        public string Name;
        public Grumpiness LevelOfGrumpiness;
        public string[] Phrases;
        public byte NumberOfBruises;
        public Granddad(string name, Grumpiness levelOfGrumpiness, string[] phrases, byte numberOfBruises)
        {
            Name = name;
            LevelOfGrumpiness = levelOfGrumpiness;
            Phrases = phrases;
            NumberOfBruises = numberOfBruises;
        }
        public static int PhrasesCheck(Granddad grump, params  string[] mats)
        {
            foreach (var mat in mats)
            {
                foreach(var i in grump.Phrases)
                {
                    if (mat == i)
                    {
                        grump.NumberOfBruises++;
                    }
                }
            }
            return grump.NumberOfBruises;
        }
    }
}
