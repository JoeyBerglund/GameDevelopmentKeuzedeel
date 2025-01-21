using UnityEngine;

public class GhostCombatBehaviour : MonoBehaviour, enemiesAi
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public DiceRollingSystem DiceRollingSystemScript;

    void Start()
    {
        DiceRollingSystemScript = GameObject.FindGameObjectWithTag("DiceRollingSystem").GetComponent<DiceRollingSystem>();
    }
    public void PerformAttack(PlayerController player, CombatManager combatManager)
    {
        int typeOfAttack = UnityEngine.Random.Range(1, 101);
        Debug.Log($" type of attack {typeOfAttack} {typeOfAttack >= 70}");
        if (70 >= typeOfAttack)
        {
            int toHitRoll = DiceRollingSystemScript.ROLLD20(); // Roll a d20 to determine if the attack hits
            if (toHitRoll >= player.armorClass)
            {
                int damage = DiceRollingSystemScript.ROLLD4(); // Deal damage between 1 and 4
                player.TakeDamage(damage); // Call the player's TakeDamage method
                combatManager.UpdateFeedback($"Ghost attacks for {damage} damage!");
            }
            else
            {
                combatManager.UpdateFeedback("Ghost's attack missed!");
            }
        }
        else
        {
            int damage = DiceRollingSystemScript.ROLLD10(); // Deal damage between 1 and 10 
            player.TakeDamage(damage); // Call the player's TakeDamage method
            combatManager.UpdateFeedback($"Ghost special attacks for {damage} damage!");
        }
    }
}
