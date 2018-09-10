using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Projectiles
{
	public class bulletthrow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("High Caliber Bullet");     //The English name of the projectile
		}

		    public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.magic = false;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
           
           
        }
       
 
    }
}