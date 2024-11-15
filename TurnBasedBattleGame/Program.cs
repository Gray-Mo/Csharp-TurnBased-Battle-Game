﻿using System;
using System.Threading.Tasks;
using TurnBasedBattleGame;

Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
Random random = new Random();

while (!player.IsDead && !enemy.IsDead)
{
    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    Console.WriteLine("Player turn, What's your move?");
    string choice = Console.ReadLine();

    if (choice == "a")
        player.Attack(enemy);
    else
        player.heal();


    if (player.IsDead || enemy.IsDead)
        break;

    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    Console.WriteLine("Enemy turn, What's your action?");
    await Task.Delay(2000);

    int rand = random.Next(0, 2);

    if (rand == 0)
    {
        Console.WriteLine("a");
        enemy.Attack(player);
    }
    else
    {
        Console.WriteLine("h");
        enemy.heal();
    }
}