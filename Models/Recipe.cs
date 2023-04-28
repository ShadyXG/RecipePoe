using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipePoe.Models;
namespace RecipePoe.Models;

public class Recipe {
    
    public string Name {get; set; }
    public int NumberOfIngredients {get; set; }
    public Ingredient[] Ingredients;    
    public int NumberOfSteps {get;set;}

    public string[] Steps { get; set; }

    public Recipe(string Name , int NumberOfIngredients ) {

        this.Name = Name;
        this.NumberOfIngredients = NumberOfIngredients;
        AddIngredients();

    }

    public void AddIngredients() {     

        // Initialise ingredients Array
        Ingredients = new Ingredient[NumberOfIngredients];           
    }

    public override string ToString() {
        return Name;
      
    }

    public void InitialiseSteps() {
        //Init Steps  Array
        Steps = new string[NumberOfSteps];
    }

}

