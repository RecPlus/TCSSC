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
	public class Death_Ray : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rainbow Laser");     //The English name of the projectile
			ProjectileID.Sets.TrailingMode[projectile.type] = 4;        //The recording mode
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults()
		{  
            projectile.aiStyle = 1;			//The width of projectile hitbox              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.melee = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)         //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 50;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = false;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
		}
		
			public override void AI()
		{
			if (Main.rand.Next(3) == 0)
			{
	            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 65, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
			
					public override void Kill(int timeLeft)
				
		{
	            Vector2 position = projectile.Center;
            Main.PlaySound(SoundID.Item12, projectile.position);
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 65, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
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
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)  //how to add a buff to a projectile
        {
            	target.AddBuff(24, 180);
			target.AddBuff(70, 180);
			target.AddBuff(153, 180);
			target.AddBuff(20, 180);
			target.AddBuff(120, 300);
			target.AddBuff(137, 300);
			target.AddBuff(103, 300);
        }

		 public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        {
            projectile.frameCounter++; //increase the frameCounter by one
            if (projectile.frameCounter >= 1) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 0; //reset the counter
                if (projectile.frame > 3) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }
	}
}
