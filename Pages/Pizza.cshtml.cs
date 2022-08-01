using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzarea.Models;

namespace RazorPizzarea.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="peperoni", 
                PizzaName="peperoni", 
                BasePrice=2, 
                TomatoSauce=true, 
                Cheese=true, 
                FinalPrice=4 },

            new PizzasModel(){
                ImageTitle="Bologrese",
                PizzaName="Bologrese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5},

            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=15},

            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=6},

            new PizzasModel(){
                ImageTitle = "Magerita",
                PizzaName = "Magerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 6},

            new PizzasModel(){
                ImageTitle="MeatFeat",
                PizzaName="MeatFeat",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5},

            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5},

            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5},

            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=12},
            };
        public void OnGet()
        {
        }
    }
}
