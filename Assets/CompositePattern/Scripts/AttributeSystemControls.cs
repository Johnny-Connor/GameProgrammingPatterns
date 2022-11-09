using UnityEngine;

public class AttributeSystemControls : MonoBehaviour
{
    private Attribute _playerAtk = new Attribute(100);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            Debug.Log("Current ATK: " + _playerAtk.GetTotalValue());
        }
        if (Input.GetKeyDown(KeyCode.Q)) // Q
        {
            _playerAtk.AddInitialBonus(new InitialBonus(100, 0));
            Debug.Log("+100 ATK (InitialBonus).");
        }
        if (Input.GetKeyDown(KeyCode.W)) // W
        {
            _playerAtk.AddInitialBonus(new InitialBonus(0, 0.2m));
            Debug.Log("+20% ATK (InitialBonus).");
        }
        if (Input.GetKeyDown(KeyCode.E)) // E
        {
            _playerAtk.AddFinalBonus(new FinalBonus(100, 0m));
            Debug.Log("+100 ATK (FinalBonus).");
        }
        if (Input.GetKeyDown(KeyCode.R)) // R
        {
            _playerAtk.AddFinalBonus(new FinalBonus(0, 0.2m));
            Debug.Log("+20% ATK (FinalBonus).");
        }
        if (Input.GetKeyDown(KeyCode.A)) // A
        {
            _playerAtk.RemoveInitialBonus(new InitialBonus(100, 0));
            Debug.Log("Removed a +100 ATK (InitialBonus) bonus(Leaf), if there was any.");
        }
        if (Input.GetKeyDown(KeyCode.S)) // S
        {
            _playerAtk.RemoveInitialBonus(new InitialBonus(0, 0.2m));
            Debug.Log("Removed a +20% ATK (InitialBonus) bonus(Leaf), if there was any.");
        }
        if (Input.GetKeyDown(KeyCode.D)) // D
        {
            _playerAtk.RemoveFinalBonus(new FinalBonus(100, 0));
            Debug.Log("Removed a +100 ATK (FinalBonus) bonus(Leaf), if there was any.");
        }
        if (Input.GetKeyDown(KeyCode.F)) // F
        {
            _playerAtk.RemoveFinalBonus(new FinalBonus(0, 0.2m));
            Debug.Log("Removed a +20% ATK (FinalBonus) bonus(Leaf), if there was any.");
        }
    }
}
