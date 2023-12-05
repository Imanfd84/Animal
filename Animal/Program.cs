using System.Collections;
Animal animal = new Animal(DateTime.Now,800,true,"cow1");

Console.WriteLine(animal.TimeToDie());
Console.WriteLine(animal.life());
public  class Animal
{
    
    public DateTime Birthdate{  get; init; }
    public static readonly int Maxlife = 25;
    public List<Environment> Environments { get; set; }
    public float Weight { get; set; }
    public bool Gender {  get; set; }
    public string Name {  get; set; }
    public Animal(DateTime birthdate,float weight,bool gender,string name) 
{

        Birthdate = birthdate;
        Weight = weight;
        Gender = gender;
        Name = name;






    }
    
    
    

    public float Stressfactor() { return 0  ; }
    public int life() { return 0;  }
    public int TimeToDie() { return (Maxlife*365) - (DateTime.Now - Birthdate).Days; }
    public float KillPriority() { return 0; }
    
    public int ValuePerDay() { return 0; }





}


public class cow : Animal

{
    public static int Number = 1;

    public cow(DateTime birthdate, float weight, bool gender, string name) : base(birthdate, weight, gender, name)
    {
    }

    public List <CowParameter> parameters { get; set; }
    public override string ToString()
    {
        return $"Cow {Number}: {Name}";
    }



}



public class Environment
{

    public  Healthparameter TDS { get; set; }
    public Healthparameter Temp { get; set; }
    public Healthparameter Density { get; set; }
    public Healthparameter db { get; set; }
    public Healthparameter AQI { get; set; }
    public Healthparameter OX { get; set; }
    public DateTime date { get; set; }
    public override string ToString()
    {
        return base.ToString();
    }


}

public class Healthparameter<T>
{

    public string Name { get; set; }    
    public T Current { get; set; }
    public T Standard { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
    public float stressfactor(float stressfactor) {  return stressfactor; }
}



public class CowParameter<T>
{

    public Healthparameter<int> TimeToStand { get; set; }
    public Healthparameter<int> TimeToDeal { get; set; }
    public Healthparameter<int> TimeToRelax { get; set; }
    public Healthparameter<int> NumberOfMeal { get; set; }
    public Healthparameter<int> NumberOfMilkProduction { get; set; }


}








