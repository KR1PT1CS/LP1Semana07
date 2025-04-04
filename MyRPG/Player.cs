using System;

namespace MyRPG
{
    public class Player
    {
        private int xp;
         private float health;
         
         public string Name { get; }
         
         public int XP
         {
         public int Level
             get => 1 + (xp / 1000);
         }
 
         public float Health
         {
             get => health;
             set
             {
                 health = value;
                 if (health < 0) health = 0;
             }
         }
         
         public float MaxHealth
         {
             get => 100f + (Level - 1) * 20f;
         }
 
         public Player(string name)
         {
             
             this.Name = name;
             xp = 0;
             Health = MaxHealth;
         }
 
         public void TakeDamage(float damage)
         {
             
             Health -= damage;
             xp += (int)damage / 20;
         }
 
     }
}
     