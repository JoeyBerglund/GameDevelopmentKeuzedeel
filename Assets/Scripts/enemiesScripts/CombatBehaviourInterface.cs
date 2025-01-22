using UnityEngine;

public interface enemiesAi
{
    string enemyName { get; }
    int health { get; }
    int maxHealth { get; }
    int attackPower { get; }
    int armorClass { get; }

    void PerformAttack(PlayerController player, CombatManager combatManager);
}