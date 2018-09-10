
		using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TCSSC.Items.Weapons {
public class Fiery_Knife : ModItem
{
	
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fiery Knife");
			Tooltip.SetDefault("'The melting ninjas perfect knife'\nHas a chance to shot some fire blasts at the sky and front you when you hit an enemy");
		}
    public override void SetDefaults()
    {
       item.damage = 40;
        item.melee = true;
        item.width = 16;
        item.height = 16;
        item.useTime = 13;
        item.useAnimation = 13;
        item.useStyle = 3;
        item.knockBack = 2;
        item.value = 10000;
        item.rare = 3;
        item.UseSound = SoundID.Item1;
		item.shoot = mod.ProjectileType("nothing");
		item.shootSpeed = 3f;
        item.autoReuse = true;
    }
	
	    public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2) // Right Click function
            {
				item.useStyle = 1;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 300;
				item.knockBack = 3;
                item.useTime = 5;
				item.UseSound = SoundID.Item1;
                item.useAnimation = 100;
				item.shoot = mod.ProjectileType("Gamma_Ray");
                item.shootSpeed = 10f;
				item.mana = 100;
            } else
			
            {
				item.useStyle = 3;
				item.autoReuse = true;
				item.melee = true;
				item.damage = 40;
				item.knockBack = 2;
                item.useTime = 13;
				item.UseSound = SoundID.Item1;
				item.shoot = mod.ProjectileType("nothing");
				item.shootSpeed = 10f;
                item.useAnimation = 13;
				item.mana = 0;
            }
		         return base.CanUseItem(player);
        }
		
		   public override void AddRecipes()                
    {                                             
	
     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(175, 10);	
        recipe.SetResult(this);                     
	recipe.AddTile(16);
        recipe.AddRecipe();
    }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
			{
	item.shoot = mod.ProjectileType("Fire_Blast_Good");
		{
			target.AddBuff(24, 300);
			player.AddBuff(mod.BuffType("lowboost"), 240);
			player.AddBuff(21, 900);
		}
			}
	
	public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6);
			}
		}
		
			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int numberProjectiles = 2 + Main.rand.Next(10);
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
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        } 
		
}}