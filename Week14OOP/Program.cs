
Dog myDog = new Dog("hea poiss");
Dog neighboursDog = new Dog("paha poiss");

Console.WriteLine($"My dogs name is: {myDog.Name}");
Console.WriteLine(neighboursDog.Name);

myDog.Rename("paha poiss");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();

}
myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has a new name:{newName}");
    }
    public void Bark()
    {
        Console.WriteLine("woof.woof");
        _levelOfHapiness++;
    }
    public void WagTail()
    {
        Console.WriteLine("wiggleWiggle");
    }
}
