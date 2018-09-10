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
    class Fire_Blast_Good : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Miniblast");
			ProjectileID.Sets.TrailingMode[projectile.type] = 10; 
        }

         public override void SetDefaults()
        {
			projectile.width = 14;               //The width of projectile hitbox
			projectile.height = 32;              //The height of projectile hitbox
			projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.melee = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 2;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 50;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)         //How much light emit around the projectile
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
			aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
        }
		
					public override void AI()
		{
			projectile.velocity.Y += projectile.ai[0];
			if (Main.rand.Next(3) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 6, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
			
			if (projectile.localAI[0] > 130f) //projectile time left before disappears
            {
                projectile.Kill();
            }
		}
		
				public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 6, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 6, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 6, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 25);
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)  //how to add a buff to a projectile
        {
            target.AddBuff (24, 180);    //this adds the buff to the npc that got hit by this projectile , 600 is the time the buff lasts
			if (Main.expertMode)
		    target.AddBuff (24, 120);    //this adds the buff to the npc that got hit by this projectile , 600 is the time the buff lasts
        }
    }
}	