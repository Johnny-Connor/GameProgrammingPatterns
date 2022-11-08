using UnityEngine;

public class SkillsControls : MonoBehaviour
{
    private ISkill _currentSkill;
    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // M1
        {
            Debug.Log("Switched to Heal.");
            _currentSkill = new Heal();
        }
        if (Input.GetButtonDown("Fire2")) // M2
        {
            Debug.Log("Switched to Provoke.");
            _currentSkill = new Provoke();
        }
        if (Input.GetButtonDown("Fire3")) // M3
        {
            if (_currentSkill != null)
            {
                _currentSkill.Use();
            }
        }
    }
}
