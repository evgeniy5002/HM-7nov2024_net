using HW;

Oceanarium<Animal> o = [
    new Octopus("Octopus bimaculoides", false, 40, 7),
    new Dolphin("Orcinus orca", true, 122, 55),
    new Fish("Silurus glanis", true, 40, 30)
];

foreach (var i in o)
{
    Console.WriteLine(i.ToString());
}

Console.WriteLine("\n------------------------------\n");

FootballTeam<Player> p = [
    new Player("Player a name", "Player a surname", 29),
    new Player("Player b name", "Player b surname", 39),
    new Player("Player c name", "Player c surname", 129)
];

foreach (var i in p)
{
    Console.WriteLine(i.ToString());
}

Console.WriteLine("\n------------------------------\n");

Cafe<Worker> c = [
    new Worker("Worker a name", "Worker a surname", 32),
    new Worker("Worker b name", "Worker b surname", 23),
    new Worker("Worker c name", "Worker c surname", 19)
];

foreach (var i in c)
{
    Console.WriteLine(i.ToString());
}