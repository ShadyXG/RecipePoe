using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipePoe.Models;
namespace RecipePoe.Models;
using RecipePoe.Constants;

public class Recipe {
    
    public string Name {get; set; }
    public int NumberOfIngredients {get; set; } 

    public List<Ingredient> Ingredients;    
    public int NumberOfSteps {get;set;}

    public string[] Steps { get; set; }

    //Setting scale values to Default x1
    public double scale = Scale.DEFAULT;   


    public Recipe(string Name , int NumberOfIngredients ) {

        this.Name = Name;
        this.NumberOfIngredients = NumberOfIngredients;
        AddIngredients();

    }

    public void AddIngredients() {

        // Initialise ingredients Array
        // Ingredients = new Ingredient[NumberOfIngredients];
        Ingredients = new List<Ingredient>();
    }

    public override string ToString() {
        return Name;
      
    }

    public void InitialiseSteps() {
        //Init Steps  Array
        Steps = new string[NumberOfSteps];   


    }

}

