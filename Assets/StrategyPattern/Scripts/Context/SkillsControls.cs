using UnityEngine;

public class SkillsControls : MonoBehaviour
{
    private ISkill _currentSkill;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            Debug.Log("Switched to Heal.");
            _currentSkill = new Heal();
        }
        if (Input.GetMouseButtonDown(1)) // M2
        {
            Debug.Log("Switched to Provoke.");
            _currentSkill = new Provoke();
        }
        if (Input.GetMouseButtonDown(2)) // M3
        {
            if (_currentSkill != null)
            {
                _currentSkill.Use();
            }
        }
    }
}
