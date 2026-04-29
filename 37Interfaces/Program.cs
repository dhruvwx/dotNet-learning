using _37Interfaces;

List <IRun>  runner = new List<IRun>();

Animal animal = new();
Person person = new();

runner.Add(animal);
runner.Add(person);

foreach(IRun run in runner)
{
    if(run is IRun p)
    {
        person.Name();

        animal.Species();
    }
}

