class Animal 
{
    private string _food;
    public string animalName { get; set; }
    public virtual string eat (string food) {
        _food = food;
        Console.WriteLine("eats {0}", _food);
        return _food;
    }
    public virtual string Transportation() {
        return "moves";
    }
}
// Geni
class Ursus : Animal 
{
    public string furColor { get; set; }
    public string genusName { get; set; }
    public override string Transportation() {
        return "stomps";
    }
}
class Panthera : Animal 
{
    public string furColor { get; set; }
    public string genusName { get; set; }
    public override string Transportation() {
        return "slinks";
    }
}
class Canis : Animal 
{
    public string furColor { get; set; }
    public string genusName { get; set; }
    public override string Transportation() {
        return "prowls";
    }
}
class Okapia : Animal 
{
    public string furColor { get; set; }
    public string genusName { get; set; }
    public override string Transportation() {
        return "bumbles";
    }
}
class Suricata : Animal 
{
    public string furColor { get; set; }
    public string genusName { get; set; }
    public override string Transportation() {
        return "scrambles";
    }
}
class Phacochoerus : Animal 
{
    public string furColor { get; set; }
    public string genusName { get; set; }
    public override string Transportation() {
        return "charges";
    }
}
///////Species
class americanus : Ursus 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool hasPicnicBaskets { get; set;}
    public string commonName = "American Black Bear";
}
class arctos : Ursus 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool hasPicnicBaskets { get; set;}
    public string commonName = "Brown Bear";
}
class maritimus : Ursus 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool hasPicnicBaskets { get; set;}
    public string commonName = "Polar Bear";
}
class thibetanus : Ursus 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool hasPicnicBaskets { get; set;}
    public string commonName = "Asian Black Bear";
}
class tigris : Panthera 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool chasesLasers { get; set;}
    public string commonName = "Tiger";
}
class leo : Panthera 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool chasesLasers { get; set;}
    public string commonName = "Lion";
}
class onca : Panthera 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool chasesLasers { get; set;}
    public string commonName = "Jaguar";
}
class pardus : Panthera 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool chasesLasers { get; set;}
    public string commonName = "Leopard";
}
class uncia : Panthera 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool chasesLasers { get; set;}
    public string commonName = "Snow Lepard";
}
class lupus : Canis 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool buriesBones { get; set;}
    public string commonName = "Gray Wolf";
}
class latrans : Canis 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool buriesBones { get; set;}
    public string commonName = "Coyote";
}
class rufus : Canis 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool buriesBones { get; set;}
    public string commonName = "Red Wolf";
}
class johnstoni : Okapia 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool hasStripes { get; set;}
    public bool isBizarre { get; set;}
    public string commonName = "Okapi";
}
class suricatta : Suricata 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool warthogCompanion { get; set;}
    public string commonName = "Meerkat";
}
class africanus : Phacochoerus 
{
    public string Noise {get; set; }
    public string preferredSnack {get; set;}
    public bool meerkatCompanion { get; set;}
    public string commonName = "Warthog";
}
class Species : Animal 
{
    public string speciesName { get; set; }    
}
class Rabbit : Species 
{
    public string Noise {get; set;}
    public bool bugsBunny {get; set;}
    public string preferredSnack {get; set;}
    public bool luckyFeet {get; set;}
}
class Bear : Species 
{
    public string Noise {get; set;}
    public bool yogi {get; set;}
    public string preferredSnack {get; set;}
    public bool brown {get; set;}
}   
class Duck : Species 
{
    public string Noise {get; set;}
    public bool daffyDuck {get; set;}
    public string preferredSnack {get; set;}
    public string featherColor {get; set;}
}
class Squirrel 
{
    public string Noise {get; set;}
    public virtual string Transportation() {
        return "scurries";
    }
}
class FlyingSquirrel : Squirrel 
{
    public bool fearOfCars {get; set;}
    public override string Transportation() {
        return "flies";
    }
}
Rabbit bugs = new Rabbit();
bugs.speciesName = "Looney Tune";
bugs.bugsBunny = true;
bugs.Noise = "What's up, Doc?";
bugs.luckyFeet = false;
Console.WriteLine("Ihave a Rabbit named Bugs who makes a noise that sounds like {0}. He is a {1} Rabbit.", bugs.Noise, bugs.speciesName);
Squirrel nutsy = new Squirrel();
FlyingSquirrel batman = new FlyingSquirrel();
Console.WriteLine(nutsy.Transportation());
Console.WriteLine(batman.Transportation());

