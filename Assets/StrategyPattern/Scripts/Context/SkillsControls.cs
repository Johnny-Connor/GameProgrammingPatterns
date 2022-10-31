using UnityEngine;

public class SkillsControls : MonoBehaviour
{
    private ISkill _currentSkill = new Heal();
    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // M1
        {
            _currentSkill.Use();
        }
        if (Input.GetKey("1")) // 1
        {
            _currentSkill = new Heal();
        }
        if (Input.GetKey("2")) // 2
        {
            _currentSkill = new Provoke();
        }
    }

}
