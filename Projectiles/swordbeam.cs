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
    class swordbeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mithril Beam");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 3;        //The recording mode
        }

         public override void SetDefaults()
        {
			projectile.width = 14;               //The width of projectile hitbox
			projectile.height = 32;              //The height of projectile hitbox
			projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 255;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
			aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
        }
		
					public override void Kill(int timeLeft)
				
		{
	            Vector2 position = projectile.Center;
			int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 63);
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
		
					public override void AI()
		{
			projectile.velocity.Y += projectile.ai[0];
			if (Main.rand.Next(3) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 63, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
			
			if (projectile.localAI[0] > 130f) //projectile time left before disappears
            {
                projectile.Kill();
            }
		}
		
    }
}	