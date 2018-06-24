let ZombieStatus = [ "Alive", "Zombie", "Dead", "Unknown" ];

let Zombies = [
    { FirstName: "Alan", LastName: "Parsons", Status: 2 },
    { FirstName: "Michael", LastName: "Jackson", Status: 1 },
    { FirstName: "Ronald", LastName: "Reagan", Status: 3 },
    { FirstName: "Freddie", LastName: "Mac", Status: 4 },
    { FirstName: "Brie", LastName: "Larson", Status: 5 }
];

let StatusResponse;
let Status;

for (let count = 0; count < Zombies.length; ++count)
{
    StatusResponse = Zombies[count].Status;

    // If/else method

    Status = "Invalid";

    if ((StatusResponse >= 1) && (StatusResponse <= 4))
    {
        Status = ReturnStatus(StatusResponse);
    }
    
    OutputToConsole(Zombies[count].FirstName + " " + Zombies[count].LastName
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

    OutputToConsole(Zombies[count].FirstName + " " + Zombies[count].LastName
        + " is status: " + Status + " (switch method)");
}

console.log ("- For/of method:");

for (let ZombieDude of Zombies)
{
    OutputToConsole(ZombieDude.FirstName + " " + ZombieDude.LastName + " is " 
        + ReturnStatus(ZombieDude.Status));
}

function ReturnStatus(statusNumber)
{
    let statusName = "Invalid";

    if ((statusNumber >= 1) && (statusNumber <= 4))
    {
        statusName = ZombieStatus[statusNumber-1];
    }

    return statusName + " (" + statusNumber + ")";
}

function OutputToConsole(OutputText)
{
    console.log(OutputText);
}