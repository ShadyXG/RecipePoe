namespace RecipePoe;
using RecipePoe.Models;   


internal class Program {   
    private static RecipeManagerImpl main_menu;
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");   
        
        main_menu = new RecipeManagerImpl();   

        while(true) {
            main_menu.Menu();
        }
    }
}    

interface RecipeManager {

    void Menu(); 
    void AddNewRecipe();
    void UpscaleQuantities();
    void ResetValues();
    void RemoveRecipe();
}

class RecipeManagerImpl : RecipeManager {

    //Current Recipe to Keep Track of.
    private Recipe? _currentRecipe;

    public void AddNewRecipe() {

        //Init to Null first
        _currentRecipe = null; 
        
        /* 
         * Collect Recipe information
         * params: <Name>  , <Number of Ingredients>
         * **/
        
        try {
            Console.WriteLine("Enter Recipe Name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Recipe's Number of Ingredients:");
            var steps_count = int.Parse(Console.ReadLine());
            _currentRecipe = new Recipe(name,steps_count);

            AddIngredients();

            Console.WriteLine("Enter Number of Steps:");
            //Number of Steps.
            _currentRecipe.NumberOfSteps = int.Parse(Console.ReadLine());
            _currentRecipe.InitialiseSteps();

            AddAllSteps();
            


            
            //Done Loading Recipe.
            Console.WriteLine("Recipe Successfully Added");

            foreach (var x in _currentRecipe.Ingredients)
                Console.WriteLine(x.ToString());

            return;

        }
        catch(Exception ex) {
            Console.WriteLine("Try Entering a Number.");
            
        }
        
    }

    private Ingredient AddIngredientToRecipe() {

        int quantity = 0;
        string measurements = "";

        //Capture Details of Individual Ingredient
        Console.WriteLine("Enter Ingredient Name:");
        var Name =  Console.ReadLine();

        try {

            Console.WriteLine("Enter Ingredient Quantity:");
             quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ingredient Measurements:");
             measurements = Console.ReadLine();

        }
        catch(Exception ex) {
            Console.WriteLine("Try Entering a Number");
        }
       
        return new Ingredient(Name , quantity, measurements);
    }

    private void AddIngredients() {      

        for(var x= 0; x< _currentRecipe.NumberOfIngredients; x++) {
            _currentRecipe.Ingredients[x] = AddIngredientToRecipe();
        } 
    }

    /* 
     * Add Steps to making Recipe.  
     *  <AddStep()> , <AddAllSteps()> 
     * */

    private string AddStep() {

        return Console.ReadLine();
    }

    private void AddAllSteps() {   

        for(var x = 0; x< _currentRecipe.NumberOfSteps; x++) {
            Console.WriteLine("Add Step" + x + 1 + ":");
            _currentRecipe.Steps[x] = AddStep();
        }
    }

    public void Menu() {

        Console.WriteLine("\tMain Menu.\t");
        //Possible Menu Selections 
        var menu_selection = new string[] {   
            "1.Add new Recipe", 
            "2.Upscale Quantities.",  
            "3.Remove Current Recipe", 
        };

        //Printout menu Selections
        foreach (var item in menu_selection)
            Console.WriteLine("\t" +item);

        //Ask user to select either menu items.     
        var choice = Console.ReadLine();

        //Evaluate Users Choice   
        switch (choice) {
            case "1": AddNewRecipe();break;
            case "2": UpscaleQuantities(); break;   
            case "3": RemoveRecipe(); break;
        }

        
    }

    public void RemoveRecipe() {
        throw new NotImplementedException();
    }

    public void ResetValues() {
        throw new NotImplementedException();
    }

    public void UpscaleQuantities() {
        throw new NotImplementedException();
    }
}




