using Business.Concrate;
using Entities.Concrate;

Person person = new Person() { FirstName = "Furkan", LastName = "Karagöz", DateOfBirthYear = 2005, NationalIdentity = 12};
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);