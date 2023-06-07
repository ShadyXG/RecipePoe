using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePoe.Models;
using RecipePoe.Constants;
public class Ingredient {  
    public string Name { get; set; }   
    public int Quantity { get; set; }
     
    public string MeasurementUnit { get; set; } 
    
    //Setting scale values to Default x1
    public double scale = Scale.DEFAULT;

    //Add Calories to ingredient   
    public double Calories;

    // Add Food Group to Ingredient      
    public string FoodGroup;

    public Ingredient(string Name , int Quantity , string MeasurementUnit) {
        this.Name = Name;
        this.Quantity = Quantity;
        this.MeasurementUnit = MeasurementUnit;

    }

    public override string ToString() {
        return Name + " "+ (this.Quantity * scale) +MeasurementUnit + "";
    }

   
}

