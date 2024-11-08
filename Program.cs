using HW;

Console.WriteLine("\n------------------------------ Oceanarium LIST: \n");
List<Animal> olist =
[
    new Octopus("Octopus bimaculoides", false, 40, 7),
    new Dolphin("Orcinus orca", true, 122, 55),
    new Fish("Silurus glanis", true, 40, 30)
];
Oceanarium<List<Animal> > o = new(olist);
o.Print();

Console.WriteLine("\n------------------------------ Oceanarium HASHSET: \n");
HashSet<Animal> ohashSet =
[
    new Octopus("Octopus bimaculoides", false, 40, 7),
    new Dolphin("Orcinus orca", true, 122, 55),
    new Fish("Silurus glanis", true, 40, 30)
];
Oceanarium<HashSet<Animal>> o2 = new(ohashSet);
o2.Print();



Console.WriteLine("\n------------------------------ FootballTeam HASHSET: \n");
List<Player> plist = [
    new Player("Player a name", "Player a surname", 29),
    new Player("Player b name", "Player b surname", 39),
    new Player("Player c name", "Player c surname", 129)
];
FootballTeam<List<Player>> p1 = new(plist);
p1.Print();



Console.WriteLine("\n------------------------------ Cafe HASHSET: \n");
List<Worker> wlist = [
    new Worker("Worker a name", "Worker a surname", 32),
    new Worker("Worker b name", "Worker b surname", 23),
    new Worker("Worker c name", "Worker c surname", 19)
];
Cafe<List<Worker>> w = new(wlist);
w.Print();