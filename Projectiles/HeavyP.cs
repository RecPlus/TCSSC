using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Projectiles
{
	public class HeavyP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Shortsword");     //The English name of the projectile
		}

		    public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.magic = false;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.light = 0f;
            projectile.extraUpdates = 1;
           
           
        }
       
	  public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 0, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 0, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 0, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 25);
		}
 
 
    }
}