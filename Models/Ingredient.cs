using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePoe.Models;
public class Ingredient {  
    public string Name { get; set; }   
    public int Quantity { get; set; }  
    public string MeasurementUnit { get; set; }        
    
    

    public Ingredient(string Name , int Quantity , string MeasurementUnit) {
        this.Name = Name;
        this.Quantity = Quantity;
        this.MeasurementUnit = MeasurementUnit;

    }

    public override string ToString() {
        return Name + " "+ Quantity +MeasurementUnit + "";
    }
}

