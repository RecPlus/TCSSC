using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Sharp_Feather : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sharp Feather");
			Tooltip.SetDefault("Fires fallen feathers");
		}
    public override void SetDefaults()
    {
        item.width = 32;
        item.height = 32;
        item.useStyle = 3;
        item.value = 60000;
        item.rare = 4;
						item.autoReuse = true;
				item.melee = true;
				item.damage = 45;
				item.knockBack = 0;
                item.useTime = 20;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 2f;
                item.useAnimation = 20;
    }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 45;
				item.knockBack = 3;
                item.useTime = 5;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 100;
				item.shoot = mod.ProjectileType("harpyfeather");
                item.shootSpeed = 10f;
				item.mana = 100;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 45;
				item.knockBack = 0;
                item.useTime = 11;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("harpyfeather");
				item.shootSpeed = 13f;
                item.useAnimation = 11;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = mod.ProjectileType("harpyfeather");
		{
			player.AddBuff(mod.BuffType("midboost"), 60);
			player.AddBuff(21, 500);
		}
			}
			
						public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int numberProjectiles = 10 + Main.rand.Next(15);
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("nothing"), damage, knockBack, player.whoAmI);
					Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
            }
            return false;
        }  
	
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 13);
			}
		}
}}