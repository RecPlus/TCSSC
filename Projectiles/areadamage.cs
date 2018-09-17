using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TCSSC.Projectiles
{
	public class areadamage : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Confusion");     //The English name of the projectile
		}

		public override void SetDefaults()
		{ 
		projectile.width = 800;               //The width of projectile hitbox
			projectile.height = 800;   
            projectile.aiStyle = 1;			//The width of projectile hitbox              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.melee = false;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = -1;
            projectile.timeLeft = 10;			//How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)         //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 50;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = false;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
		}
		
		 public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)  //how to add a buff to a projectile
        {
            	target.AddBuff(31, 300);
        }
		
	}
}
