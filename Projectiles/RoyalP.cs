using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Projectiles
{
	public class RoyalP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Shortsword");     //The English name of the projectile
		}

		    public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 40;
            projectile.aiStyle = 14;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.magic = false;
            projectile.penetrate = 1;
            projectile.timeLeft = 300;
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