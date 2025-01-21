using System;
using UnityEngine;

public class DiceRollingSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public int ROLLINITIATIVE()
    {
        return initiativeRoll();
    }

    public int ROLLINITIATIVEADVANTAGE()
    {
        return initiativeRoll("advantage");
    }

    public int ROLLINITIATIVEDISADVANTAGE()
    {
        return initiativeRoll("disadvantage");
    }

    public int ROLLD100(int? amount = null)
    {
        return getDice(100, amount);
    }

    public int ROLLD20(int? amount = null)
    { 
        return getDice(20, amount);
    }

 public int ROLLD12(int? amount = null)
    {
        return getDice(12, amount);
    }

    public int ROLLD10(int? amount = null)
    {
        return getDice(10, amount);
    }

    public int ROLLD8(int? amount = null)
    {
        return getDice(8, amount);
    }

    public int ROLLD6(int? amount = null)
    {
        return getDice(6, amount);
    }

    public int ROLLD4(int? amount = null)
    {
        return getDice(4, amount);
    }

    public int getDice(int dice, int? amount = null)
    {
        int rollsToMake = amount ?? 1; // Default to 1 if null
        int total = 0;
        for (int i = 0; i < rollsToMake; i++)
        {
            total += UnityEngine.Random.Range(1, dice + 1); // Correct dice roll range
        }
        return total;
    }

    public int initiativeRoll(string? condition = null)
    {
        int[] rolls = new int[2]; // Array for storing rolls
        int result = 0;

        switch (condition)
        {
            case "advantage":
                // Roll twice and take the higher result
                rolls[0] = getDice(20);
                rolls[1] = getDice(20);
                result = Math.Max(rolls[0], rolls[1]);
                Debug.Log($"Advantage rolls: {rolls[0]}, {rolls[1]} | Result: {result}");
                break;

            case "disadvantage":
                // Roll twice and take the lower result
                rolls[0] = getDice(20);
                rolls[1] = getDice(20);
                result = Math.Min(rolls[0], rolls[1]);
                Debug.Log($"Disadvantage rolls: {rolls[0]}, {rolls[1]} | Result: {result}");
                break;

            default:
                // Single roll for normal initiative
                result = getDice(20);
                Debug.Log($"Normal initiative roll: {result}");
                break;
        }
        return result;
    }
}
