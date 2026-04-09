using System.Reflection.Metadata.Ecma335;

namespace LeagueGames.Backend.Api.Domain.Entities.Core;

public class Player : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => FirstName + " " + LastName; }
}