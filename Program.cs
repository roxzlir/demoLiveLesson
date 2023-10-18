namespace demoLiveLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BedsideTable sängBord = new BedsideTable("Furu", "Olackad", 499, "Fyrkantigt", true);
            OfficeChair kontorsStol = new OfficeChair("Mesh", "Svart", 25999, true);
            OfficeChair receptionsStol = new OfficeChair("Läder", "Vit", 449, false, false);
            DinnerTable köksBord = new DinnerTable("Ek", "Laserat", 14499, "Rund", 8);
            Stool pall = new Stool("Björk", "Obehandlad", 99, false);
            Stool barStol = new Stool("Metall", "Gul", 1399, true);

            sängBord.PrintBasicInfo();
            sängBord.PrintUniqeFurnitureInfo();
            Console.WriteLine();
            kontorsStol.PrintBasicInfo();
            kontorsStol.PrintUniqeFurnitureInfo();
            Console.WriteLine();
            receptionsStol.PrintBasicInfo();
            receptionsStol.PrintUniqeFurnitureInfo();
            Console.WriteLine();
            köksBord.PrintBasicInfo();
            köksBord.PrintUniqeFurnitureInfo();
            Console.WriteLine();
            pall.PrintBasicInfo();
            pall.PrintUniqeFurnitureInfo();
            Console.WriteLine();
            barStol.PrintBasicInfo();
            barStol.PrintUniqeFurnitureInfo();

        }
    }
}