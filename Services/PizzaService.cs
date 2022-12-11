using demo_asp_net.Models;
using demo_asp_net.Repositories;
using System.Collections;


namespace demo_asp_net.Services;

public class PizzaService
{
    private IPizzaRepository pizzaRepository;
    public PizzaService()
    {
        this.pizzaRepository  =  new PizzaRepository();
    }

    public List<Pizza> GetAll() => pizzaRepository.GetAllPizza();

    public Pizza? getPizzaById(int id) => pizzaRepository.GetPizzaById(id);

    public  void addPizza(Pizza pizza)
    {
        pizzaRepository.addPizza(pizza);
    }
}