using UnityEngine;

public class SkillsControls : MonoBehaviour
{
    private ISkill _currentSkill = new EmptySkill();
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            Debug.Log("Heal selected.");
            _currentSkill = new Heal();
        }

        if (Input.GetMouseButtonDown(1)) // M2
        {
            Debug.Log("Provoke selected.");
            _currentSkill = new Provoke();
        }
        
        if (Input.GetMouseButtonDown(2)) // M3
        {
            _currentSkill.Use();
        }
    }
}
