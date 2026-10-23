using Objects2.Models;

// Subfolders: /Models/  /Services/  /Helpers/ /Tools/

/*
Name Convention: 
Fields: camelCase
Methods: PascalCase 
 Class:
    Fields first:
        ...
        
    Methods Last:
        ...
 
 Can be:
 Solution/
    Project1:
        ...
    Project2:
        ...
    ...
 */


Student anna = new Student();
anna.name = "Anna";
anna.age = 16;
anna.average = 3.8;

//Console.WriteLine($"{anna.name}, wiek {anna.age}, średnia: {anna.average}");
anna.ShowInfo();


Student aleks = new Student();
aleks.name = "Aleks";
aleks.age = 17;
aleks.average = 4.8;

aleks.ShowInfo();

Student mark =  new Student() {name = "Mark", age = 17, average = 2.8};
mark.ShowInfo();

Car car = new Car() { brand = "Volvo", model = "dasAuto", productionYear = 2022, mileage = 40_000 };
Console.WriteLine(car);
