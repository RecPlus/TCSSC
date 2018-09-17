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
	public class Gamma_Ray : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gamma Ray");     //The English name of the projectile
		}

		public override void SetDefaults()
		{
			projectile.damage = 20000;
			projectile.width = 10;      
            projectile.aiStyle = 18;				//The width of projectile hitbox
			projectile.height = 10;              //The height of projectile hitbox          //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.melee = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 2;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)         //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 50;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 1f;            //How much light emit around the projectile
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
		}
		
			public override void AI()
		{
			if (Main.rand.Next(3) == 6)
			{
	            int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 62, 0f, 0f, 200, default(Color), 2f);
	Main.dust[dustnumber].velocity *= 1f;
			}
		}
			
	
					public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
				if (Main.rand.Next(6) == 120)
			{
	int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 62, 0f, 0f, 200, default(Color), 2f);
	Main.dust[dustnumber].velocity *= 1f;
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