using System;
using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Drops
{
	public class bottledrop : GlobalNPC
	{	
	
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == 3)
		{
			if (Main.rand.NextFloat(100) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Wine_Bottle"));
			}
		}
		
		if(npc.type == 21)
		{
			if (Main.rand.NextFloat(100) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Toy_Knife"));
			}
		}
		// Addtional if statements here if you would like to add drops to other vanilla npc.
	}
}}
