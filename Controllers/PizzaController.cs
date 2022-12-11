using demo_asp_net.Models;
using demo_asp_net.Services;
using Microsoft.AspNetCore.Mvc;


namespace demo_asp_net.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PizzaController : ControllerBase
{
    private PizzaService pizzaService;
    public PizzaController()
    {
        this.pizzaService =  new PizzaService();
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => pizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> get(int id)
    {
        var pizza = pizzaService.getPizzaById(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        // This code will save the pizza and return a result
        pizzaService.addPizza(pizza);
        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    } 
}