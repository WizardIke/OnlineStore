namespace _16125296_OnlineStore.Migrations.StoreConfiguration
{
    using Models;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<OSDB.StoreContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_16125296_OnlineStore.OSDB.StoreContext";
        }

        protected override void Seed(OSDB.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            var categories = new List<Category>
            {
                new Category {Name = "Rings" },
                new Category {Name = "Wands" },
                new Category {Name = "Weapons" },
                new Category {Name = "Armor" },
                new Category {Name = "Amulets" },
                new Category {Name = "Staves" },
                new Category {Name = "Misc" },
                new Category {Name = "Guns" },
                new Category {Name = "Cloaks" },
                new Category {Name = "Potions" },
                new Category {Name = "Robes" },
                new Category {Name = "Enchanting" },
                new Category {Name = "Tomes and Grimoires" },
             };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var productImages = new List<ProductImage>
            {
                new ProductImage{FileName = "BagOfDevouering1.jpg"},
                new ProductImage{FileName = "BootsOfLevitation.jpg"},
                new ProductImage{FileName = "BootsOfSilence1.jpeg"},
                new ProductImage{FileName = "BootsOfSilence2.jpg"},
                new ProductImage{FileName = "BootsOfSilence3.jpg"},
                new ProductImage{FileName = "CloakOfGliding.jpeg"},
                new ProductImage{FileName = "DaggerOfVenom1.jpeg"},
                new ProductImage{FileName = "DaggerOfVenom2.jpg"},
                new ProductImage{FileName = "DaggerOfVenom3.png"},
                new ProductImage{FileName = "FlamingSword1.jpg"},
                new ProductImage{FileName = "FlamingSword2.jpg"}, //10
                new ProductImage{FileName = "FlamingSword3.jpg"},
                new ProductImage{FileName = "FlyingBoomstick1.jpeg"},
                new ProductImage{FileName = "FlyingBroomstick2.jpg"},
                new ProductImage{FileName = "FlyingCarpet1.png"},
                new ProductImage{FileName = "FlyingCarpet2.jpg"},
                new ProductImage{FileName = "GlowingOrb1.jpg"},
                new ProductImage{FileName = "GlowingOrb2.jpg"},
                new ProductImage{FileName = "GlowingOrb3.png"},
                new ProductImage{FileName = "GlowingOrb4.jpg"},
                new ProductImage{FileName = "GlowingOrb5.jpg"}, //20
                new ProductImage{FileName = "HardenedSword1.JPG"},
                new ProductImage{FileName = "HardenedSword2.jpg"},
                new ProductImage{FileName = "MaceOfSmiting1.jpeg"},
                new ProductImage{FileName = "MaceOfSmiting2.jpg"},
                new ProductImage{FileName = "Pistol.jpg"},
                new ProductImage{FileName = "PortableBoat1.jpg"},
                new ProductImage{FileName = "PortableBoat2.jpg"},
                new ProductImage{FileName = "PortableBoat3.jpg"},
                new ProductImage{FileName = "PortableBoat4.jpg"},
                new ProductImage{FileName = "PotionOfHealing1.png"}, //30
                new ProductImage{FileName = "PotionOfHealing2.png"},
                new ProductImage{FileName = "PotionOfInvisibility.png"},
                new ProductImage{FileName = "RingOfFeatherFalling.jpg"},
                new ProductImage{FileName = "RingOfFeatherFalling2.jpg"},
                new ProductImage{FileName = "RingOfRegeneration1.jpeg"},
                new ProductImage{FileName = "RingOfRegeneration2.jpg"},
                new ProductImage{FileName = "RobesOfTheLichKing.jpg"},
                new ProductImage{FileName = "Stopwatch.jpg"},
                new ProductImage{FileName = "SwordOfLifeStealing.png"},
                new ProductImage{FileName = "TrollHideArmor1.jpg"}, //40
                new ProductImage{FileName = "WandOfMagicMissiles1.jpeg"},
                new ProductImage{FileName = "WandOfMagicMissiles2.png"},
                new ProductImage{FileName = "WandOfMagicMissiles3.png"},
                new ProductImage{FileName = "WandOfMagicMissiles4.png"},
                new ProductImage{FileName = "WandOfMagicMissiles5.png"},
                new ProductImage{FileName = "WingedBoots.jpg"},
                new ProductImage{FileName = "Bahamut Summoning Grimoire.jpg"},
                new ProductImage{FileName = "Ether.jpg"},
                new ProductImage{FileName = "Fire Enchantment Stone.jpg"},
                new ProductImage{FileName = "Grenade.jpg"}, //50
                new ProductImage{FileName = "Hi Ether.jpg"},
                new ProductImage{FileName = "Hi Potion.jpg"},
                new ProductImage{FileName = "Keyblade.jpg"},
                new ProductImage{FileName = "Phoenix Down.jpg"},
                new ProductImage{FileName = "Save the King.jpg"},
                new ProductImage{FileName = "Save the Queen.jpg"},
                new ProductImage{FileName = "Water Enchantment Stone.png"},
                new ProductImage{FileName = "Weapon Enchanting Kit.jpg"},
                new ProductImage{FileName = "Xehanort's Tome of Darkness.jpg"},
                new ProductImage{FileName = "CloakOfInvisibility.png"}, //60
            };
            productImages.ForEach(p => context.ProductImages.AddOrUpdate(c => c.FileName, p));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {
                    Name = "Flaming Greatsword",
                    Description = "While out of its scabbard, this sword emits searing hot flame that are both good for fighting monsters and cooking.",
                    Price = 47580m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Sword of Life Stealing",
                    Description = "Killing an enemy with this sword will restore vigor to the weilder and close wounds.\n\nIn no event shall The Dancing Star be held liably for an irresistible urge to kill or other change in personality related to the use of the item. ",
                    Price = 99999.99m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Hardened Longsword",
                    Description = "An extremely sharp sword that has been magically enchanted to never blunten or tarnish.",
                    Price = 627.65m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Dagger of Venom",
                    Description = "Anyone so much as scratched by this dagger will colapse gasping for air and die shortly after. Do NOT use this dagger for shaving.",
                    Price = 17320m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Mace of Smiting",
                    Description = "When weilded by a brave, honorable, and righteous warrior, This mace can strike down powerful undead, fends, abominations and other unholy creatures in searing light.",
                    Price = 5600m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Portable Boat",
                    Description = "This miniature 80 person ship can fit in your pocket. Place it in water, however, and it will rappidly grow to 40 metres long.",
                    Price = 130000m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Stopwatch",
                    Description = "An intricate deivce of gnomish design, this watch comes on a delicate gold chain and always measures the time accurately. Pressing the button on the top of it will freeze time for everyone but you for a number of minutes equal to the number of minutes left in the hour. However, using the watch more than once in the same hour can result in you being flung years into the past so that you will die of old age shortly after using the watch.",
                    Price = 2500000m,
                    CategoryID = categories.Single(c=>c.Name == "Amulets").ID
                },
                new Product {
                    Name = "Ring of Feather Falling",
                    Description = "While wearing this ring you drift gently to the ground while falling.",
                    Price = 24000m,
                    CategoryID = categories.Single(c=>c.Name == "Rings").ID
                },
                new Product {
                    Name = "Boots of levitation",
                    Description = "While wearing these boots you can drift slowly through the air.",
                    Price = 56200m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Winged Boots",
                    Description = "These boots allow you to fly through the air at high speed.",
                    Price = 153800m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Flying broomstick",
                    Description = "While standing astride this broomstick, you can fly through the air at high speed.",
                    Price = 78000m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Troll Hide Armor",
                    Description = "This armor causes wounds to slowly close and limbs to regrow after a few days while it is worn.",
                    Price = 93800m,
                    CategoryID = categories.Single(c=>c.Name == "Armor").ID
                },
                new Product {
                    Name = "Ring of regeneration",
                    Description = "This ring cause wounds to close and limbs to regrow after about a days while it is worn.",
                    Price = 163800m,
                    CategoryID = categories.Single(c=>c.Name == "Rings").ID
                },
                new Product {
                    Name = "Cloak of Invisibility",
                    Description = "While you wear this cloak with the hood up you are completely invisible.",
                    Price = 2100000m,
                    CategoryID = categories.Single(c=>c.Name == "Cloaks").ID
                },
                new Product {
                    Name = "Cloak of Gliding",
                    Description = "While you wear this cloak and hold the corners out, you can glide at tremendous speed.",
                    Price = 39119.40m,
                    CategoryID = categories.Single(c=>c.Name == "Cloaks").ID
                },
                new Product {
                    Name = "Glowing Orb",
                    Description = "A swirling glow inside this cystal sphere emits a dull glow. Glowing orbs come in a number of colors including green, red, purple and white and have been magically hardened to prevent breaking when dropped as this was a common problem reported with previous models.",
                    Price = 240m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Boots of Silence",
                    Description = "Crafted long ago by elfs, these boots will make you footsteps completely silent.",
                    Price = 62100m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Flying Carpet",
                    Description = "A rug made from brightly colored fine thread. It can fly up to 8 people.",
                    Price = 265000m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Robes of the Lich King",
                    Description = "These legendary robes wither and rot the wearers body making the wearer into an immortal lich. They also make casting even the most vile necromancy spells easier and controlling undead trivial.\n\nThese robe are NOT intented for use, but are meant as a display item. You might be required to pass a physiological test before being able to buy this item.",
                    Price = 15000000m,
                    CategoryID = categories.Single(c=>c.Name == "Robes").ID
                },
                new Product {
                    Name = "Wand of Magic Missiles",
                    Description = "Pointing this wand at something and speaking its command word will cause multiple missiles to shoot out of it. Using it multiple times in a row will reduce the number of missiles it shoots until it is given a few hours to recharge.",
                    Price = 799.99m,
                    CategoryID = categories.Single(c=>c.Name == "Wands").ID
                },
                new Product {
                    Name = "Potion of Healing",
                    Description = "Drinking it will healing minor wounds and will usually get you back on your feet even if you are badly wounded.",
                    Price = 39.99m,
                    CategoryID = categories.Single(c=>c.Name == "Potions").ID
                },
                new Product {
                    Name = "Potion of Invisibility",
                    Description = "Quaffing this potion will render you invisible for an hour.",
                    Price = 450m,
                    CategoryID = categories.Single(c=>c.Name == "Potions").ID
                },
                new Product {
                    Name = "Pistol",
                    Description = "A small weapon that can be held in one hand similar to a hand crossbow. It fires a small piece of lead for devastating effect.\n\nWarning: guns are still experimental and have been known to jam or explode.",
                    Price = 10000m,
                    CategoryID = categories.Single(c=>c.Name == "Guns").ID
                },
                new Product {
                    Name = "Phoenix Down",
                    Description = "Revives an unconscious or dying person.",
                    Price = 300m,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Greater Potion of Healing",
                    Description = "Drinking it will close serious wounds.",
                    Price = 550m,
                    CategoryID = categories.Single(c=>c.Name == "Potions").ID
                },
                new Product {
                    Name = "Ether",
                    Description = "Refreshes the mind allowing you to cast spells and use fancy combat maneuvers for longer before tiring.",
                    Price = 20m,
                    CategoryID = categories.Single(c=>c.Name == "Potions").ID
                },
                new Product {
                    Name = "Greater Ether",
                    Description = "Greatly refreshes the mind allowing you to cast spells and use fancy combat maneuvers for longer before tiring.",
                    Price = 320m,
                    CategoryID = categories.Single(c=>c.Name == "Potions").ID
                },
                new Product {
                    Name = "Keyblade",
                    Description = "A key shaped sword used to battle the Heartless threat",
                    Price = 60000m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Save the Queen",
                    Description = "The most powerful magic staff currently known about",
                    Price = 20000000m,
                    CategoryID = categories.Single(c=>c.Name == "Staves").ID
                },
                new Product {
                    Name = "Save the King",
                    Description = "The most powerful shield that is able to be used for attacking as well as defending",
                    Price = 20000000m,
                    CategoryID = categories.Single(c=>c.Name == "Weapons").ID
                },
                new Product {
                    Name = "Grenade",
                    Description = "Disposable ranged utility to clear an area of enemies",
                    Price = 499.99M,
                    CategoryID = categories.Single(c=>c.Name == "Misc").ID
                },
                new Product {
                    Name = "Weapon Enchanting Kit",
                    Description = "Provides the ability to add enchantments to weapons if compatible. Enchantments not included",
                    Price = 15990m,
                    CategoryID = categories.Single(c=>c.Name == "Enchanting").ID
                },
                new Product {
                    Name = "Water Weapon Enchantment",
                    Description = "Adds a water enchantment to a weapon. Enchanting Kit Required",
                    Price = 1000m,
                    CategoryID = categories.Single(c=>c.Name == "Enchanting").ID
                },
                new Product {
                    Name = "Fire Weapon Enchantment",
                    Description = "Adds a fire enchantment to a weapon Enchanting Kit Required",
                    Price = 1000m,
                    CategoryID = categories.Single(c=>c.Name == "Enchanting").ID
                },
                new Product {
                    Name = "Xehanorts Tome of Darkness",
                    Description = "The lost tome of Xehanort this tome bestows the reader the power of Darkness",
                    Price = 10000000m,
                    CategoryID = categories.Single(c=>c.Name == "Tomes and Grimoires").ID
                },
                new Product {
                    Name = "Bahamut Summoning Grimiore",
                    Description = "Gives the user the ability to summon Bahamut",
                    Price = 3000000m,
                    CategoryID = categories.Single(c=>c.Name == "Tomes and Grimoires").ID
                },
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order { DeliveryAddress = new Address { AddressLine1="Villa Auditore", Town="Monteriggioni",
                    Country="Italy", PostCode="53035" }, TotalPrice=118539.40m,
                    UserID="ezio@asn.com", DateCreated=new DateTime(2490, 11, 29),
                    DeliveryName="Ezio" },
                new Order { DeliveryAddress = new Address { AddressLine1="45 Hausal Road", Town="Dlomable",
                     Country="The Pembarium Empire", PostCode="47538" }, TotalPrice=56200m,
                     UserID="vm@TheMagesGuild.com", DateCreated=new DateTime(2007, 6, 4),
                    DeliveryName="Vendal Markimus" },
                new Order { DeliveryAddress = new Address { AddressLine1="67 Gaiul Street", Town="North Dahort",
                    Country="The Pembarium Empire", PostCode="78465" }, TotalPrice=163919.97m,
                    UserID="Andrin@TheMagesGuild.com", DateCreated=new DateTime(2015, 8, 3),
                    DeliveryName="Andrin Usdil" },
                new Order { DeliveryAddress = new Address { AddressLine1="12 Palace boulevard", Town="Connarma",
                    Country="The Pembarium Empire", PostCode="2348" }, TotalPrice=5760,
                    UserID="Palargey@FastMail.com", DateCreated=new DateTime(2015, 9, 5),
                    DeliveryName="Palargey Bauldine" },
                new Order { DeliveryAddress = new Address { AddressLine1="31 Tavern Street", Town="Gosilia",
                    Country="The North", PostCode="89501" }, TotalPrice=163800m,
                    UserID="Jiak@example.com", DateCreated=new DateTime(2018, 1, 16),
                    DeliveryName="Jiak Banrule" },
                new Order { DeliveryAddress = new Address { AddressLine1="Villa Auditore", Town="Monteriggioni",
                    Country="Italy", PostCode="53035" }, TotalPrice=2100000m,
                    UserID="ezio@asn.com", DateCreated=new DateTime(2507, 4, 15),
                    DeliveryName="Ezio" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="San Fransokyo",
                    Country="The United States of Japan", PostCode="34534" }, TotalPrice=61919.95m,
                    UserID="Sora@OnlineStore.com", DateCreated=new DateTime(2019, 1, 29),
                    DeliveryName="Sora" }
            };
            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();

            var orderLines = new List<OrderLine>
            {
                new OrderLine { OrderID = orders[0].OrderID, ProductID = products.Single( c=> c.Name == "Dagger of Venom").ID,
                    ProductName ="Dagger of Venom", Quantity = 1, UnitPrice=products.Single( c=> c.Name == "Dagger of Venom").Price },
                new OrderLine { OrderID = orders[0].OrderID, ProductID = products.Single( c=> c.Name == "Cloak of Gliding").ID,
                    ProductName ="Cloak of Gliding", Quantity = 1, UnitPrice=products.Single( c=> c.Name == "Cloak of Gliding").Price },
                new OrderLine { OrderID = orders[0].OrderID, ProductID = products.Single( c=> c.Name == "Boots of Silence").ID,
                    ProductName ="Boots of Silence", Quantity = 1, UnitPrice=products.Single( c=> c.Name == "Boots of Silence").Price },

                new OrderLine { OrderID = orders[1].OrderID, ProductID = products.Single( c=> c.Name == "Boots of levitation").ID,
                 ProductName="Boots of levitation", Quantity=1, UnitPrice=products.Single( c=> c.Name =="Boots of levitation").Price },

                new OrderLine { OrderID = orders[2].OrderID, ProductID = products.Single( c=> c.Name == "Ring of regeneration").ID,
                    ProductName ="Ring of regeneration", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Ring of regeneration").Price },
                new OrderLine { OrderID = orders[2].OrderID, ProductID = products.Single( c=> c.Name == "Potion of Healing").ID,
                    ProductName ="Potion of Healing", Quantity=3, UnitPrice=products.Single( c=> c.Name == "Potion of Healing").Price },

                new OrderLine { OrderID = orders[3].OrderID, ProductID = products.Single( c=> c.Name == "Glowing Orb").ID,
                    ProductName ="Glowing Orb", Quantity=24, UnitPrice=products.Single( c=> c.Name == "Glowing Orb").Price },

                new OrderLine { OrderID = orders[4].OrderID, ProductID = products.Single( c=> c.Name == "Winged Boots").ID,
                    ProductName ="Winged Boots", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Winged Boots").Price },
                new OrderLine { OrderID = orders[4].OrderID, ProductID = products.Single( c=> c.Name == "Pistol").ID,
                    ProductName ="Pistol", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Pistol").Price },

                new OrderLine { OrderID = orders[5].OrderID, ProductID = products.Single( c=> c.Name == "Cloak of Invisibility").ID,
                    ProductName ="Cloak of Invisibility", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Cloak of Invisibility").Price },

                new OrderLine { OrderID = orders[6].OrderID, ProductID = products.Single( c=> c.Name == "Phoenix Down").ID,
                    ProductName ="Phoenix Down", Quantity =1, UnitPrice=products.Single( c=> c.Name == "Phoenix Down").Price },
                new OrderLine { OrderID = orders[6].OrderID, ProductID = products.Single( c=> c.Name == "Potion of Healing").ID,
                    ProductName="Potion of Healing", Quantity=5, UnitPrice=products.Single( c=> c.Name =="Potion of Healing").Price },
                new OrderLine { OrderID = orders[6].OrderID, ProductID = products.Single( c=> c.Name == "Greater Potion of Healing").ID,
                    ProductName ="Greater Potion of Healing", Quantity=2, UnitPrice=products.Single( c=> c.Name == "Greater Potion of Healing").Price },
                new OrderLine { OrderID = orders[6].OrderID, ProductID = products.Single( c=> c.Name == "Keyblade").ID,
                    ProductName ="Keyblade", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Keyblade").Price },
                new OrderLine { OrderID = orders[6].OrderID, ProductID = products.Single( c=> c.Name == "Greater Ether").ID,
                    ProductName ="Greater Ether", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Greater Ether").Price }
            };
            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => new { ol.OrderID, ol.ProductID }, c));
            context.SaveChanges();

            var productImageMappings = new List<ProductImageMapping>
            {
                new ProductImageMapping{ ImageNumber = 0, ProductID = products[0].ID, ProductImageID = productImages[9].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[0].ID, ProductImageID = productImages[10].ID },
                new ProductImageMapping{ ImageNumber = 2, ProductID = products[0].ID, ProductImageID = productImages[11].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[1].ID, ProductImageID = productImages[39].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[2].ID, ProductImageID = productImages[21].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[2].ID, ProductImageID = productImages[22].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[3].ID, ProductImageID = productImages[6].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[3].ID, ProductImageID = productImages[7].ID },
                new ProductImageMapping{ ImageNumber = 2, ProductID = products[3].ID, ProductImageID = productImages[8].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[4].ID, ProductImageID = productImages[23].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[4].ID, ProductImageID = productImages[24].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[5].ID, ProductImageID = productImages[26].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[5].ID, ProductImageID = productImages[27].ID },
                new ProductImageMapping{ ImageNumber = 2, ProductID = products[5].ID, ProductImageID = productImages[28].ID },
                new ProductImageMapping{ ImageNumber = 3, ProductID = products[5].ID, ProductImageID = productImages[29].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[6].ID, ProductImageID = productImages[38].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[7].ID, ProductImageID = productImages[33].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[7].ID, ProductImageID = productImages[34].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[8].ID, ProductImageID = productImages[1].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[9].ID, ProductImageID = productImages[46].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[10].ID, ProductImageID = productImages[12].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[10].ID, ProductImageID = productImages[13].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[11].ID, ProductImageID = productImages[40].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[12].ID, ProductImageID = productImages[35].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[12].ID, ProductImageID = productImages[36].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[13].ID, ProductImageID = productImages[60].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[14].ID, ProductImageID = productImages[5].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[15].ID, ProductImageID = productImages[16].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[15].ID, ProductImageID = productImages[17].ID },
                new ProductImageMapping{ ImageNumber = 2, ProductID = products[15].ID, ProductImageID = productImages[18].ID },
                new ProductImageMapping{ ImageNumber = 3, ProductID = products[15].ID, ProductImageID = productImages[19].ID },
                new ProductImageMapping{ ImageNumber = 4, ProductID = products[15].ID, ProductImageID = productImages[20].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[16].ID, ProductImageID = productImages[2].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[16].ID, ProductImageID = productImages[3].ID },
                new ProductImageMapping{ ImageNumber = 2, ProductID = products[16].ID, ProductImageID = productImages[4].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[17].ID, ProductImageID = productImages[14].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[17].ID, ProductImageID = productImages[15].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[18].ID, ProductImageID = productImages[37].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[19].ID, ProductImageID = productImages[41].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[19].ID, ProductImageID = productImages[42].ID },
                new ProductImageMapping{ ImageNumber = 2, ProductID = products[19].ID, ProductImageID = productImages[43].ID },
                new ProductImageMapping{ ImageNumber = 3, ProductID = products[19].ID, ProductImageID = productImages[44].ID },
                new ProductImageMapping{ ImageNumber = 4, ProductID = products[19].ID, ProductImageID = productImages[45].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[20].ID, ProductImageID = productImages[30].ID },
                new ProductImageMapping{ ImageNumber = 1, ProductID = products[20].ID, ProductImageID = productImages[31].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[21].ID, ProductImageID = productImages[32].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[22].ID, ProductImageID = productImages[25].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[23].ID, ProductImageID = productImages[54].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[24].ID, ProductImageID = productImages[52].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[25].ID, ProductImageID = productImages[48].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[26].ID, ProductImageID = productImages[51].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[27].ID, ProductImageID = productImages[53].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[28].ID, ProductImageID = productImages[56].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[29].ID, ProductImageID = productImages[55].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[30].ID, ProductImageID = productImages[50].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[31].ID, ProductImageID = productImages[58].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[32].ID, ProductImageID = productImages[57].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[33].ID, ProductImageID = productImages[49].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[34].ID, ProductImageID = productImages[59].ID },

                new ProductImageMapping{ ImageNumber = 0, ProductID = products[35].ID, ProductImageID = productImages[47].ID },
            };
            productImageMappings.ForEach(p => context.ProductImageMappings.AddOrUpdate(ol => ol.ProductImageID, p));
            context.SaveChanges();
        }
    }
}
