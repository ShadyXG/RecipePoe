namespace RecipePoe;

internal class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");    

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
    public void AddNewRecipe() {
        throw new NotImplementedException();
    }

    public void Menu() {
        throw new NotImplementedException();
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

class Ingredient {   

}

class Recipe {  
    public string Name {get; set; }   

}
