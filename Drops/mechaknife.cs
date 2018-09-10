using System;
using Terraria;
using Terraria.ModLoader;

namespace TCSSC.Drops
{
	public class mechaknife : GlobalNPC
	{	
	
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == 125)
		{
			if (Main.rand.NextFloat(4) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("mecacutter"));
			}
		}
		
		if(npc.type == 126)
		{
			if (Main.rand.NextFloat(4) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("mecacutter"));
			}
		}
		
			if(npc.type == 127)
		{
			if (Main.rand.NextFloat(4) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("mecacutter"));
			}
		}
		
				if(npc.type == 134)
		{
			if (Main.rand.NextFloat(4) < 1) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("mecacutter"));
			}
		}
				if(npc.type == 398)
		{
			if (Main.rand.NextFloat(100) < 11.11) // 13.23% chance
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Chaotic_Cosmos"));
			}
		}
		// Addtional if statements here if you would like to add drops to other vanilla npc.
	}
}}
