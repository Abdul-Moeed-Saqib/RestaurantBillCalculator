using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    public class Items
    {
        public static List<Item> beverages = new List<Item>()
        {
            new Item() {Name = "Soda", Category = "Beverage", Price = 1.95M},
            new Item() {Name = "Tea", Category = "Beverage", Price = 1.50M},
            new Item() {Name = "Coffee", Category = "Beverage", Price = 1.25M},
            new Item() {Name = "Mineral Water", Category = "Beverage", Price = 2.95M},
            new Item() {Name = "Juice", Category = "Beverage", Price = 2.50M},
            new Item() {Name = "Milk", Category = "Beverage", Price = 1.50M},
        };

        public static List<Item> appetizer = new List<Item>()
        {
            new Item() {Name = "Nachos", Category = "Appetizer", Price = 8.95M},
            new Item() {Name = "Buffalo Wings", Category = "Appetizer", Price = 5.95M},
            new Item() {Name = "Buffalo Fingers", Category = "Appetizer", Price = 6.95M},
            new Item() {Name = "Potato Skins", Category = "Appetizer", Price = 8.95M},
            new Item() {Name = "Mushroom Caps", Category = "Appetizer", Price = 10.95M},
            new Item() {Name = "Shrimp Cocktail", Category = "Appetizer", Price = 12.95M},
            new Item() {Name = "Chips and Salsa", Category = "Appetizer", Price = 6.95M},
        };

        public static List<Item> mainCourses = new List<Item>()
        {
            new Item() {Name = "Seafood Alfredo", Category = "Main Course", Price = 15.95M},
            new Item() {Name = "Chicken Alfredo", Category = "Main Course", Price = 13.95M},
            new Item() {Name = "Chicken Picatta", Category = "Main Course", Price = 13.95M},
            new Item() {Name = "Turkey Club", Category = "Main Course", Price = 11.95M},
            new Item() {Name = "Lobster Pie", Category = "Main Course", Price = 19.95M},
            new Item() {Name = "Prime Rib", Category = "Main Course", Price = 20.95M},
        };

        public static List<Item> desserts = new List<Item>()
        {
            new Item() {Name = "Sundae", Category = "Dessert", Price = 3.95M},
            new Item() {Name = "Carrot Cake", Category = "Dessert", Price = 5.95M},
            new Item() {Name = "Mud Pie", Category = "Dessert", Price = 4.95M},
            new Item() {Name = "Apple Crisp", Category = "Dessert", Price = 5.95M},
        };
    }
}
