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
	public class Heart : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Devil's Heart");     //The English name of the projectile
			ProjectileID.Sets.TrailingMode[projectile.type] = 6;        //The recording mode
			Main.projFrames[projectile.type] = 6;
		}

		public override void SetDefaults()
		{
			projectile.width = 36;      
            projectile.aiStyle = 1;			//The width of projectile hitbox
			projectile.height = 50;              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
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
	            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 5, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 6, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Main.PlaySound(3, (int)projectile.position.X, (int)projectile.position.Y, 25);
			}
		}
			
					public override void Kill(int timeLeft)
				
		{
	            Vector2 position = projectile.Center;
            Main.PlaySound(3, (int)position.X, (int)position.Y);
			int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 5f);
            int radius = 20;     //this is the explosion radius, the highter is the value the bigger is the explosion
 
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + position.X / 16.0f);
                    int yPosition = (int)(y + position.Y / 16.0f);
                }
            }
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
		
		 public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)  //how to add a buff to a projectile
        {
            target.AddBuff (24, 450);    //this adds the buff to the npc that got hit by this projectile , 600 is the time the buff lasts
        }
		
	}
}
