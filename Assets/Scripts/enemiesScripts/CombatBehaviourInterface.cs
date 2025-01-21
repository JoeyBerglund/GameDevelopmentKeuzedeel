using UnityEngine;

public interface enemiesAi
{
    void PerformAttack(PlayerController player, CombatManager combatManager);
}