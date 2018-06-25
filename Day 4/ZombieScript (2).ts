interface OutputInterface
{
    (OutputText: string): void;
}

class ZombieWorld
{
    public FirstName: string[] = [];
    public LastName: string[] = [];
    public Status: number[] = [];
    
    public ZombieCount = 0;

    private OutputRoute: OutputInterface = OutputToConsole;
    
    public AddZombie(FName: string, LName: string, StatusType: number): void
    {
        console.log("Adding #" + this.ZombieCount + ": " + FName + " " + LName);

        this.FirstName[this.ZombieCount] = FName;
        this.LastName[this.ZombieCount] = LName;
        this.Status[this.ZombieCount] = StatusType;

        this.ZombieCount++;
    }

    public OutputZombies(OutputTexts: string): void
    {
        this.OutputRoute(OutputTexts);
    }    
}

let ZombieStatus: string[] = [ "Alive", "Zombie", "Dead", "Unknown" ];

let PlanetZombie = new ZombieWorld();

PlanetZombie.AddZombie("Alan", "Parsons", 2);
PlanetZombie.AddZombie("Michael", "Jackson", 1);
PlanetZombie.AddZombie("Ronald", "Reagan", 3);
PlanetZombie.AddZombie("Freddie", "Mac", 4);
PlanetZombie.AddZombie("Brie", "Larson", 5);    

let StatusResponse: number;
let Status: string;

for (let count: number = 0; count < PlanetZombie.ZombieCount; ++count)
{
    StatusResponse = PlanetZombie.Status[count];

    // If/else method

    Status = "Invalid";

    if ((StatusResponse >= 1) && (StatusResponse <= 4))
    {
        Status = ReturnStatus(StatusResponse);
    }
    
    PlanetZombie.OutputZombies(PlanetZombie.FirstName[count] + " " + PlanetZombie.LastName[count]
        + " is status: " + Status + " (if/else method)");

    // Switch method

    Status = "Invalid";

    switch (StatusResponse)
    {
        case 1:
            Status = ReturnStatus(StatusResponse);
            break;

        case 2:
            Status = ReturnStatus(StatusResponse);
            break;

        case 3:
            Status = ReturnStatus(StatusResponse);
            break;
    
        case 4:
            Status = ReturnStatus(StatusResponse);
            break;
    
        default:
            Status = "Invalid";
            break;
    }

    PlanetZombie.OutputZombies(PlanetZombie.FirstName[count] + " " + PlanetZombie.LastName[count]
        + " is status: " + Status + " (switch method)");
}

/*
console.log ("- For/of method:");

for (let Dude of PlanetZombie.Zombies)
{
    PlanetZombie.OutputZombies(Dude.FirstName + " " + Dude.LastName + " is " 
        + ReturnStatus(Dude.Status));
}
*/

function ReturnStatus(statusNumber: number): string
{
    let statusName: string = "Invalid";

    if ((statusNumber >= 1) && (statusNumber <= 4))
    {
        statusName = ZombieStatus[statusNumber-1];
    }

    return statusName + " (" + statusNumber + ")";
}

function OutputToConsole(OutputText: string): void
{
    console.log(OutputText);
}