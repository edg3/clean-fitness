using SQLite;

namespace CleanFitness.Models;

[Table("BaseCalories")]
public class MBaseCalories
{
    /* Not using Model as we wont 'delete' this data, ever */
    [PrimaryKey, AutoIncrement, Column("Id")]
    public int Id { get; set;} = 0;
    public string Name { get; set; } = ""; // 2
    public double CaloriesPer100g { get; set; } = 0; // 3
    public double FatPer100g { get; set; } = 0; // 4
    public double ProteinPer100g { get; set; } = 0; // 5
    public double CarbohydratePer100g { get; set; } = 0; // 6
    public double SugarsPer100g { get; set; } = 0; // 7
    public double FiberPer100g { get; set; } = 0; // 8
    public double CholesterolePer100g { get; set; } = 0; // 9
    public double SaturatedFatsPer100g { get; set; } = 0; // 10
    public double CalciumPer100g { get; set; } = 0; // 11
    public double IronPer100g { get; set; } = 0; // 12
    public double PotassiumPer100g { get; set; } = 0; // 13
    public double MagnesiumPer100g { get; set; } = 0; // 14
    public double VitaminAIUPer100g { get; set; } = 0; // 15
    public double VitaminARAEPer100g { get; set; } = 0; // 16
    public double VitaminCPer100g { get; set; } = 0; // 17
    public double VitaminB12Per100g { get; set; } = 0; // 18
    public double VitaminDPer100g { get; set; } = 0; // 19
    public double VitaminEPer100g { get; set; } = 0; // 20
    //public double AddedSugarPer100g { get; set; } = 0;
    //public double NetCarbsPer100g { get; set; } = 0;
    public double WaterPer100g { get; set; } = 0; // 22
    public double Omega3sPer100g { get; set; } = 0; // 24
    public double Omega6sPer100g { get; set; } = 0; // 25
    //public double PRALScorePer100g { get; set; } = 0;
    //public double TransFattyAcidsPer100g { get; set; } = 0;
    //public double SoluableFiberPer100g { get; set; } = 0;
    //public double InsoluableFiberPer100g { get; set; } = 0;
    public double SucrosePer100g { get; set; } = 0; // 30
    public double GlucosePer100g { get; set; } = 0; // 31
    public double FructosePer100g { get; set; } = 0; // 32
    public double LactosePer100g { get; set; } = 0; // 33
    public double MaltosePer100g { get; set; } = 0; // 34
    public double GalactosePer100g { get; set; } = 0; // 35
    public double StarchPer100g { get; set; } = 0; // 36
    //public double TotalSugarAlcoholsPer100g { get; set; } = 0;
    //public double PhosphorusPer100g { get; set; } = 0;
    public double SodiumPer100g { get; set; } = 0; // 39
    public double ZincPer100g { get; set; } = 0; // 40
    //public double CopperPer100g { get; set; } = 0;
    //public double ManganesePer100g { get; set; } = 0;
    //public double SeleniumPer100g { get; set; } = 0;
    //public double FlouridePer100g { get; set; } = 0;
    //public double MolybdenumPer100g { get; set; } = 0;
    public double ChlorinePer100g { get; set; } = 0; //46
    //public double ThiaminB1Per100g { get; set; } = 0;
    //public double RiboflavinB2Per100g { get; set; } = 0;
    //public double NiacinB3Per100g { get; set; } = 0;
    //public double PatothenicAcidB5Per100g { get; set; } = 0;
    public double VitaminB6Per100g { get; set; } = 0; // 51
    //public double BiotinB7Per100g { get; set; } = 0;
    //public double FolateB9Per100g { get; set; } = 0;
    public double FolicAcidPer100g { get; set; } = 0; // 54
    //public double FoodFolatePer100g { get; set; } = 0;
    //public double FolateDFEPer100g { get; set; } = 0;
    //public double CholinePer100g { get; set; } = 0;
    //public double BetaminePer100g { get; set; } = 0;
    //public double RetinolPer100g { get; set; } = 0;
    //public double CaroteneBetaPer100g { get; set; } = 0;
    //public double CaroteneAlphaPer100g { get; set; } = 0;
    //public double LycopenePer100g { get; set; } = 0;
    //public double LuteinZeaxanthinPer100g { get; set; } = 0;
    public double VitaminD2Per100g { get; set; } = 0; // 64
    public double VitaminD3Per100g { get; set; } = 0; // 65
    public double VitaminDIUPer100g { get; set; } = 0; // 66
    public double VitaminKPer100g { get; set; } = 0; // 67
    //public double DihydrophylloquinonePer100g { get; set; } = 0;
    //public double Menaquinone4Per100g { get; set; } = 0;
    public double FattyAcidsTotalMonosaturatedPer100g { get; set; } = 0; // 70
    public double FattyAcidsTotalPolyunsaturatedPer100g { get; set; } = 0; // 71
    //public double ALAPer100g { get; set; } = 0;
    //public double EPAPer100g { get; set; } = 0;
    //public double DPAPer100g { get; set; } = 0;
    //public double DHAPer100g { get; set; } = 0;
    //public double TrytophanPer100g { get; set; } = 0;
    //public double TheoninePer100g { get; set; } = 0;
    //public double IsoleucinePer100g { get; set; } = 0;
    //public double LeucinePer100g { get; set; } = 0;
    //public double LysinePer100g { get; set; } = 0;
    //public double MethioninePer100g { get; set; } = 0;
    //public double CystinePer100g { get; set; } = 0;
    //public double PhenylalaninePer100g { get; set; } = 0;
    //public double TyrosinePer100g { get; set; } = 0;
    //public double ValinePer100g { get; set; } = 0;
    //public double ArgininePer100g { get; set; } = 0;
    //public double HistidinePer100g { get; set; } = 0;
    //public double AlaninePer100g { get; set; } = 0;
    //public double AsparticAcidPer100g { get; set; } = 0;
    //public double GlutamicAcidPer100g { get; set; } = 0;
    //public double GlycinePer100g { get; set; } = 0;
    //public double ProlinePer100g { get; set; } = 0;
    //public double SerinePer100g { get; set; } = 0;
    //public double HydoxyprolinePer100g { get; set; } = 0;
    public double AlcoholPer100g { get; set; } = 0; // 95
    public double CaffeinePer100g { get; set; } = 0; // 96
    //public double TheobrominePer100g { get; set; } = 0;

    public override string ToString()
    {
        return $"{Name} ({CaloriesPer100g} per 100g)";
    }
}
