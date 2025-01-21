using UnityEngine;

public interface IEnemyActions
{
    void PerformAttack(PlayerController player, CombatManager combatManager);
}