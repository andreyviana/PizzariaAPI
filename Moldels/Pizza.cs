namespace PizzariaAPI.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public bool IsGlutenFree { get; set; }
}