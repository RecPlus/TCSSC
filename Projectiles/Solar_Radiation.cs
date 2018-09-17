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
	public class Solar_Radiation : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Radiation");     //The English name of the projectile
			ProjectileID.Sets.TrailingMode[projectile.type] = 4;        //The recording mode
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults()
		{
			projectile.width = 14;      
            projectile.aiStyle = 44;			//The width of projectile hitbox
			projectile.height = 14;              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.melee = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = -1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 60;
			projectile.alpha = 0;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = false;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
		}
		
			public override void AI()
		{
			if (Main.rand.Next(3) == 0)
			{
	            	Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 222, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 222, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
			
					public override void Kill(int timeLeft)
				
		{
	            Vector2 position = projectile.Center;
            Main.PlaySound(SoundID.Item14, (int)position.X, (int)position.Y);
			int dustnumber = 	Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 222, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 222, 0f, 0f, 200, default(Color), 2f);
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
            if (projectile.frameCounter >= 1) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 1; //reset the counter
                if (projectile.frame > 4) //if past the last frame
                    projectile.frame = 1; //go back to the first frame
            }
            return true;
        }
	}
}
