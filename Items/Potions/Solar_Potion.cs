using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TCSSC.Items.Potions {

    public class Solar_Potion : ModItem
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Potion");
			Tooltip.SetDefault("Increases defense and regeneration");
		}
		
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 100;                
            item.rare = 1;
            item.buffType = mod.BuffType("Solar_Boost");    //this is where you put your Buff name
            item.buffTime = 10000;    //this is the buff duration        20000 = 6 min
            return;
        }
		
		 public override void AddRecipes()                
    {                                             
	
     ModRecipe recipe = new ModRecipe(mod);                 
recipe.AddIngredient(3458, 2);
recipe.AddIngredient(318);
recipe.AddIngredient(126);	
        recipe.SetResult(this);                     
	recipe.AddTile(13);
        recipe.AddRecipe();
    }		
    }
}