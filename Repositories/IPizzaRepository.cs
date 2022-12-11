using demo_asp_net.Models;
using System.Collections;


namespace demo_asp_net.Repositories;

public interface IPizzaRepository {
    public List<Pizza> GetAllPizza();

    public Pizza? GetPizzaById(int id);

    public void addPizza(Pizza pizza);
}