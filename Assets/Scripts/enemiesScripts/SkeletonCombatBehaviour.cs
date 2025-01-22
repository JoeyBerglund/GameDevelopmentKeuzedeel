using UnityEngine;

public class SkeletonCombatBehaviour : MonoBehaviour, enemiesAi
{
    public DiceRollingSystem DiceRollingSystemScript;

    void Start()
    {
        DiceRollingSystemScript = GameObject.FindGameObjectWithTag("DiceRollingSystem").GetComponent<DiceRollingSystem>();
    }
    public string enemyName { get { return "Skeleton"; } }
    public int health { get { return 100; } }
    public int maxHealth { get { return 100; } }
    public int attackPower { get { return 10; } }
    public int armorClass { get { return 12; } }

    public void PerformAttack(PlayerController player, CombatManager combatManager)
    {
        int toHitRoll = DiceRollingSystemScript.ROLLD20(); // Roll a d20 to determine if the attack hits
        if (toHitRoll >= player.armorClass)
        {
            int damage = DiceRollingSystemScript.ROLLD10(); // Deal damage between 1 and 10
            player.TakeDamage(damage); // Call the player's TakeDamage method
            combatManager.UpdateFeedback($"Skeleton attacks for {damage} damage!");
        }
        else
        {
            combatManager.UpdateFeedback("Skeleton's attack missed!");
        }
    }
}
