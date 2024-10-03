using RecordsExample;

// var personClassError = new PersonClass(); // Cannot build because "init;"
var personClass1 = new PersonClass("John", "Doe", 30);
var personClass2 = new PersonClass("John", "Doe", 30);

// var personRecordError = new PersonRecord(); // Cannot build because definition of record
var personRecord1 = new PersonRecord("John", "Doe", 30);
var personRecord2 = new PersonRecord("John", "Doe", 30);

Console.WriteLine("Comparison:");
Console.WriteLine($"(personClass1 == personClass2) = { personClass1 == personClass2 }"); // Class comparison
Console.WriteLine($"(personRecord1 == personRecord2) = { personRecord1 == personRecord2 }"); // Record comparison

// Clone and modify
// var personClassClonModified = personClass1 with { FirstName = "Joel" }; // Not possible
var personRecordClonModified = personRecord1 with { FirstName = "Joel" };

// Deconstruction
// var (firstNameFromClass, lastNameFromClass, ageFromClass) = personClass1; // Not possible 
var (firstName, lastName, age) = personRecordClonModified;
Console.WriteLine();
Console.WriteLine("Clone, Modify and Deconstruction:");
Console.WriteLine($"{firstName} {lastName}, Age: {age}");
