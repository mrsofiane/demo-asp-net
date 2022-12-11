using demo_asp_net.Models;
using System.Collections;

namespace demo_asp_net.Repositories;


public class PizzaRepository : IPizzaRepository {

    static List<Pizza> source = new List<Pizza>() {
        (new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false }),
        (new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true })

     };
        
    public PizzaRepository() {
    }

    public List<Pizza> GetAllPizza() {
        Console.Write(source.ToString());
        return source;
     }

   public Pizza? GetPizzaById (int id) => source.FirstOrDefault(p => p.Id == id);

   public void addPizza(Pizza pizza)
    {
        source.Add(pizza);
    }


}