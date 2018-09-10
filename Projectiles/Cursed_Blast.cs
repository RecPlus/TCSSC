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
	public class Cursed_Blast : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Blast");     //The English name of the projectile
		}

		public override void SetDefaults()
		{
			projectile.width = 14;      
            projectile.aiStyle = 2;				//The width of projectile hitbox
			projectile.height = 14;              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = false;         //Can the projectile deal damage to enemies?
			projectile.hostile = true;         //Can the projectile deal damage to the player?
			projectile.magic = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 2;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)         //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 50;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
		}
		
			public override void AI()
		{
			if (Main.rand.Next(3) == 0)
			{
	            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 75, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 74, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 74, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
			
	
					public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 74, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 74, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 75, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 75, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 0, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 0, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 25);
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			{
				projectile.Kill();
			}
			{
				Main.PlaySound(SoundID.Item32, projectile.position);
			}
			return false;
		}

		 public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        {
            projectile.frameCounter++; //increase the frameCounter by one
            if (projectile.frameCounter >= 3.5) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 0; //reset the counter
                if (projectile.frame > 5) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }
		
		 public override void OnHitPlayer(Player player, int damage, bool crit) //how to add a buff to a projectile
        {
			if (Main.expertMode)
			{
		player.AddBuff (39, 300);    //this adds the buff to the npc that got hit by this projectile , 600 is the time the buff lasts
		player.AddBuff (22, 300);
			}
		    else
			{
			player.AddBuff (39, 300); 
			}
        }
		
	}
}