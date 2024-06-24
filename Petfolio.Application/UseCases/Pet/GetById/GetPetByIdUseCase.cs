using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetIdJson Execute(int id)
    {
        return new ResponsePetIdJson { 
            Id = id, 
            Name = "Cookie", 
            Type = Communication.Enums.PetType.Dog, 
            Birthday = new DateTime(year: 2023, month: 01, day: 01) 
        };
    }
}
