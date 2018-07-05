interface OutputInterface
{
    (OutputText: string): string;
}

class Personnel
{
    public FirstName: string;
    public LastName: string;
    public Status: number;
}

class ZombieWorld
{
    public Population: Personnel[] = [];
    
    public ZombieCount;

    private OutputRoute: OutputInterface;
    private OutputTypes: string[] = ["Console", "Database", "Web", "String"];

    constructor()
    {
        /* No zombies in this world.. yet */
        this.ZombieCount = 0;

        /* Default output to log */
        this.OutputRoute = this.OutputToConsoleLog;
    }
    
    public AddPerson(FName: string, LName: string, StatusType: number): void
    {
        console.log("Adding #" + this.ZombieCount + ": " + FName + " " + LName);

        this.Population[this.ZombieCount] = { FirstName: FName, LastName: LName, Status: StatusType };

        this.ZombieCount++;
    }

    public OutputPersonnel(OutputTexts: string): string
    {
        return this.OutputRoute(OutputTexts);
    }

    public SelectOutputType(OutputType:string): void
    {
        switch (OutputType)
        {
            case "Console":
                this.OutputRoute = this.OutputToConsoleLog;
                break;

            case "Database":
                this.OutputRoute = this.OutputToConsoleLog;
                break;

            case "Web":
                this.OutputRoute = this.OutputToConsoleLog;
                break;

            case "String":
                this.OutputRoute = this.OutputToConsoleLog;
                break;

            default:
                this.OutputRoute = this.OutputToNowhere;
                break;
            }
    }

    /* Private class functions for output types:) */

    private OutputToConsoleLog(OutputText: string): string
    {
        console.log(OutputText);
        return "";
    }

    private OutputToNowhere(OutputText: string): string
    {
        return "";
    }
}

let ZombieStatus: string[] = [ "Alive", "Zombie", "Dead", "Unknown", "Omnipotent" ];

let PlanetZombie = new ZombieWorld();

PlanetZombie.AddPerson("Alan", "Parsons", 2);
PlanetZombie.AddPerson("Michael", "Jackson", 1);
PlanetZombie.AddPerson("Ronald", "Reagan", 3);
PlanetZombie.AddPerson("Freddie", "Mac", 4);
PlanetZombie.AddPerson("Brie", "Larson", 5);    

let StatusResponse: number;
let Status: string;

for (let count: number = 0; count < PlanetZombie.ZombieCount; ++count)
{
    StatusResponse = PlanetZombie.Population[count].Status;

    // If / else method

    let Status: string = ReturnStatus(StatusResponse);
    
    PlanetZombie.OutputPersonnel(PlanetZombie.Population[count].FirstName + " " + PlanetZombie.Population[count].LastName
        + " is status: " + Status + " (if/else method)");

    // Switch method

    switch (StatusResponse)
    {
        default:
            Status = ReturnStatus(StatusResponse);
            break;
    }

    PlanetZombie.OutputPersonnel(PlanetZombie.Population[count].FirstName + " " + PlanetZombie.Population[count].LastName
        + " is status: " + Status + " (switch method)");
}

console.log ("- For/of method:");

for (let Dude of PlanetZombie.Population)
{
    PlanetZombie.OutputPersonnel(Dude.FirstName + " " + Dude.LastName + " is " 
        + ReturnStatus(Dude.Status));
}

function ReturnStatus(statusNumber: number): string
{
    let statusName: string;

    if ((statusNumber >= 1) && (statusNumber <= (ZombieStatus.length)))
    {
        statusName = ZombieStatus[statusNumber-1];
    }
    else
    {
        statusName = "Invalid";
    }

    return statusName + " (" + statusNumber + ")";
}

