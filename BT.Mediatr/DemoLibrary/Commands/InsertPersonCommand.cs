using DemoLibrary.Models;

using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertPersonCommand(string FirstName,string LastName): IRequest<PersonalModel>;
    //public class InsertPersonCommand : IRequest<PersonalModel>
    //{
    //    public InsertPersonCommand(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }

    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}
}
