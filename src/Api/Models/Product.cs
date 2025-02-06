namespace Api.Models;

public record Product(
    int Id,
    string Name,
    string Description,
    double Price);