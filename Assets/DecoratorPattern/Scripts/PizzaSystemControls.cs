using UnityEngine;

public class PizzaSystemControls : MonoBehaviour
{
    private IPizza _pizza = new BasePizza();
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            _pizza = new Mozzarella(_pizza);
        }

        if (Input.GetMouseButtonDown(1)) // M2
        {
            _pizza = new Tomatoes(_pizza);
        }
        
        if (Input.GetMouseButtonDown(2)) // M3
        {
            Debug.Log("Price: $" + _pizza.GetPrice() + "." + "\n" + "Ingredients: " + _pizza.GetIngredients() + ".");
        }
    }
}
