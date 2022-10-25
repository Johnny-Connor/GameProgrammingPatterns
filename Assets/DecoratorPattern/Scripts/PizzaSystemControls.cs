using UnityEngine;

public class PizzaSystemControls : MonoBehaviour
{
    private IPizza _pizza = new BasePizza();
    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // M1
        {
            _pizza = new Mozzarella(_pizza);
        }
        if (Input.GetButtonDown("Fire2")) // M2
        {
            _pizza = new Tomatoes(_pizza);
        }
        if (Input.GetButtonDown("Fire3")) // M3
        {
            Debug.Log(_pizza.GetCost());
            _pizza.GetCost();
            Debug.Log(_pizza.GetDescription());
            _pizza.GetDescription();
        }
    }
}
