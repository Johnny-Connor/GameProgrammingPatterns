using UnityEngine;

public class AttributeSystemControls : MonoBehaviour
{
    // Composites.
    private Attribute _playerAtk = new Attribute(10);
    private Attribute _swordAtk = new Attribute(50);

    // Leaves.
    private Bonus _magicalLeafAtkBonus = new Bonus(1);
    private Bonus _refinementAtkBonus = new Bonus(5);

    private void Update()
    {
        void PlayerCommands()
        {
            if (Input.GetMouseButtonDown(0)) // M1
            {
                Debug.Log("Player ATK: " + _playerAtk.GetValue() + ".");
            }
    
            if (Input.GetMouseButtonDown(2)) // M3
            {
                if (_playerAtk.ContainsBaseAttribute(_swordAtk))
                {
                    _playerAtk.RemoveBaseAttribute(_swordAtk);
                    Debug.Log("Player has unequipped Sword.");
                }
                else
                {
                    _playerAtk.AddBaseAttribute(_swordAtk);
                    Debug.Log("Player has equipped Sword.");
                }
            }

            if (Input.GetKeyDown(KeyCode.Q)) // Q
            {
                _playerAtk.AddBaseAttribute(_magicalLeafAtkBonus);
                Debug.Log("Player found a magical leaf (+1 ATK).");
            }

            if (Input.GetKeyDown(KeyCode.W)) // W
            {
                _playerAtk.RemoveBaseAttribute(_magicalLeafAtkBonus);
                Debug.Log("Player lost a magical leaf (-1 ATK), if he had any.");
            }
        }

        void SwordCommands()
        {
            if (Input.GetMouseButtonDown(1)) // M2
            {
                Debug.Log("Sword Attack: " + _swordAtk.GetValue() + ".");
            }

            if (Input.GetKeyDown(KeyCode.E)) // E
            {
                _swordAtk.AddBaseAttribute(_refinementAtkBonus);
                Debug.Log("Sword gained a refinement bonus (+5 ATK).");
            }

            if (Input.GetKeyDown(KeyCode.R)) // R
            {
                _swordAtk.RemoveBaseAttribute(_refinementAtkBonus);
                Debug.Log("Sword lost a refinement bonus (-5 ATK), if it had any.");
            }
        }

        PlayerCommands();
        SwordCommands();
    }
}
