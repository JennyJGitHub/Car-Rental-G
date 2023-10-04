using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
    public string SSN { get; init; }
    public string LastName { get; init; }
    public string FirstName { get; init; }

    public Customer (string ssn, string lastName, string firstName) =>
        (SSN, LastName, FirstName) = (ssn, lastName, firstName);
}
